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
    /// ApplicationAddPartnerCustomerDetails
    /// </summary>
    [DataContract]
        public partial class ApplicationAddPartnerCustomerDetails :  IEquatable<ApplicationAddPartnerCustomerDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAddPartnerCustomerDetails" /> class.
        /// </summary>
        /// <param name="partnerCustomerInternalId">Unique customer internal number associated with the partner..</param>
        /// <param name="partnerCustomerId">Unique customer Id associated with the partner.</param>
        /// <param name="partnerCustomerSegment">Partner customer segment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{partnerCustomerSegment} resource to get possible value of this field with description. You can use partnerCustomerSegment field name as the referenceCode parameter to retrieve the values..</param>
        public ApplicationAddPartnerCustomerDetails(string partnerCustomerInternalId = default(string), string partnerCustomerId = default(string), string partnerCustomerSegment = default(string))
        {
            this.PartnerCustomerInternalId = partnerCustomerInternalId;
            this.PartnerCustomerId = partnerCustomerId;
            this.PartnerCustomerSegment = partnerCustomerSegment;
        }
        
        /// <summary>
        /// Unique customer internal number associated with the partner.
        /// </summary>
        /// <value>Unique customer internal number associated with the partner.</value>
        [DataMember(Name="partnerCustomerInternalId", EmitDefaultValue=false)]
        public string PartnerCustomerInternalId { get; set; }

        /// <summary>
        /// Unique customer Id associated with the partner
        /// </summary>
        /// <value>Unique customer Id associated with the partner</value>
        [DataMember(Name="partnerCustomerId", EmitDefaultValue=false)]
        public string PartnerCustomerId { get; set; }

        /// <summary>
        /// Partner customer segment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{partnerCustomerSegment} resource to get possible value of this field with description. You can use partnerCustomerSegment field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Partner customer segment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{partnerCustomerSegment} resource to get possible value of this field with description. You can use partnerCustomerSegment field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="partnerCustomerSegment", EmitDefaultValue=false)]
        public string PartnerCustomerSegment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAddPartnerCustomerDetails {\n");
            sb.Append("  PartnerCustomerInternalId: ").Append(PartnerCustomerInternalId).Append("\n");
            sb.Append("  PartnerCustomerId: ").Append(PartnerCustomerId).Append("\n");
            sb.Append("  PartnerCustomerSegment: ").Append(PartnerCustomerSegment).Append("\n");
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
            return this.Equals(input as ApplicationAddPartnerCustomerDetails);
        }

        /// <summary>
        /// Returns true if ApplicationAddPartnerCustomerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAddPartnerCustomerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAddPartnerCustomerDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PartnerCustomerInternalId == input.PartnerCustomerInternalId ||
                    (this.PartnerCustomerInternalId != null &&
                    this.PartnerCustomerInternalId.Equals(input.PartnerCustomerInternalId))
                ) && 
                (
                    this.PartnerCustomerId == input.PartnerCustomerId ||
                    (this.PartnerCustomerId != null &&
                    this.PartnerCustomerId.Equals(input.PartnerCustomerId))
                ) && 
                (
                    this.PartnerCustomerSegment == input.PartnerCustomerSegment ||
                    (this.PartnerCustomerSegment != null &&
                    this.PartnerCustomerSegment.Equals(input.PartnerCustomerSegment))
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
                if (this.PartnerCustomerInternalId != null)
                    hashCode = hashCode * 59 + this.PartnerCustomerInternalId.GetHashCode();
                if (this.PartnerCustomerId != null)
                    hashCode = hashCode * 59 + this.PartnerCustomerId.GetHashCode();
                if (this.PartnerCustomerSegment != null)
                    hashCode = hashCode * 59 + this.PartnerCustomerSegment.GetHashCode();
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