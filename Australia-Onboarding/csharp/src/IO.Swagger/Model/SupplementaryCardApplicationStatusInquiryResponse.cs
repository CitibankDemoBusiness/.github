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
    /// SupplementaryCardApplicationStatusInquiryResponse
    /// </summary>
    [DataContract]
        public partial class SupplementaryCardApplicationStatusInquiryResponse :  IEquatable<SupplementaryCardApplicationStatusInquiryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupplementaryCardApplicationStatusInquiryResponse" /> class.
        /// </summary>
        /// <param name="applicationStatus">Application Status of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStatus} resource to get possible value of this field with description. (required).</param>
        /// <param name="applicationCreationDate">Date on which the application was created in ISO 8601 date format YYYY - MM - DD. (required).</param>
        public SupplementaryCardApplicationStatusInquiryResponse(string applicationStatus = default(string), DateTime? applicationCreationDate = default(DateTime?))
        {
            // to ensure "applicationStatus" is required (not null)
            if (applicationStatus == null)
            {
                throw new InvalidDataException("applicationStatus is a required property for SupplementaryCardApplicationStatusInquiryResponse and cannot be null");
            }
            else
            {
                this.ApplicationStatus = applicationStatus;
            }
            // to ensure "applicationCreationDate" is required (not null)
            if (applicationCreationDate == null)
            {
                throw new InvalidDataException("applicationCreationDate is a required property for SupplementaryCardApplicationStatusInquiryResponse and cannot be null");
            }
            else
            {
                this.ApplicationCreationDate = applicationCreationDate;
            }
        }
        
        /// <summary>
        /// Application Status of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStatus} resource to get possible value of this field with description.
        /// </summary>
        /// <value>Application Status of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStatus} resource to get possible value of this field with description.</value>
        [DataMember(Name="applicationStatus", EmitDefaultValue=false)]
        public string ApplicationStatus { get; set; }

        /// <summary>
        /// Date on which the application was created in ISO 8601 date format YYYY - MM - DD.
        /// </summary>
        /// <value>Date on which the application was created in ISO 8601 date format YYYY - MM - DD.</value>
        [DataMember(Name="applicationCreationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ApplicationCreationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupplementaryCardApplicationStatusInquiryResponse {\n");
            sb.Append("  ApplicationStatus: ").Append(ApplicationStatus).Append("\n");
            sb.Append("  ApplicationCreationDate: ").Append(ApplicationCreationDate).Append("\n");
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
            return this.Equals(input as SupplementaryCardApplicationStatusInquiryResponse);
        }

        /// <summary>
        /// Returns true if SupplementaryCardApplicationStatusInquiryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SupplementaryCardApplicationStatusInquiryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupplementaryCardApplicationStatusInquiryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationStatus == input.ApplicationStatus ||
                    (this.ApplicationStatus != null &&
                    this.ApplicationStatus.Equals(input.ApplicationStatus))
                ) && 
                (
                    this.ApplicationCreationDate == input.ApplicationCreationDate ||
                    (this.ApplicationCreationDate != null &&
                    this.ApplicationCreationDate.Equals(input.ApplicationCreationDate))
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
                if (this.ApplicationStatus != null)
                    hashCode = hashCode * 59 + this.ApplicationStatus.GetHashCode();
                if (this.ApplicationCreationDate != null)
                    hashCode = hashCode * 59 + this.ApplicationCreationDate.GetHashCode();
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
