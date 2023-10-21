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
    /// PartialResponseInformation
    /// </summary>
    [DataContract]
        public partial class PartialResponseInformation :  IEquatable<PartialResponseInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialResponseInformation" /> class.
        /// </summary>
        /// <param name="fieldName">This refer to the field for which partial failure happened.</param>
        /// <param name="reasonCode">This refer to reason info of partial failure..</param>
        /// <param name="additionalInformation">This refer to additional details of partial failure..</param>
        public PartialResponseInformation(string fieldName = default(string), string reasonCode = default(string), string additionalInformation = default(string))
        {
            this.FieldName = fieldName;
            this.ReasonCode = reasonCode;
            this.AdditionalInformation = additionalInformation;
        }
        
        /// <summary>
        /// This refer to the field for which partial failure happened
        /// </summary>
        /// <value>This refer to the field for which partial failure happened</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// This refer to reason info of partial failure.
        /// </summary>
        /// <value>This refer to reason info of partial failure.</value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// This refer to additional details of partial failure.
        /// </summary>
        /// <value>This refer to additional details of partial failure.</value>
        [DataMember(Name="additionalInformation", EmitDefaultValue=false)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartialResponseInformation {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
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
            return this.Equals(input as PartialResponseInformation);
        }

        /// <summary>
        /// Returns true if PartialResponseInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of PartialResponseInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartialResponseInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.AdditionalInformation == input.AdditionalInformation ||
                    (this.AdditionalInformation != null &&
                    this.AdditionalInformation.Equals(input.AdditionalInformation))
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.AdditionalInformation != null)
                    hashCode = hashCode * 59 + this.AdditionalInformation.GetHashCode();
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
