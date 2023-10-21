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
    /// PaymentPans
    /// </summary>
    [DataContract]
        public partial class PaymentPans :  IEquatable<PaymentPans>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentPans" /> class.
        /// </summary>
        /// <param name="tenor">Tenure of loan in months..</param>
        /// <param name="effectiveInterestRate">Loan effective interest rate.</param>
        /// <param name="annualPercentageRate">Compounded annual interest rate..</param>
        /// <param name="oneTimeProcessingFeeIndicator">One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description..</param>
        /// <param name="oneTimeProcessingFeeAmount">Fee charged as part of one time processing..</param>
        /// <param name="oneTimeProcessingFeePercentage">Percentage of one time processing fee charged..</param>
        public PaymentPans(decimal? tenor = default(decimal?), double? effectiveInterestRate = default(double?), double? annualPercentageRate = default(double?), string oneTimeProcessingFeeIndicator = default(string), double? oneTimeProcessingFeeAmount = default(double?), double? oneTimeProcessingFeePercentage = default(double?))
        {
            this.Tenor = tenor;
            this.EffectiveInterestRate = effectiveInterestRate;
            this.AnnualPercentageRate = annualPercentageRate;
            this.OneTimeProcessingFeeIndicator = oneTimeProcessingFeeIndicator;
            this.OneTimeProcessingFeeAmount = oneTimeProcessingFeeAmount;
            this.OneTimeProcessingFeePercentage = oneTimeProcessingFeePercentage;
        }
        
        /// <summary>
        /// Tenure of loan in months.
        /// </summary>
        /// <value>Tenure of loan in months.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public decimal? Tenor { get; set; }

        /// <summary>
        /// Loan effective interest rate
        /// </summary>
        /// <value>Loan effective interest rate</value>
        [DataMember(Name="effectiveInterestRate", EmitDefaultValue=false)]
        public double? EffectiveInterestRate { get; set; }

        /// <summary>
        /// Compounded annual interest rate.
        /// </summary>
        /// <value>Compounded annual interest rate.</value>
        [DataMember(Name="annualPercentageRate", EmitDefaultValue=false)]
        public double? AnnualPercentageRate { get; set; }

        /// <summary>
        /// One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.
        /// </summary>
        /// <value>One time processing fee indicator. Valid values : PERCENTAGE, FIXED_AMOUNT. This is a reference data field. Please use /v1/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.</value>
        [DataMember(Name="oneTimeProcessingFeeIndicator", EmitDefaultValue=false)]
        public string OneTimeProcessingFeeIndicator { get; set; }

        /// <summary>
        /// Fee charged as part of one time processing.
        /// </summary>
        /// <value>Fee charged as part of one time processing.</value>
        [DataMember(Name="oneTimeProcessingFeeAmount", EmitDefaultValue=false)]
        public double? OneTimeProcessingFeeAmount { get; set; }

        /// <summary>
        /// Percentage of one time processing fee charged.
        /// </summary>
        /// <value>Percentage of one time processing fee charged.</value>
        [DataMember(Name="oneTimeProcessingFeePercentage", EmitDefaultValue=false)]
        public double? OneTimeProcessingFeePercentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentPans {\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  EffectiveInterestRate: ").Append(EffectiveInterestRate).Append("\n");
            sb.Append("  AnnualPercentageRate: ").Append(AnnualPercentageRate).Append("\n");
            sb.Append("  OneTimeProcessingFeeIndicator: ").Append(OneTimeProcessingFeeIndicator).Append("\n");
            sb.Append("  OneTimeProcessingFeeAmount: ").Append(OneTimeProcessingFeeAmount).Append("\n");
            sb.Append("  OneTimeProcessingFeePercentage: ").Append(OneTimeProcessingFeePercentage).Append("\n");
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
            return this.Equals(input as PaymentPans);
        }

        /// <summary>
        /// Returns true if PaymentPans instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentPans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentPans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tenor == input.Tenor ||
                    (this.Tenor != null &&
                    this.Tenor.Equals(input.Tenor))
                ) && 
                (
                    this.EffectiveInterestRate == input.EffectiveInterestRate ||
                    (this.EffectiveInterestRate != null &&
                    this.EffectiveInterestRate.Equals(input.EffectiveInterestRate))
                ) && 
                (
                    this.AnnualPercentageRate == input.AnnualPercentageRate ||
                    (this.AnnualPercentageRate != null &&
                    this.AnnualPercentageRate.Equals(input.AnnualPercentageRate))
                ) && 
                (
                    this.OneTimeProcessingFeeIndicator == input.OneTimeProcessingFeeIndicator ||
                    (this.OneTimeProcessingFeeIndicator != null &&
                    this.OneTimeProcessingFeeIndicator.Equals(input.OneTimeProcessingFeeIndicator))
                ) && 
                (
                    this.OneTimeProcessingFeeAmount == input.OneTimeProcessingFeeAmount ||
                    (this.OneTimeProcessingFeeAmount != null &&
                    this.OneTimeProcessingFeeAmount.Equals(input.OneTimeProcessingFeeAmount))
                ) && 
                (
                    this.OneTimeProcessingFeePercentage == input.OneTimeProcessingFeePercentage ||
                    (this.OneTimeProcessingFeePercentage != null &&
                    this.OneTimeProcessingFeePercentage.Equals(input.OneTimeProcessingFeePercentage))
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
                if (this.Tenor != null)
                    hashCode = hashCode * 59 + this.Tenor.GetHashCode();
                if (this.EffectiveInterestRate != null)
                    hashCode = hashCode * 59 + this.EffectiveInterestRate.GetHashCode();
                if (this.AnnualPercentageRate != null)
                    hashCode = hashCode * 59 + this.AnnualPercentageRate.GetHashCode();
                if (this.OneTimeProcessingFeeIndicator != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeeIndicator.GetHashCode();
                if (this.OneTimeProcessingFeeAmount != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeeAmount.GetHashCode();
                if (this.OneTimeProcessingFeePercentage != null)
                    hashCode = hashCode * 59 + this.OneTimeProcessingFeePercentage.GetHashCode();
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
