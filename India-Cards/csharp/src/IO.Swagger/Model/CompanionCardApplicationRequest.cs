/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    /// CompanionCardApplicationRequest
    /// </summary>
    [DataContract]
        public partial class CompanionCardApplicationRequest :  IEquatable<CompanionCardApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanionCardApplicationRequest" /> class.
        /// </summary>
        /// <param name="controlFlowId">Control Flow ID.</param>
        public CompanionCardApplicationRequest(string controlFlowId = default(string))
        {
            this.ControlFlowId = controlFlowId;
        }
        
        /// <summary>
        /// Control Flow ID
        /// </summary>
        /// <value>Control Flow ID</value>
        [DataMember(Name="controlFlowId", EmitDefaultValue=false)]
        public string ControlFlowId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanionCardApplicationRequest {\n");
            sb.Append("  ControlFlowId: ").Append(ControlFlowId).Append("\n");
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
            return this.Equals(input as CompanionCardApplicationRequest);
        }

        /// <summary>
        /// Returns true if CompanionCardApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanionCardApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanionCardApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ControlFlowId == input.ControlFlowId ||
                    (this.ControlFlowId != null &&
                    this.ControlFlowId.Equals(input.ControlFlowId))
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
