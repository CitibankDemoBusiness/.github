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
    /// RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
    /// </summary>
    [DataContract]
        public partial class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest :  IEquatable<RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest" /> class.
        /// </summary>
        /// <param name="loanAmount">Loan amount for easy payment plan booking..</param>
        /// <param name="tenor">Tenure of loan in months. (required).</param>
        public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest(double? loanAmount = default(double?), decimal? tenor = default(decimal?))
        {
            // to ensure "tenor" is required (not null)
            if (tenor == null)
            {
                throw new InvalidDataException("tenor is a required property for RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest and cannot be null");
            }
            else
            {
                this.Tenor = tenor;
            }
            this.LoanAmount = loanAmount;
        }
        
        /// <summary>
        /// Loan amount for easy payment plan booking.
        /// </summary>
        /// <value>Loan amount for easy payment plan booking.</value>
        [DataMember(Name="loanAmount", EmitDefaultValue=false)]
        public double? LoanAmount { get; set; }

        /// <summary>
        /// Tenure of loan in months.
        /// </summary>
        /// <value>Tenure of loan in months.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public decimal? Tenor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest {\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
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
            return this.Equals(input as RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest);
        }

        /// <summary>
        /// Returns true if RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanAmount == input.LoanAmount ||
                    (this.LoanAmount != null &&
                    this.LoanAmount.Equals(input.LoanAmount))
                ) && 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
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
                if (this.LoanAmount != null)
                    hashCode = hashCode * 59 + this.LoanAmount.GetHashCode();
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
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
