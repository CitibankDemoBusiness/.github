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
    /// CheckingAccount
    /// </summary>
    [DataContract]
        public partial class CheckingAccount :  IEquatable<CheckingAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckingAccount" /> class.
        /// </summary>
        /// <param name="productName">The name of the product.</param>
        /// <param name="productCode">A unique code that identifies the product.</param>
        /// <param name="displayAccountNumber">A masked account number that can be displayed to the customer (required).</param>
        /// <param name="currentBalance">The current balance including any pending or in progress deposits and withdrawals.</param>
        /// <param name="availableBalance">The amount available  to withdraw or transfer immediately.</param>
        /// <param name="overdraftLimit">This allows a customer to overdraw their account up to a specific amount.</param>
        /// <param name="availableOverdraftLimit">The amount available under over draft Limit amount.</param>
        /// <param name="currencyCode">The currency code of the account in ISO 4217 format.</param>
        /// <param name="lastStatementDate">The date of the last statement in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="holdAmount">The amount of funds that were previously available but are now blocked. It represents funds authorized for withdrawal but not yet withdrawn. The hold amount is included in the ledger/book balance but not in the available balance. It is included in interest.</param>
        /// <param name="floatAmount">The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a checking account. These funds are unavailable for withdrawal until they are paid by the drawee bank..</param>
        /// <param name="totalInterestAmount">Total interest amount on checking account..</param>
        /// <param name="openingDate">Checking account opening date in ISO 8601 date format YYYY-MM-DD.</param>
        public CheckingAccount(string productName = default(string), string productCode = default(string), string displayAccountNumber = default(string), double? currentBalance = default(double?), double? availableBalance = default(double?), double? overdraftLimit = default(double?), double? availableOverdraftLimit = default(double?), string currencyCode = default(string), DateTime? lastStatementDate = default(DateTime?), double? holdAmount = default(double?), double? floatAmount = default(double?), double? totalInterestAmount = default(double?), DateTime? openingDate = default(DateTime?))
        {
            // to ensure "displayAccountNumber" is required (not null)
            if (displayAccountNumber == null)
            {
                throw new InvalidDataException("displayAccountNumber is a required property for CheckingAccount and cannot be null");
            }
            else
            {
                this.DisplayAccountNumber = displayAccountNumber;
            }
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.CurrentBalance = currentBalance;
            this.AvailableBalance = availableBalance;
            this.OverdraftLimit = overdraftLimit;
            this.AvailableOverdraftLimit = availableOverdraftLimit;
            this.CurrencyCode = currencyCode;
            this.LastStatementDate = lastStatementDate;
            this.HoldAmount = holdAmount;
            this.FloatAmount = floatAmount;
            this.TotalInterestAmount = totalInterestAmount;
            this.OpeningDate = openingDate;
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
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displayAccountNumber", EmitDefaultValue=false)]
        public string DisplayAccountNumber { get; set; }

        /// <summary>
        /// The current balance including any pending or in progress deposits and withdrawals
        /// </summary>
        /// <value>The current balance including any pending or in progress deposits and withdrawals</value>
        [DataMember(Name="currentBalance", EmitDefaultValue=false)]
        public double? CurrentBalance { get; set; }

        /// <summary>
        /// The amount available  to withdraw or transfer immediately
        /// </summary>
        /// <value>The amount available  to withdraw or transfer immediately</value>
        [DataMember(Name="availableBalance", EmitDefaultValue=false)]
        public double? AvailableBalance { get; set; }

        /// <summary>
        /// This allows a customer to overdraw their account up to a specific amount
        /// </summary>
        /// <value>This allows a customer to overdraw their account up to a specific amount</value>
        [DataMember(Name="overdraftLimit", EmitDefaultValue=false)]
        public double? OverdraftLimit { get; set; }

        /// <summary>
        /// The amount available under over draft Limit amount
        /// </summary>
        /// <value>The amount available under over draft Limit amount</value>
        [DataMember(Name="availableOverdraftLimit", EmitDefaultValue=false)]
        public double? AvailableOverdraftLimit { get; set; }

        /// <summary>
        /// The currency code of the account in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the account in ISO 4217 format</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The date of the last statement in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>The date of the last statement in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="lastStatementDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastStatementDate { get; set; }

        /// <summary>
        /// The amount of funds that were previously available but are now blocked. It represents funds authorized for withdrawal but not yet withdrawn. The hold amount is included in the ledger/book balance but not in the available balance. It is included in interest
        /// </summary>
        /// <value>The amount of funds that were previously available but are now blocked. It represents funds authorized for withdrawal but not yet withdrawn. The hold amount is included in the ledger/book balance but not in the available balance. It is included in interest</value>
        [DataMember(Name="holdAmount", EmitDefaultValue=false)]
        public double? HoldAmount { get; set; }

        /// <summary>
        /// The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a checking account. These funds are unavailable for withdrawal until they are paid by the drawee bank.
        /// </summary>
        /// <value>The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a checking account. These funds are unavailable for withdrawal until they are paid by the drawee bank.</value>
        [DataMember(Name="floatAmount", EmitDefaultValue=false)]
        public double? FloatAmount { get; set; }

        /// <summary>
        /// Total interest amount on checking account.
        /// </summary>
        /// <value>Total interest amount on checking account.</value>
        [DataMember(Name="totalInterestAmount", EmitDefaultValue=false)]
        public double? TotalInterestAmount { get; set; }

        /// <summary>
        /// Checking account opening date in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Checking account opening date in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="openingDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? OpeningDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckingAccount {\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  DisplayAccountNumber: ").Append(DisplayAccountNumber).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  OverdraftLimit: ").Append(OverdraftLimit).Append("\n");
            sb.Append("  AvailableOverdraftLimit: ").Append(AvailableOverdraftLimit).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LastStatementDate: ").Append(LastStatementDate).Append("\n");
            sb.Append("  HoldAmount: ").Append(HoldAmount).Append("\n");
            sb.Append("  FloatAmount: ").Append(FloatAmount).Append("\n");
            sb.Append("  TotalInterestAmount: ").Append(TotalInterestAmount).Append("\n");
            sb.Append("  OpeningDate: ").Append(OpeningDate).Append("\n");
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
            return this.Equals(input as CheckingAccount);
        }

        /// <summary>
        /// Returns true if CheckingAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckingAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckingAccount input)
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
                    this.DisplayAccountNumber == input.DisplayAccountNumber ||
                    (this.DisplayAccountNumber != null &&
                    this.DisplayAccountNumber.Equals(input.DisplayAccountNumber))
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
                ) && 
                (
                    this.OverdraftLimit == input.OverdraftLimit ||
                    (this.OverdraftLimit != null &&
                    this.OverdraftLimit.Equals(input.OverdraftLimit))
                ) && 
                (
                    this.AvailableOverdraftLimit == input.AvailableOverdraftLimit ||
                    (this.AvailableOverdraftLimit != null &&
                    this.AvailableOverdraftLimit.Equals(input.AvailableOverdraftLimit))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.LastStatementDate == input.LastStatementDate ||
                    (this.LastStatementDate != null &&
                    this.LastStatementDate.Equals(input.LastStatementDate))
                ) && 
                (
                    this.HoldAmount == input.HoldAmount ||
                    (this.HoldAmount != null &&
                    this.HoldAmount.Equals(input.HoldAmount))
                ) && 
                (
                    this.FloatAmount == input.FloatAmount ||
                    (this.FloatAmount != null &&
                    this.FloatAmount.Equals(input.FloatAmount))
                ) && 
                (
                    this.TotalInterestAmount == input.TotalInterestAmount ||
                    (this.TotalInterestAmount != null &&
                    this.TotalInterestAmount.Equals(input.TotalInterestAmount))
                ) && 
                (
                    this.OpeningDate == input.OpeningDate ||
                    (this.OpeningDate != null &&
                    this.OpeningDate.Equals(input.OpeningDate))
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
                if (this.DisplayAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplayAccountNumber.GetHashCode();
                if (this.CurrentBalance != null)
                    hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
                if (this.AvailableBalance != null)
                    hashCode = hashCode * 59 + this.AvailableBalance.GetHashCode();
                if (this.OverdraftLimit != null)
                    hashCode = hashCode * 59 + this.OverdraftLimit.GetHashCode();
                if (this.AvailableOverdraftLimit != null)
                    hashCode = hashCode * 59 + this.AvailableOverdraftLimit.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.LastStatementDate != null)
                    hashCode = hashCode * 59 + this.LastStatementDate.GetHashCode();
                if (this.HoldAmount != null)
                    hashCode = hashCode * 59 + this.HoldAmount.GetHashCode();
                if (this.FloatAmount != null)
                    hashCode = hashCode * 59 + this.FloatAmount.GetHashCode();
                if (this.TotalInterestAmount != null)
                    hashCode = hashCode * 59 + this.TotalInterestAmount.GetHashCode();
                if (this.OpeningDate != null)
                    hashCode = hashCode * 59 + this.OpeningDate.GetHashCode();
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
