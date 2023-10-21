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
    /// ExternalCreditCardDetailsAdd
    /// </summary>
    [DataContract]
        public partial class ExternalCreditCardDetailsAdd :  IEquatable<ExternalCreditCardDetailsAdd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalCreditCardDetailsAdd" /> class.
        /// </summary>
        /// <param name="bankName">Name of the bank issued the credit card..</param>
        /// <param name="creditCardNumber">Other Credit Card Number of the applicant, to be used for bill payments.</param>
        public ExternalCreditCardDetailsAdd(string bankName = default(string), string creditCardNumber = default(string))
        {
            this.BankName = bankName;
            this.CreditCardNumber = creditCardNumber;
        }
        
        /// <summary>
        /// Name of the bank issued the credit card.
        /// </summary>
        /// <value>Name of the bank issued the credit card.</value>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Other Credit Card Number of the applicant, to be used for bill payments
        /// </summary>
        /// <value>Other Credit Card Number of the applicant, to be used for bill payments</value>
        [DataMember(Name="creditCardNumber", EmitDefaultValue=false)]
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalCreditCardDetailsAdd {\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  CreditCardNumber: ").Append(CreditCardNumber).Append("\n");
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
            return this.Equals(input as ExternalCreditCardDetailsAdd);
        }

        /// <summary>
        /// Returns true if ExternalCreditCardDetailsAdd instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalCreditCardDetailsAdd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalCreditCardDetailsAdd input)
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
                    this.CreditCardNumber == input.CreditCardNumber ||
                    (this.CreditCardNumber != null &&
                    this.CreditCardNumber.Equals(input.CreditCardNumber))
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
                if (this.CreditCardNumber != null)
                    hashCode = hashCode * 59 + this.CreditCardNumber.GetHashCode();
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