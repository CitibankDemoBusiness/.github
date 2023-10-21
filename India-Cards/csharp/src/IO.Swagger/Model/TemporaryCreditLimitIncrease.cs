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
    /// TemporaryCreditLimitIncrease
    /// </summary>
    [DataContract]
        public partial class TemporaryCreditLimitIncrease :  IEquatable<TemporaryCreditLimitIncrease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporaryCreditLimitIncrease" /> class.
        /// </summary>
        /// <param name="cardId">The card identifier in encrypted format. (required).</param>
        /// <param name="creditLimitIncreaseEndDate">Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD. (required).</param>
        /// <param name="reasonCode">Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. (required).</param>
        /// <param name="creditLimitIncreaseStartDate">Credit limit increase start date in ISO 8601 date format YYYY-MM-DD. (required).</param>
        /// <param name="requestedCreditLimitAmount">Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer (required).</param>
        public TemporaryCreditLimitIncrease(string cardId = default(string), DateTime? creditLimitIncreaseEndDate = default(DateTime?), string reasonCode = default(string), DateTime? creditLimitIncreaseStartDate = default(DateTime?), double? requestedCreditLimitAmount = default(double?))
        {
            // to ensure "cardId" is required (not null)
            if (cardId == null)
            {
                throw new InvalidDataException("cardId is a required property for TemporaryCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.CardId = cardId;
            }
            // to ensure "creditLimitIncreaseEndDate" is required (not null)
            if (creditLimitIncreaseEndDate == null)
            {
                throw new InvalidDataException("creditLimitIncreaseEndDate is a required property for TemporaryCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.CreditLimitIncreaseEndDate = creditLimitIncreaseEndDate;
            }
            // to ensure "reasonCode" is required (not null)
            if (reasonCode == null)
            {
                throw new InvalidDataException("reasonCode is a required property for TemporaryCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.ReasonCode = reasonCode;
            }
            // to ensure "creditLimitIncreaseStartDate" is required (not null)
            if (creditLimitIncreaseStartDate == null)
            {
                throw new InvalidDataException("creditLimitIncreaseStartDate is a required property for TemporaryCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.CreditLimitIncreaseStartDate = creditLimitIncreaseStartDate;
            }
            // to ensure "requestedCreditLimitAmount" is required (not null)
            if (requestedCreditLimitAmount == null)
            {
                throw new InvalidDataException("requestedCreditLimitAmount is a required property for TemporaryCreditLimitIncrease and cannot be null");
            }
            else
            {
                this.RequestedCreditLimitAmount = requestedCreditLimitAmount;
            }
        }
        
        /// <summary>
        /// The card identifier in encrypted format.
        /// </summary>
        /// <value>The card identifier in encrypted format.</value>
        [DataMember(Name="cardId", EmitDefaultValue=false)]
        public string CardId { get; set; }

        /// <summary>
        /// Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD.
        /// </summary>
        /// <value>Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD.</value>
        [DataMember(Name="creditLimitIncreaseEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CreditLimitIncreaseEndDate { get; set; }

        /// <summary>
        /// Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Credit limit increase start date in ISO 8601 date format YYYY-MM-DD.
        /// </summary>
        /// <value>Credit limit increase start date in ISO 8601 date format YYYY-MM-DD.</value>
        [DataMember(Name="creditLimitIncreaseStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CreditLimitIncreaseStartDate { get; set; }

        /// <summary>
        /// Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer
        /// </summary>
        /// <value>Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer</value>
        [DataMember(Name="requestedCreditLimitAmount", EmitDefaultValue=false)]
        public double? RequestedCreditLimitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemporaryCreditLimitIncrease {\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  CreditLimitIncreaseEndDate: ").Append(CreditLimitIncreaseEndDate).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  CreditLimitIncreaseStartDate: ").Append(CreditLimitIncreaseStartDate).Append("\n");
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
            return this.Equals(input as TemporaryCreditLimitIncrease);
        }

        /// <summary>
        /// Returns true if TemporaryCreditLimitIncrease instances are equal
        /// </summary>
        /// <param name="input">Instance of TemporaryCreditLimitIncrease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemporaryCreditLimitIncrease input)
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
                    this.CreditLimitIncreaseEndDate == input.CreditLimitIncreaseEndDate ||
                    (this.CreditLimitIncreaseEndDate != null &&
                    this.CreditLimitIncreaseEndDate.Equals(input.CreditLimitIncreaseEndDate))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.CreditLimitIncreaseStartDate == input.CreditLimitIncreaseStartDate ||
                    (this.CreditLimitIncreaseStartDate != null &&
                    this.CreditLimitIncreaseStartDate.Equals(input.CreditLimitIncreaseStartDate))
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
                if (this.CreditLimitIncreaseEndDate != null)
                    hashCode = hashCode * 59 + this.CreditLimitIncreaseEndDate.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.CreditLimitIncreaseStartDate != null)
                    hashCode = hashCode * 59 + this.CreditLimitIncreaseStartDate.GetHashCode();
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
