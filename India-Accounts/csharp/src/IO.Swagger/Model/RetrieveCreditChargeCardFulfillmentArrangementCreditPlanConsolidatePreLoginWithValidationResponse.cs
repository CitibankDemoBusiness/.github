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
    /// RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse :  IEquatable<RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse" /> class.
        /// </summary>
        /// <param name="initialFeeAmount">First month fee/interest charge incurred from booking date to next statement cycle date.</param>
        /// <param name="closureInterestAmount">Closure Interest accrued from last cycle/booking date till date, to be charged for each of the loans getting closed due to Top up post merger.</param>
        public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse(double? initialFeeAmount = default(double?), double? closureInterestAmount = default(double?))
        {
            this.InitialFeeAmount = initialFeeAmount;
            this.ClosureInterestAmount = closureInterestAmount;
        }
        
        /// <summary>
        /// First month fee/interest charge incurred from booking date to next statement cycle date
        /// </summary>
        /// <value>First month fee/interest charge incurred from booking date to next statement cycle date</value>
        [DataMember(Name="initialFeeAmount", EmitDefaultValue=false)]
        public double? InitialFeeAmount { get; set; }

        /// <summary>
        /// Closure Interest accrued from last cycle/booking date till date, to be charged for each of the loans getting closed due to Top up post merger
        /// </summary>
        /// <value>Closure Interest accrued from last cycle/booking date till date, to be charged for each of the loans getting closed due to Top up post merger</value>
        [DataMember(Name="closureInterestAmount", EmitDefaultValue=false)]
        public double? ClosureInterestAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse {\n");
            sb.Append("  InitialFeeAmount: ").Append(InitialFeeAmount).Append("\n");
            sb.Append("  ClosureInterestAmount: ").Append(ClosureInterestAmount).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InitialFeeAmount == input.InitialFeeAmount ||
                    (this.InitialFeeAmount != null &&
                    this.InitialFeeAmount.Equals(input.InitialFeeAmount))
                ) && 
                (
                    this.ClosureInterestAmount == input.ClosureInterestAmount ||
                    (this.ClosureInterestAmount != null &&
                    this.ClosureInterestAmount.Equals(input.ClosureInterestAmount))
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
                if (this.InitialFeeAmount != null)
                    hashCode = hashCode * 59 + this.InitialFeeAmount.GetHashCode();
                if (this.ClosureInterestAmount != null)
                    hashCode = hashCode * 59 + this.ClosureInterestAmount.GetHashCode();
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
