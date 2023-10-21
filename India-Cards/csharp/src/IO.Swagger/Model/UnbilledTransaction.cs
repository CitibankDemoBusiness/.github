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
    /// UnbilledTransaction
    /// </summary>
    [DataContract]
        public partial class UnbilledTransaction :  IEquatable<UnbilledTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnbilledTransaction" /> class.
        /// </summary>
        /// <param name="transactionDate">Transaction date in YYYY-MM-DD format value conforming to ISO 8601. (required).</param>
        /// <param name="transactionDescription">Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. (required).</param>
        /// <param name="transactionReferenceId">Reference Id to uniquely identify the transaction.This is applicable for successful transactions. .</param>
        /// <param name="transactionAmount">Transaction amount in local currency. (required).</param>
        /// <param name="currencyCode">The currency code in ISO 4217 format.</param>
        public UnbilledTransaction(DateTime? transactionDate = default(DateTime?), string transactionDescription = default(string), string transactionReferenceId = default(string), double? transactionAmount = default(double?), string currencyCode = default(string))
        {
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null)
            {
                throw new InvalidDataException("transactionDate is a required property for UnbilledTransaction and cannot be null");
            }
            else
            {
                this.TransactionDate = transactionDate;
            }
            // to ensure "transactionDescription" is required (not null)
            if (transactionDescription == null)
            {
                throw new InvalidDataException("transactionDescription is a required property for UnbilledTransaction and cannot be null");
            }
            else
            {
                this.TransactionDescription = transactionDescription;
            }
            // to ensure "transactionAmount" is required (not null)
            if (transactionAmount == null)
            {
                throw new InvalidDataException("transactionAmount is a required property for UnbilledTransaction and cannot be null");
            }
            else
            {
                this.TransactionAmount = transactionAmount;
            }
            this.TransactionReferenceId = transactionReferenceId;
            this.CurrencyCode = currencyCode;
        }
        
        /// <summary>
        /// Transaction date in YYYY-MM-DD format value conforming to ISO 8601.
        /// </summary>
        /// <value>Transaction date in YYYY-MM-DD format value conforming to ISO 8601.</value>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.
        /// </summary>
        /// <value>Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.</value>
        [DataMember(Name="transactionDescription", EmitDefaultValue=false)]
        public string TransactionDescription { get; set; }

        /// <summary>
        /// Reference Id to uniquely identify the transaction.This is applicable for successful transactions. 
        /// </summary>
        /// <value>Reference Id to uniquely identify the transaction.This is applicable for successful transactions. </value>
        [DataMember(Name="transactionReferenceId", EmitDefaultValue=false)]
        public string TransactionReferenceId { get; set; }

        /// <summary>
        /// Transaction amount in local currency.
        /// </summary>
        /// <value>Transaction amount in local currency.</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// The currency code in ISO 4217 format
        /// </summary>
        /// <value>The currency code in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnbilledTransaction {\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  TransactionDescription: ").Append(TransactionDescription).Append("\n");
            sb.Append("  TransactionReferenceId: ").Append(TransactionReferenceId).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(input as UnbilledTransaction);
        }

        /// <summary>
        /// Returns true if UnbilledTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of UnbilledTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnbilledTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.TransactionDescription == input.TransactionDescription ||
                    (this.TransactionDescription != null &&
                    this.TransactionDescription.Equals(input.TransactionDescription))
                ) && 
                (
                    this.TransactionReferenceId == input.TransactionReferenceId ||
                    (this.TransactionReferenceId != null &&
                    this.TransactionReferenceId.Equals(input.TransactionReferenceId))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
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
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.TransactionDescription != null)
                    hashCode = hashCode * 59 + this.TransactionDescription.GetHashCode();
                if (this.TransactionReferenceId != null)
                    hashCode = hashCode * 59 + this.TransactionReferenceId.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
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
