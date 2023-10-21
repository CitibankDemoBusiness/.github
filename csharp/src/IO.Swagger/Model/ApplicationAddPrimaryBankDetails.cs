/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ApplicationAddPrimaryBankDetails
    /// </summary>
    [DataContract]
        public partial class ApplicationAddPrimaryBankDetails :  IEquatable<ApplicationAddPrimaryBankDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAddPrimaryBankDetails" /> class.
        /// </summary>
        /// <param name="bankName">Main bank name with Citi. This is a reference data field. Please use /v1/apac/utilities/referenceData/{bankName} resource to get valid value of this field with description..</param>
        /// <param name="accountType">Type of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountType} resource to get valid value of this field with description..</param>
        public ApplicationAddPrimaryBankDetails(string bankName = default(string), string accountType = default(string))
        {
            this.BankName = bankName;
            this.AccountType = accountType;
        }
        
        /// <summary>
        /// Main bank name with Citi. This is a reference data field. Please use /v1/apac/utilities/referenceData/{bankName} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Main bank name with Citi. This is a reference data field. Please use /v1/apac/utilities/referenceData/{bankName} resource to get valid value of this field with description.</value>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Type of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Type of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountType} resource to get valid value of this field with description.</value>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAddPrimaryBankDetails {\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationAddPrimaryBankDetails);
        }

        /// <summary>
        /// Returns true if ApplicationAddPrimaryBankDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAddPrimaryBankDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAddPrimaryBankDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
