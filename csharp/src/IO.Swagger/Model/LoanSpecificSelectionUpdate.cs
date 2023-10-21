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
    /// LoanSpecificSelectionUpdate
    /// </summary>
    [DataContract]
        public partial class LoanSpecificSelectionUpdate :  IEquatable<LoanSpecificSelectionUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanSpecificSelectionUpdate" /> class.
        /// </summary>
        /// <param name="loanAmount">Loan Amount accepted by customer.</param>
        /// <param name="tenor">Tenor of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. You can use tenor field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="interestRate">Interest rate applicable for the loan.</param>
        public LoanSpecificSelectionUpdate(double? loanAmount = default(double?), string tenor = default(string), double? interestRate = default(double?))
        {
            this.LoanAmount = loanAmount;
            this.Tenor = tenor;
            this.InterestRate = interestRate;
        }
        
        /// <summary>
        /// Loan Amount accepted by customer
        /// </summary>
        /// <value>Loan Amount accepted by customer</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Tenor of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. You can use tenor field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Tenor of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. You can use tenor field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public string Tenor { get; set; }

        /// <summary>
        /// Interest rate applicable for the loan
        /// </summary>
        /// <value>Interest rate applicable for the loan</value>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public double? InterestRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanSpecificSelectionUpdate {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
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
            return this.Equals(input as LoanSpecificSelectionUpdate);
        }

        /// <summary>
        /// Returns true if LoanSpecificSelectionUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanSpecificSelectionUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanSpecificSelectionUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
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
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
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
