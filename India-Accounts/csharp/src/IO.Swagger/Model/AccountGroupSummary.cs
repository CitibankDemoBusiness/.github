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
    /// AccountGroupSummary
    /// </summary>
    [DataContract]
        public partial class AccountGroupSummary :  IEquatable<AccountGroupSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupSummary" /> class.
        /// </summary>
        /// <param name="accountGroup">Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. (required).</param>
        /// <param name="accounts">Summarized list of each account type under a specific product group, held by customer (required).</param>
        /// <param name="insurancePolicies">Summarized list of every insurance policy held by the customer..</param>
        /// <param name="totalCurrentBalance">totalCurrentBalance.</param>
        /// <param name="totalAvailableBalance">totalAvailableBalance.</param>
        /// <param name="totalOutstandingBalance">totalOutstandingBalance.</param>
        public AccountGroupSummary(string accountGroup = default(string), List<AccountSummary> accounts = default(List<AccountSummary>), List<InsurancePolicySummary> insurancePolicies = default(List<InsurancePolicySummary>), GroupBalance totalCurrentBalance = default(GroupBalance), GroupBalance totalAvailableBalance = default(GroupBalance), GroupBalance totalOutstandingBalance = default(GroupBalance))
        {
            // to ensure "accountGroup" is required (not null)
            if (accountGroup == null)
            {
                throw new InvalidDataException("accountGroup is a required property for AccountGroupSummary and cannot be null");
            }
            else
            {
                this.AccountGroup = accountGroup;
            }
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new InvalidDataException("accounts is a required property for AccountGroupSummary and cannot be null");
            }
            else
            {
                this.Accounts = accounts;
            }
            this.InsurancePolicies = insurancePolicies;
            this.TotalCurrentBalance = totalCurrentBalance;
            this.TotalAvailableBalance = totalAvailableBalance;
            this.TotalOutstandingBalance = totalOutstandingBalance;
        }
        
        /// <summary>
        /// Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="accountGroup", EmitDefaultValue=false)]
        public string AccountGroup { get; set; }

        /// <summary>
        /// Summarized list of each account type under a specific product group, held by customer
        /// </summary>
        /// <value>Summarized list of each account type under a specific product group, held by customer</value>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<AccountSummary> Accounts { get; set; }

        /// <summary>
        /// Summarized list of every insurance policy held by the customer.
        /// </summary>
        /// <value>Summarized list of every insurance policy held by the customer.</value>
        [DataMember(Name="insurancePolicies", EmitDefaultValue=false)]
        public List<InsurancePolicySummary> InsurancePolicies { get; set; }

        /// <summary>
        /// Gets or Sets TotalCurrentBalance
        /// </summary>
        [DataMember(Name="totalCurrentBalance", EmitDefaultValue=false)]
        public GroupBalance TotalCurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets TotalAvailableBalance
        /// </summary>
        [DataMember(Name="totalAvailableBalance", EmitDefaultValue=false)]
        public GroupBalance TotalAvailableBalance { get; set; }

        /// <summary>
        /// Gets or Sets TotalOutstandingBalance
        /// </summary>
        [DataMember(Name="totalOutstandingBalance", EmitDefaultValue=false)]
        public GroupBalance TotalOutstandingBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountGroupSummary {\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  InsurancePolicies: ").Append(InsurancePolicies).Append("\n");
            sb.Append("  TotalCurrentBalance: ").Append(TotalCurrentBalance).Append("\n");
            sb.Append("  TotalAvailableBalance: ").Append(TotalAvailableBalance).Append("\n");
            sb.Append("  TotalOutstandingBalance: ").Append(TotalOutstandingBalance).Append("\n");
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
            return this.Equals(input as AccountGroupSummary);
        }

        /// <summary>
        /// Returns true if AccountGroupSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountGroupSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountGroupSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountGroup == input.AccountGroup ||
                    (this.AccountGroup != null &&
                    this.AccountGroup.Equals(input.AccountGroup))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.InsurancePolicies == input.InsurancePolicies ||
                    this.InsurancePolicies != null &&
                    input.InsurancePolicies != null &&
                    this.InsurancePolicies.SequenceEqual(input.InsurancePolicies)
                ) && 
                (
                    this.TotalCurrentBalance == input.TotalCurrentBalance ||
                    (this.TotalCurrentBalance != null &&
                    this.TotalCurrentBalance.Equals(input.TotalCurrentBalance))
                ) && 
                (
                    this.TotalAvailableBalance == input.TotalAvailableBalance ||
                    (this.TotalAvailableBalance != null &&
                    this.TotalAvailableBalance.Equals(input.TotalAvailableBalance))
                ) && 
                (
                    this.TotalOutstandingBalance == input.TotalOutstandingBalance ||
                    (this.TotalOutstandingBalance != null &&
                    this.TotalOutstandingBalance.Equals(input.TotalOutstandingBalance))
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
                if (this.AccountGroup != null)
                    hashCode = hashCode * 59 + this.AccountGroup.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.InsurancePolicies != null)
                    hashCode = hashCode * 59 + this.InsurancePolicies.GetHashCode();
                if (this.TotalCurrentBalance != null)
                    hashCode = hashCode * 59 + this.TotalCurrentBalance.GetHashCode();
                if (this.TotalAvailableBalance != null)
                    hashCode = hashCode * 59 + this.TotalAvailableBalance.GetHashCode();
                if (this.TotalOutstandingBalance != null)
                    hashCode = hashCode * 59 + this.TotalOutstandingBalance.GetHashCode();
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