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
    /// UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse
    /// </summary>
    [DataContract]
        public partial class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse :  IEquatable<UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse" /> class.
        /// </summary>
        /// <param name="applicationStage">Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. (required).</param>
        public UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse(string applicationStage = default(string))
        {
            // to ensure "applicationStage" is required (not null)
            if (applicationStage == null)
            {
                throw new InvalidDataException("applicationStage is a required property for UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse and cannot be null");
            }
            else
            {
                this.ApplicationStage = applicationStage;
            }
        }
        
        /// <summary>
        /// Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description.
        /// </summary>
        /// <value>Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description.</value>
        [DataMember(Name="applicationStage", EmitDefaultValue=false)]
        public string ApplicationStage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse {\n");
            sb.Append("  ApplicationStage: ").Append(ApplicationStage).Append("\n");
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
            return this.Equals(input as UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse);
        }

        /// <summary>
        /// Returns true if UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationStage == input.ApplicationStage ||
                    (this.ApplicationStage != null &&
                    this.ApplicationStage.Equals(input.ApplicationStage))
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
                if (this.ApplicationStage != null)
                    hashCode = hashCode * 59 + this.ApplicationStage.GetHashCode();
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
