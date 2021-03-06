using Nexus.Tools.Validations.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nexus.Tools.Validations.Attributes
{
    /// <summary>
    /// Validates whether the object and or contains a valid CPF or CNPJ.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class CpfOrCnpjAttribute : ValidationAttribute
    {
        public CpfOrCnpjAttribute()
        {
            ErrorMessage = null;
            ErrorMessageResourceType = typeof(Errors);
            ErrorMessageResourceName = "CpfOrCnpjValidation";
        }
        public override bool IsValid(object value)
        {
            string cpfCnpj = string.Empty;

            if (value == null)
                return false;

            if (value is string)
            {
                cpfCnpj = value as string;
            }
            else
            {
                cpfCnpj = value.ToString();
            }

            if (CPFOnly)
            {
                if (
                   ErrorMessageResourceName != null &&
                   ErrorMessageResourceType != null)
                {
                    if (ErrorMessageResourceName == "CpfOrCnpjValidation" &&
                    ErrorMessageResourceType.FullName == typeof(Errors).FullName)
                        ErrorMessageResourceName = "CpfValidation";
                }

                return IsCpf(cpfCnpj);
            }


            if (CNPJOnly)
            {
                if (
                    ErrorMessageResourceName != null &&
                    ErrorMessageResourceType != null)
                {
                    if (ErrorMessageResourceName == "CpfOrCnpjValidation" &&
                    ErrorMessageResourceType.FullName == typeof(Errors).FullName)
                        ErrorMessageResourceName = "CnpjValidation";
                }
               
                return IsCnpj(cpfCnpj);
            }


            return IsCpf(cpfCnpj) || IsCnpj(cpfCnpj);
        }


        /// <summary>
        /// Sets whether it will only be valid if and a valid CPF.
        /// </summary>
        public bool CPFOnly { get; set; }
        /// <summary>
        /// Sets whether it will only be valid if and a valid CNPJ.
        /// </summary>
        public bool CNPJOnly { get; set; }

        private static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}