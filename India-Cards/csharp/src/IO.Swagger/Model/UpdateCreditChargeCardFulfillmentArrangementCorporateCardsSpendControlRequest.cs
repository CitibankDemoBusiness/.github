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
    /// UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest
    /// </summary>
    [DataContract]
        public partial class UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest :  IEquatable<UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest" /> class.
        /// </summary>
        /// <param name="tokenizedCardNumber">Tokenized card number (required).</param>
        /// <param name="corporateOfficerDetails">corporateOfficerDetails.</param>
        public UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest(string tokenizedCardNumber = default(string), CorporateOfficerDetails corporateOfficerDetails = default(CorporateOfficerDetails))
        {
            // to ensure "tokenizedCardNumber" is required (not null)
            if (tokenizedCardNumber == null)
            {
                throw new InvalidDataException("tokenizedCardNumber is a required property for UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest and cannot be null");
            }
            else
            {
                this.TokenizedCardNumber = tokenizedCardNumber;
            }
            this.CorporateOfficerDetails = corporateOfficerDetails;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest {\n");
            sb.Append("  TokenizedCardNumber: ").Append(TokenizedCardNumber).Append("\n");
            sb.Append("  CorporateOfficerDetails: ").Append(CorporateOfficerDetails).Append("\n");
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
            return this.Equals(input as UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest);
        }

        /// <summary>
        /// Returns true if UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest input)
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
