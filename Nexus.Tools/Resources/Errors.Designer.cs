﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nexus.Tools.Validations.Resources {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Nexus.Tools.Validations.Resources.Errors", typeof(Errors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a You must have at least &apos;{0}&apos; years to continue..
        /// </summary>
        public static string BirthdayValidation {
            get {
                return ResourceManager.GetString("BirthdayValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The &apos;{0}&apos; field of being equal to &apos;{1}&apos;..
        /// </summary>
        public static string CompareValidation {
            get {
                return ResourceManager.GetString("CompareValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The &apos;{0}&apos; field must be Email adress..
        /// </summary>
        public static string EmailAdressValidation {
            get {
                return ResourceManager.GetString("EmailAdressValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The email is already being used..
        /// </summary>
        public static string EmailUsed {
            get {
                return ResourceManager.GetString("EmailUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a We must be accepted to continue registration..
        /// </summary>
        public static string NotAcceptTerms {
            get {
                return ResourceManager.GetString("NotAcceptTerms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a A password must contain a number, a lowercase letter, a capital letter and a special character..
        /// </summary>
        public static string PasswordValidation {
            get {
                return ResourceManager.GetString("PasswordValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The &apos;{0}&apos; field must be a valid phone number..
        /// </summary>
        public static string PhoneValidation {
            get {
                return ResourceManager.GetString("PhoneValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The field &apos;{0}&apos; is required..
        /// </summary>
        public static string RequiredError {
            get {
                return ResourceManager.GetString("RequiredError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The {0} must be at least {2} characters long..
        /// </summary>
        public static string StringLengthValidation {
            get {
                return ResourceManager.GetString("StringLengthValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a This value is not and a time use the format: 00:00:00.
        /// </summary>
        public static string TimeSpanValidation {
            get {
                return ResourceManager.GetString("TimeSpanValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The &apos;{0}&apos; field is not a valid ZIP Code..
        /// </summary>
        public static string ZipCodeValidation {
            get {
                return ResourceManager.GetString("ZipCodeValidation", resourceCulture);
            }
        }
    }
}