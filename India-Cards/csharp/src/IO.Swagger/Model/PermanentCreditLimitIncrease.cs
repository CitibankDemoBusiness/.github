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
    /// PermanentCreditLimitIncrease
    /// </summary>
    [DataContract]
        public partial class PermanentCreditLimitIncrease :  IEquatable<PermanentCreditLimitIncrease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentCreditLimitIncrease" /> class.
        /// </summary>
        /// <param name="cardId">Unique Id of the card in encrypted format. (required).</param>
        /// <param name="requestedCreditLimitAmount">Customers preferred revised credit limit. This is the combined limit  shared with all the existing credit cards of the customer (required).</param>
        public PermanentCreditLimitIncrease(string cardId = default(string), double? requestedCreditLimitAmount = default(double?))
        {
            // to ensure "cardId" is required (not null)
            if (cardId == null)
            {
                throw new InvalidDataException("cardId is a required property for PermanentCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.CardId = cardId;
            }
            // to ensure "requestedCreditLimitAmount" is required (not null)
            if (requestedCreditLimitAmount == null)
            {
                throw new InvalidDataException("requestedCreditLimitAmount is a required property for PermanentCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.RequestedCreditLimitAmount = requestedCreditLimitAmount;
            }
        }
        
        /// <summary>
        /// Unique Id of the card in encrypted format.
        /// </summary>
        /// <value>Unique Id of the card in encrypted format.</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// Customers preferred revised credit limit. This is the combined limit  shared with all the existing credit cards of the customer
        /// </summary>
        /// <value>Customers preferred revised credit limit. This is the combined limit  shared with all the existing credit cards of the customer</value>
        [DataMember(Name="requestedCreditLimitAmount", EmitDefaultValue=false)]
        public double? RequestedCreditLimitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermanentCreditLimitIncrease {\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  RequestedCreditLimitAmount: ").Append(RequestedCreditLimitAmount).Append("\n");
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
            return this.Equals(input as PermanentCreditLimitIncrease);
        }

        /// <summary>
        /// Returns true if PermanentCreditLimitIncrease instances are equal
        /// </summary>
        /// <param name="input">Instance of PermanentCreditLimitIncrease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermanentCreditLimitIncrease input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.RequestedCreditLimitAmount == input.RequestedCreditLimitAmount ||
                    (this.RequestedCreditLimitAmount != null &&
                    this.RequestedCreditLimitAmount.Equals(input.RequestedCreditLimitAmount))
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
                if (this.CardId != null)
                    hashCode = hashCode * 59 + this.CardId.GetHashCode();
                if (this.RequestedCreditLimitAmount != null)
                    hashCode = hashCode * 59 + this.RequestedCreditLimitAmount.GetHashCode();
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
