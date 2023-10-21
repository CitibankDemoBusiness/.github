/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    /// UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
    /// </summary>
    [DataContract]
        public partial class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest :  IEquatable<UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest" /> class.
        /// </summary>
        /// <param name="applicantDetail">applicantDetail.</param>
        /// <param name="loanPurpose">This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description..</param>
        public UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest(ApplicantDetail applicantDetail = default(ApplicantDetail), string loanPurpose = default(string))
        {
            this.ApplicantDetail = applicantDetail;
            this.LoanPurpose = loanPurpose;
        }
        
        /// <summary>
        /// Gets or Sets ApplicantDetail
        /// </summary>
        [DataMember(Name="applicantDetail", EmitDefaultValue=false)]
        public ApplicantDetail ApplicantDetail { get; set; }

        /// <summary>
        /// This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.</value>
        [DataMember(Name="loanPurpose", EmitDefaultValue=false)]
        public string LoanPurpose { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest {\n");
            sb.Append("  ApplicantDetail: ").Append(ApplicantDetail).Append("\n");
            sb.Append("  LoanPurpose: ").Append(LoanPurpose).Append("\n");
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
            return this.Equals(input as UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest);
        }

        /// <summary>
        /// Returns true if UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicantDetail == input.ApplicantDetail ||
                    (this.ApplicantDetail != null &&
                    this.ApplicantDetail.Equals(input.ApplicantDetail))
                ) && 
                (
                    this.LoanPurpose == input.LoanPurpose ||
                    (this.LoanPurpose != null &&
                    this.LoanPurpose.Equals(input.LoanPurpose))
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
                if (this.ApplicantDetail != null)
                    hashCode = hashCode * 59 + this.ApplicantDetail.GetHashCode();
                if (this.LoanPurpose != null)
                    hashCode = hashCode * 59 + this.LoanPurpose.GetHashCode();
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