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
    /// RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse :  IEquatable<RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse" /> class.
        /// </summary>
        /// <param name="pendingAuthorizationTransactions">pendingAuthorizationTransactions.</param>
        /// <param name="historyAndIntradayTransactions">historyAndIntradayTransactions.</param>
        public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse(PendingAuthorizationTransactions pendingAuthorizationTransactions = default(PendingAuthorizationTransactions), HistoryAndIntradayTransactions historyAndIntradayTransactions = default(HistoryAndIntradayTransactions))
        {
            this.PendingAuthorizationTransactions = pendingAuthorizationTransactions;
            this.HistoryAndIntradayTransactions = historyAndIntradayTransactions;
        }
        
        /// <summary>
        /// Gets or Sets PendingAuthorizationTransactions
        /// </summary>
        [DataMember(Name="pendingAuthorizationTransactions", EmitDefaultValue=false)]
        public PendingAuthorizationTransactions PendingAuthorizationTransactions { get; set; }

        /// <summary>
        /// Gets or Sets HistoryAndIntradayTransactions
        /// </summary>
        [DataMember(Name="historyAndIntradayTransactions", EmitDefaultValue=false)]
        public HistoryAndIntradayTransactions HistoryAndIntradayTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse {\n");
            sb.Append("  PendingAuthorizationTransactions: ").Append(PendingAuthorizationTransactions).Append("\n");
            sb.Append("  HistoryAndIntradayTransactions: ").Append(HistoryAndIntradayTransactions).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PendingAuthorizationTransactions == input.PendingAuthorizationTransactions ||
                    (this.PendingAuthorizationTransactions != null &&
                    this.PendingAuthorizationTransactions.Equals(input.PendingAuthorizationTransactions))
                ) && 
                (
                    this.HistoryAndIntradayTransactions == input.HistoryAndIntradayTransactions ||
                    (this.HistoryAndIntradayTransactions != null &&
                    this.HistoryAndIntradayTransactions.Equals(input.HistoryAndIntradayTransactions))
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
                if (this.PendingAuthorizationTransactions != null)
                    hashCode = hashCode * 59 + this.PendingAuthorizationTransactions.GetHashCode();
                if (this.HistoryAndIntradayTransactions != null)
                    hashCode = hashCode * 59 + this.HistoryAndIntradayTransactions.GetHashCode();
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