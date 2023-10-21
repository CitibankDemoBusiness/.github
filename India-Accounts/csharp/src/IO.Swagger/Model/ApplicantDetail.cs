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
    /// ApplicantDetail
    /// </summary>
    [DataContract]
        public partial class ApplicantDetail :  IEquatable<ApplicantDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantDetail" /> class.
        /// </summary>
        /// <param name="monthlyIncome">monthlyIncome.</param>
        public ApplicantDetail(double? monthlyIncome = default(double?))
        {
            this.MonthlyIncome = monthlyIncome;
        }
        
        /// <summary>
        /// Gets or Sets MonthlyIncome
        /// </summary>
        [DataMember(Name="monthlyIncome", EmitDefaultValue=false)]
        public double? MonthlyIncome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicantDetail {\n");
            sb.Append("  MonthlyIncome: ").Append(MonthlyIncome).Append("\n");
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
            return this.Equals(input as ApplicantDetail);
        }

        /// <summary>
        /// Returns true if ApplicantDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MonthlyIncome == input.MonthlyIncome ||
                    (this.MonthlyIncome != null &&
                    this.MonthlyIncome.Equals(input.MonthlyIncome))
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
                if (this.MonthlyIncome != null)
                    hashCode = hashCode * 59 + this.MonthlyIncome.GetHashCode();
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
