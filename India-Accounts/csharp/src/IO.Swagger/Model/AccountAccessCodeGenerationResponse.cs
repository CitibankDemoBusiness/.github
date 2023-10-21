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
    /// AccountAccessCodeGenerationResponse
    /// </summary>
    [DataContract]
        public partial class AccountAccessCodeGenerationResponse :  IEquatable<AccountAccessCodeGenerationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAccessCodeGenerationResponse" /> class.
        /// </summary>
        /// <param name="accountAccessCode">Account access Code which will be used to see the clear account number (required).</param>
        /// <param name="accessUrl">URL for viewing clear account number (required).</param>
        public AccountAccessCodeGenerationResponse(string accountAccessCode = default(string), string accessUrl = default(string))
        {
            // to ensure "accountAccessCode" is required (not null)
            if (accountAccessCode == null)
            {
                throw new InvalidDataException("accountAccessCode is a required property for AccountAccessCodeGenerationResponse and cannot be null");
            }
            else
            {
                this.AccountAccessCode = accountAccessCode;
            }
            // to ensure "accessUrl" is required (not null)
            if (accessUrl == null)
            {
                throw new InvalidDataException("accessUrl is a required property for AccountAccessCodeGenerationResponse and cannot be null");
            }
            else
            {
                this.AccessUrl = accessUrl;
            }
        }
        
        /// <summary>
        /// Account access Code which will be used to see the clear account number
        /// </summary>
        /// <value>Account access Code which will be used to see the clear account number</value>
        [DataMember(Name="accountAccessCode", EmitDefaultValue=false)]
        public string AccountAccessCode { get; set; }

        /// <summary>
        /// URL for viewing clear account number
        /// </summary>
        /// <value>URL for viewing clear account number</value>
        [DataMember(Name="accessUrl", EmitDefaultValue=false)]
        public string AccessUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAccessCodeGenerationResponse {\n");
            sb.Append("  AccountAccessCode: ").Append(AccountAccessCode).Append("\n");
            sb.Append("  AccessUrl: ").Append(AccessUrl).Append("\n");
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
            return this.Equals(input as AccountAccessCodeGenerationResponse);
        }

        /// <summary>
        /// Returns true if AccountAccessCodeGenerationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountAccessCodeGenerationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAccessCodeGenerationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountAccessCode == input.AccountAccessCode ||
                    (this.AccountAccessCode != null &&
                    this.AccountAccessCode.Equals(input.AccountAccessCode))
                ) && 
                (
                    this.AccessUrl == input.AccessUrl ||
                    (this.AccessUrl != null &&
                    this.AccessUrl.Equals(input.AccessUrl))
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
                if (this.AccountAccessCode != null)
                    hashCode = hashCode * 59 + this.AccountAccessCode.GetHashCode();
                if (this.AccessUrl != null)
                    hashCode = hashCode * 59 + this.AccessUrl.GetHashCode();
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