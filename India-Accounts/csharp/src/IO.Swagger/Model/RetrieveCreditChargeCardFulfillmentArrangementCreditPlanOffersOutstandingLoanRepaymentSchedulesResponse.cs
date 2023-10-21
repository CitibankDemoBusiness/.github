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
    /// RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse :  IEquatable<RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse" /> class.
        /// </summary>
        /// <param name="nextStartIndex">The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex..</param>
        /// <param name="loanAmortizationSchedule">loanAmortizationSchedule.</param>
        public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse(string nextStartIndex = default(string), List<LoanAmortizationSchedule> loanAmortizationSchedule = default(List<LoanAmortizationSchedule>))
        {
            this.NextStartIndex = nextStartIndex;
            this.LoanAmortizationSchedule = loanAmortizationSchedule;
        }
        
        /// <summary>
        /// The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.
        /// </summary>
        /// <value>The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// Gets or Sets LoanAmortizationSchedule
        /// </summary>
        [DataMember(Name="loanAmortizationSchedule", EmitDefaultValue=false)]
        public List<LoanAmortizationSchedule> LoanAmortizationSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse {\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
            sb.Append("  LoanAmortizationSchedule: ").Append(LoanAmortizationSchedule).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextStartIndex == input.NextStartIndex ||
                    (this.NextStartIndex != null &&
                    this.NextStartIndex.Equals(input.NextStartIndex))
                ) && 
                (
                    this.LoanAmortizationSchedule == input.LoanAmortizationSchedule ||
                    this.LoanAmortizationSchedule != null &&
                    input.LoanAmortizationSchedule != null &&
                    this.LoanAmortizationSchedule.SequenceEqual(input.LoanAmortizationSchedule)
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
                if (this.NextStartIndex != null)
                    hashCode = hashCode * 59 + this.NextStartIndex.GetHashCode();
                if (this.LoanAmortizationSchedule != null)
                    hashCode = hashCode * 59 + this.LoanAmortizationSchedule.GetHashCode();
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
