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
    /// UpdateCreditChargeCardCorporateCardsCashLimitRequest
    /// </summary>
    [DataContract]
        public partial class UpdateCreditChargeCardCorporateCardsCashLimitRequest :  IEquatable<UpdateCreditChargeCardCorporateCardsCashLimitRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCreditChargeCardCorporateCardsCashLimitRequest" /> class.
        /// </summary>
        /// <param name="tokenizedCardNumber">Tokenized card number (required).</param>
        /// <param name="corporateOfficerDetails">corporateOfficerDetails.</param>
        /// <param name="maximumDailyCashLimitAmount">This is the max daily Cash limit Amount allowed for the cardholder.</param>
        /// <param name="maximumWeeklyCashLimitAmount">This is the max weekly Cash limit Amount allowed for the cardholder.</param>
        /// <param name="maximumMonthlyCashLimitAmount">This is the max monthly Cash limit Amount allowed for the cardholder.</param>
        /// <param name="maximumIndividualTxnLimitAmount">This is the max Cash Amount allowed for the cardholder per transaction.</param>
        public UpdateCreditChargeCardCorporateCardsCashLimitRequest(string tokenizedCardNumber = default(string), CorporateOfficerDetails corporateOfficerDetails = default(CorporateOfficerDetails), long? maximumDailyCashLimitAmount = default(long?), long? maximumWeeklyCashLimitAmount = default(long?), long? maximumMonthlyCashLimitAmount = default(long?), long? maximumIndividualTxnLimitAmount = default(long?))
        {
            // to ensure "tokenizedCardNumber" is required (not null)
            if (tokenizedCardNumber == null)
            {
                throw new InvalidDataException("tokenizedCardNumber is a required property for UpdateCreditChargeCardCorporateCardsCashLimitRequest and cannot be null");
            }
            else
            {
                this.TokenizedCardNumber = tokenizedCardNumber;
            }
            this.CorporateOfficerDetails = corporateOfficerDetails;
            this.MaximumDailyCashLimitAmount = maximumDailyCashLimitAmount;
            this.MaximumWeeklyCashLimitAmount = maximumWeeklyCashLimitAmount;
            this.MaximumMonthlyCashLimitAmount = maximumMonthlyCashLimitAmount;
            this.MaximumIndividualTxnLimitAmount = maximumIndividualTxnLimitAmount;
        }
        
        /// <summary>
        /// Tokenized card number
        /// </summary>
        /// <value>Tokenized card number</value>
        [DataMember(Name="tokenizedCardNumber", EmitDefaultValue=false)]
        public string TokenizedCardNumber { get; set; }

        /// <summary>
        /// Gets or Sets CorporateOfficerDetails
        /// </summary>
        [DataMember(Name="corporateOfficerDetails", EmitDefaultValue=false)]
        public CorporateOfficerDetails CorporateOfficerDetails { get; set; }

        /// <summary>
        /// This is the max daily Cash limit Amount allowed for the cardholder
        /// </summary>
        /// <value>This is the max daily Cash limit Amount allowed for the cardholder</value>
        [DataMember(Name="maximumDailyCashLimitAmount", EmitDefaultValue=false)]
        public long? MaximumDailyCashLimitAmount { get; set; }

        /// <summary>
        /// This is the max weekly Cash limit Amount allowed for the cardholder
        /// </summary>
        /// <value>This is the max weekly Cash limit Amount allowed for the cardholder</value>
        [DataMember(Name="maximumWeeklyCashLimitAmount", EmitDefaultValue=false)]
        public long? MaximumWeeklyCashLimitAmount { get; set; }

        /// <summary>
        /// This is the max monthly Cash limit Amount allowed for the cardholder
        /// </summary>
        /// <value>This is the max monthly Cash limit Amount allowed for the cardholder</value>
        [DataMember(Name="maximumMonthlyCashLimitAmount", EmitDefaultValue=false)]
        public long? MaximumMonthlyCashLimitAmount { get; set; }

        /// <summary>
        /// This is the max Cash Amount allowed for the cardholder per transaction
        /// </summary>
        /// <value>This is the max Cash Amount allowed for the cardholder per transaction</value>
        [DataMember(Name="maximumIndividualTxnLimitAmount", EmitDefaultValue=false)]
        public long? MaximumIndividualTxnLimitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCreditChargeCardCorporateCardsCashLimitRequest {\n");
            sb.Append("  TokenizedCardNumber: ").Append(TokenizedCardNumber).Append("\n");
            sb.Append("  CorporateOfficerDetails: ").Append(CorporateOfficerDetails).Append("\n");
            sb.Append("  MaximumDailyCashLimitAmount: ").Append(MaximumDailyCashLimitAmount).Append("\n");
            sb.Append("  MaximumWeeklyCashLimitAmount: ").Append(MaximumWeeklyCashLimitAmount).Append("\n");
            sb.Append("  MaximumMonthlyCashLimitAmount: ").Append(MaximumMonthlyCashLimitAmount).Append("\n");
            sb.Append("  MaximumIndividualTxnLimitAmount: ").Append(MaximumIndividualTxnLimitAmount).Append("\n");
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
            return this.Equals(input as UpdateCreditChargeCardCorporateCardsCashLimitRequest);
        }

        /// <summary>
        /// Returns true if UpdateCreditChargeCardCorporateCardsCashLimitRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCreditChargeCardCorporateCardsCashLimitRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCreditChargeCardCorporateCardsCashLimitRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenizedCardNumber == input.TokenizedCardNumber ||
                    (this.TokenizedCardNumber != null &&
                    this.TokenizedCardNumber.Equals(input.TokenizedCardNumber))
                ) && 
                (
                    this.CorporateOfficerDetails == input.CorporateOfficerDetails ||
                    (this.CorporateOfficerDetails != null &&
                    this.CorporateOfficerDetails.Equals(input.CorporateOfficerDetails))
                ) && 
                (
                    this.MaximumDailyCashLimitAmount == input.MaximumDailyCashLimitAmount ||
                    (this.MaximumDailyCashLimitAmount != null &&
                    this.MaximumDailyCashLimitAmount.Equals(input.MaximumDailyCashLimitAmount))
                ) && 
                (
                    this.MaximumWeeklyCashLimitAmount == input.MaximumWeeklyCashLimitAmount ||
                    (this.MaximumWeeklyCashLimitAmount != null &&
                    this.MaximumWeeklyCashLimitAmount.Equals(input.MaximumWeeklyCashLimitAmount))
                ) && 
                (
                    this.MaximumMonthlyCashLimitAmount == input.MaximumMonthlyCashLimitAmount ||
                    (this.MaximumMonthlyCashLimitAmount != null &&
                    this.MaximumMonthlyCashLimitAmount.Equals(input.MaximumMonthlyCashLimitAmount))
                ) && 
                (
                    this.MaximumIndividualTxnLimitAmount == input.MaximumIndividualTxnLimitAmount ||
                    (this.MaximumIndividualTxnLimitAmount != null &&
                    this.MaximumIndividualTxnLimitAmount.Equals(input.MaximumIndividualTxnLimitAmount))
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
                if (this.TokenizedCardNumber != null)
                    hashCode = hashCode * 59 + this.TokenizedCardNumber.GetHashCode();
                if (this.CorporateOfficerDetails != null)
                    hashCode = hashCode * 59 + this.CorporateOfficerDetails.GetHashCode();
                if (this.MaximumDailyCashLimitAmount != null)
                    hashCode = hashCode * 59 + this.MaximumDailyCashLimitAmount.GetHashCode();
                if (this.MaximumWeeklyCashLimitAmount != null)
                    hashCode = hashCode * 59 + this.MaximumWeeklyCashLimitAmount.GetHashCode();
                if (this.MaximumMonthlyCashLimitAmount != null)
                    hashCode = hashCode * 59 + this.MaximumMonthlyCashLimitAmount.GetHashCode();
                if (this.MaximumIndividualTxnLimitAmount != null)
                    hashCode = hashCode * 59 + this.MaximumIndividualTxnLimitAmount.GetHashCode();
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
