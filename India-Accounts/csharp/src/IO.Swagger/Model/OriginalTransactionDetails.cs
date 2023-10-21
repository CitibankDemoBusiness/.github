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
    /// OriginalTransactionDetails
    /// </summary>
    [DataContract]
        public partial class OriginalTransactionDetails :  IEquatable<OriginalTransactionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginalTransactionDetails" /> class.
        /// </summary>
        /// <param name="paymentType">The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description..</param>
        /// <param name="transactionDate">Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,.</param>
        /// <param name="transactionAmount">Transaction amount in account currency..</param>
        /// <param name="transactionCurrencyCode">The currency code for the foreign transaction amount in ISO 4217 format..</param>
        /// <param name="transactionStatus">Transaction Status of the original transaction.</param>
        /// <param name="transactionReferenceNumber">Transaction reference number of the original transaction.</param>
        /// <param name="transactionRemarks">Transaction Remarks of the original transaction.</param>
        /// <param name="endToEndIdentification">End to End Identification reference of the original transaction.</param>
        public OriginalTransactionDetails(string paymentType = default(string), DateTime? transactionDate = default(DateTime?), double? transactionAmount = default(double?), string transactionCurrencyCode = default(string), string transactionStatus = default(string), string transactionReferenceNumber = default(string), string transactionRemarks = default(string), string endToEndIdentification = default(string))
        {
            this.PaymentType = paymentType;
            this.TransactionDate = transactionDate;
            this.TransactionAmount = transactionAmount;
            this.TransactionCurrencyCode = transactionCurrencyCode;
            this.TransactionStatus = transactionStatus;
            this.TransactionReferenceNumber = transactionReferenceNumber;
            this.TransactionRemarks = transactionRemarks;
            this.EndToEndIdentification = endToEndIdentification;
        }
        
        /// <summary>
        /// The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,
        /// </summary>
        /// <value>Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,</value>
        [DataMember(Name="transactionDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Transaction amount in account currency.
        /// </summary>
        /// <value>Transaction amount in account currency.</value>
        [DataMember(Name="transactionAmount", EmitDefaultValue=false)]
        public double? TransactionAmount { get; set; }

        /// <summary>
        /// The currency code for the foreign transaction amount in ISO 4217 format.
        /// </summary>
        /// <value>The currency code for the foreign transaction amount in ISO 4217 format.</value>
        [DataMember(Name="transactionCurrencyCode", EmitDefaultValue=false)]
        public string TransactionCurrencyCode { get; set; }

        /// <summary>
        /// Transaction Status of the original transaction
        /// </summary>
        /// <value>Transaction Status of the original transaction</value>
        [DataMember(Name="transactionStatus", EmitDefaultValue=false)]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// Transaction reference number of the original transaction
        /// </summary>
        /// <value>Transaction reference number of the original transaction</value>
        [DataMember(Name="transactionReferenceNumber", EmitDefaultValue=false)]
        public string TransactionReferenceNumber { get; set; }

        /// <summary>
        /// Transaction Remarks of the original transaction
        /// </summary>
        /// <value>Transaction Remarks of the original transaction</value>
        [DataMember(Name="transactionRemarks", EmitDefaultValue=false)]
        public string TransactionRemarks { get; set; }

        /// <summary>
        /// End to End Identification reference of the original transaction
        /// </summary>
        /// <value>End to End Identification reference of the original transaction</value>
        [DataMember(Name="endToEndIdentification", EmitDefaultValue=false)]
        public string EndToEndIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginalTransactionDetails {\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  TransactionCurrencyCode: ").Append(TransactionCurrencyCode).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  TransactionReferenceNumber: ").Append(TransactionReferenceNumber).Append("\n");
            sb.Append("  TransactionRemarks: ").Append(TransactionRemarks).Append("\n");
            sb.Append("  EndToEndIdentification: ").Append(EndToEndIdentification).Append("\n");
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
            return this.Equals(input as OriginalTransactionDetails);
        }

        /// <summary>
        /// Returns true if OriginalTransactionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OriginalTransactionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OriginalTransactionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.TransactionCurrencyCode == input.TransactionCurrencyCode ||
                    (this.TransactionCurrencyCode != null &&
                    this.TransactionCurrencyCode.Equals(input.TransactionCurrencyCode))
                ) && 
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) && 
                (
                    this.TransactionReferenceNumber == input.TransactionReferenceNumber ||
                    (this.TransactionReferenceNumber != null &&
                    this.TransactionReferenceNumber.Equals(input.TransactionReferenceNumber))
                ) && 
                (
                    this.TransactionRemarks == input.TransactionRemarks ||
                    (this.TransactionRemarks != null &&
                    this.TransactionRemarks.Equals(input.TransactionRemarks))
                ) && 
                (
                    this.EndToEndIdentification == input.EndToEndIdentification ||
                    (this.EndToEndIdentification != null &&
                    this.EndToEndIdentification.Equals(input.EndToEndIdentification))
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
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.TransactionCurrencyCode != null)
                    hashCode = hashCode * 59 + this.TransactionCurrencyCode.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.TransactionReferenceNumber != null)
                    hashCode = hashCode * 59 + this.TransactionReferenceNumber.GetHashCode();
                if (this.TransactionRemarks != null)
                    hashCode = hashCode * 59 + this.TransactionRemarks.GetHashCode();
                if (this.EndToEndIdentification != null)
                    hashCode = hashCode * 59 + this.EndToEndIdentification.GetHashCode();
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
