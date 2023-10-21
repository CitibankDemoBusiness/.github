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
    /// ApplicantSalaryAndContributionsUploadRequest
    /// </summary>
    [DataContract]
        public partial class ApplicantSalaryAndContributionsUploadRequest :  IEquatable<ApplicantSalaryAndContributionsUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantSalaryAndContributionsUploadRequest" /> class.
        /// </summary>
        /// <param name="controlFlowId">Control flow id is used to control the flow for subsequent requests in the session. (required).</param>
        /// <param name="consentDetails">consentDetails.</param>
        public ApplicantSalaryAndContributionsUploadRequest(string controlFlowId = default(string), List<ConsentDetails> consentDetails = default(List<ConsentDetails>))
        {
            // to ensure "controlFlowId" is required (not null)
            if (controlFlowId == null)
            {
                throw new InvalidDataException("controlFlowId is a required property for ApplicantSalaryAndContributionsUploadRequest and cannot be null");
            }
            else
            {
                this.ControlFlowId = controlFlowId;
            }
            this.ConsentDetails = consentDetails;
        }
        
        /// <summary>
        /// Control flow id is used to control the flow for subsequent requests in the session.
        /// </summary>
        /// <value>Control flow id is used to control the flow for subsequent requests in the session.</value>
        [DataMember(Name="controlFlowId", EmitDefaultValue=false)]
        public string ControlFlowId { get; set; }

        /// <summary>
        /// Gets or Sets ConsentDetails
        /// </summary>
        [DataMember(Name="consentDetails", EmitDefaultValue=false)]
        public List<ConsentDetails> ConsentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicantSalaryAndContributionsUploadRequest {\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
            sb.Append("  ConsentDetails: ").Append(ConsentDetails).Append("\n");
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
            return this.Equals(input as ApplicantSalaryAndContributionsUploadRequest);
        }

        /// <summary>
        /// Returns true if ApplicantSalaryAndContributionsUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantSalaryAndContributionsUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantSalaryAndContributionsUploadRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControlFlowId == input.ControlFlowId ||
                    (this.ControlFlowId != null &&
                    this.ControlFlowId.Equals(input.ControlFlowId))
                ) && 
                (
                    this.ConsentDetails == input.ConsentDetails ||
                    this.ConsentDetails != null &&
                    input.ConsentDetails != null &&
                    this.ConsentDetails.SequenceEqual(input.ConsentDetails)
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
                if (this.ControlFlowId != null)
                    hashCode = hashCode * 59 + this.ControlFlowId.GetHashCode();
                if (this.ConsentDetails != null)
                    hashCode = hashCode * 59 + this.ConsentDetails.GetHashCode();
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
