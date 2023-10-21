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
    /// LoanAccountSummary
    /// </summary>
    [DataContract]
        public partial class LoanAccountSummary :  IEquatable<LoanAccountSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanAccountSummary" /> class.
        /// </summary>
        /// <param name="productName">The name of the product.</param>
        /// <param name="productCode">A unique code that identifies the product.</param>
        /// <param name="accountNickname">The nickname of the account assigned by the customer.</param>
        /// <param name="displayAccountNumber">A masked account number that can be displayed to the customer.</param>
        /// <param name="accountId">The customer account identifier in encrypted format..</param>
        /// <param name="currencyCode">The currency code in ISO 4217 format.</param>
        /// <param name="accountClassification">Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="accountStatus">Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="originalPrincipalAmount">The amount borrowed.</param>
        /// <param name="outstandingBalance">The amount of money owed..</param>
        /// <param name="nextPaymentAmount">The next payment amount due.</param>
        /// <param name="nextPaymentDate">The date of the next payment in ISO 8601 date format YYYY-MM-DD.</param>
        public LoanAccountSummary(string productName = default(string), string productCode = default(string), string accountNickname = default(string), string displayAccountNumber = default(string), string accountId = default(string), string currencyCode = default(string), string accountClassification = default(string), string accountStatus = default(string), double? originalPrincipalAmount = default(double?), double? outstandingBalance = default(double?), double? nextPaymentAmount = default(double?), DateTime? nextPaymentDate = default(DateTime?))
        {
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.AccountNickname = accountNickname;
            this.DisplayAccountNumber = displayAccountNumber;
            this.AccountId = accountId;
            this.CurrencyCode = currencyCode;
            this.AccountClassification = accountClassification;
            this.AccountStatus = accountStatus;
            this.OriginalPrincipalAmount = originalPrincipalAmount;
            this.OutstandingBalance = outstandingBalance;
            this.NextPaymentAmount = nextPaymentAmount;
            this.NextPaymentDate = nextPaymentDate;
        }
        
        /// <summary>
        /// The name of the product
        /// </summary>
        /// <value>The name of the product</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// A unique code that identifies the product
        /// </summary>
        /// <value>A unique code that identifies the product</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The nickname of the account assigned by the customer
        /// </summary>
        /// <value>The nickname of the account assigned by the customer</value>
        [DataMember(Name="accountNickname", EmitDefaultValue=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displayAccountNumber", EmitDefaultValue=false)]
        public string DisplayAccountNumber { get; set; }

        /// <summary>
        /// The customer account identifier in encrypted format.
        /// </summary>
        /// <value>The customer account identifier in encrypted format.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The currency code in ISO 4217 format
        /// </summary>
        /// <value>The currency code in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="accountClassification", EmitDefaultValue=false)]
        public string AccountClassification { get; set; }

        /// <summary>
        /// Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="accountStatus", EmitDefaultValue=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// The amount borrowed
        /// </summary>
        /// <value>The amount borrowed</value>
        [DataMember(Name="originalPrincipalAmount", EmitDefaultValue=false)]
        public double? OriginalPrincipalAmount { get; set; }

        /// <summary>
        /// The amount of money owed.
        /// </summary>
        /// <value>The amount of money owed.</value>
        [DataMember(Name="outstandingBalance", EmitDefaultValue=false)]
        public double? OutstandingBalance { get; set; }

        /// <summary>
        /// The next payment amount due
        /// </summary>
        /// <value>The next payment amount due</value>
        [DataMember(Name="nextPaymentAmount", EmitDefaultValue=false)]
        public double? NextPaymentAmount { get; set; }

        /// <summary>
        /// The date of the next payment in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the next payment in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="nextPaymentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? NextPaymentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanAccountSummary {\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  AccountNickname: ").Append(AccountNickname).Append("\n");
            sb.Append("  DisplayAccountNumber: ").Append(DisplayAccountNumber).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  AccountClassification: ").Append(AccountClassification).Append("\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
            sb.Append("  OriginalPrincipalAmount: ").Append(OriginalPrincipalAmount).Append("\n");
            sb.Append("  OutstandingBalance: ").Append(OutstandingBalance).Append("\n");
            sb.Append("  NextPaymentAmount: ").Append(NextPaymentAmount).Append("\n");
            sb.Append("  NextPaymentDate: ").Append(NextPaymentDate).Append("\n");
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
            return this.Equals(input as LoanAccountSummary);
        }

        /// <summary>
        /// Returns true if LoanAccountSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanAccountSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanAccountSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.AccountNickname == input.AccountNickname ||
                    (this.AccountNickname != null &&
                    this.AccountNickname.Equals(input.AccountNickname))
                ) && 
                (
                    this.DisplayAccountNumber == input.DisplayAccountNumber ||
                    (this.DisplayAccountNumber != null &&
                    this.DisplayAccountNumber.Equals(input.DisplayAccountNumber))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.AccountClassification == input.AccountClassification ||
                    (this.AccountClassification != null &&
                    this.AccountClassification.Equals(input.AccountClassification))
                ) && 
                (
                    this.AccountStatus == input.AccountStatus ||
                    (this.AccountStatus != null &&
                    this.AccountStatus.Equals(input.AccountStatus))
                ) && 
                (
                    this.OriginalPrincipalAmount == input.OriginalPrincipalAmount ||
                    (this.OriginalPrincipalAmount != null &&
                    this.OriginalPrincipalAmount.Equals(input.OriginalPrincipalAmount))
                ) && 
                (
                    this.OutstandingBalance == input.OutstandingBalance ||
                    (this.OutstandingBalance != null &&
                    this.OutstandingBalance.Equals(input.OutstandingBalance))
                ) && 
                (
                    this.NextPaymentAmount == input.NextPaymentAmount ||
                    (this.NextPaymentAmount != null &&
                    this.NextPaymentAmount.Equals(input.NextPaymentAmount))
                ) && 
                (
                    this.NextPaymentDate == input.NextPaymentDate ||
                    (this.NextPaymentDate != null &&
                    this.NextPaymentDate.Equals(input.NextPaymentDate))
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
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.AccountNickname != null)
                    hashCode = hashCode * 59 + this.AccountNickname.GetHashCode();
                if (this.DisplayAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayAccountNumber.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.AccountClassification != null)
                    hashCode = hashCode * 59 + this.AccountClassification.GetHashCode();
                if (this.AccountStatus != null)
                    hashCode = hashCode * 59 + this.AccountStatus.GetHashCode();
                if (this.OriginalPrincipalAmount != null)
                    hashCode = hashCode * 59 + this.OriginalPrincipalAmount.GetHashCode();
                if (this.OutstandingBalance != null)
                    hashCode = hashCode * 59 + this.OutstandingBalance.GetHashCode();
                if (this.NextPaymentAmount != null)
                    hashCode = hashCode * 59 + this.NextPaymentAmount.GetHashCode();
                if (this.NextPaymentDate != null)
                    hashCode = hashCode * 59 + this.NextPaymentDate.GetHashCode();
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