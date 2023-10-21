/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
    /// ECMProductUpdate
    /// </summary>
    [DataContract]
        public partial class ECMProductUpdate :  IEquatable<ECMProductUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMProductUpdate" /> class.
        /// </summary>
        /// <param name="tenor">Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description..</param>
        /// <param name="creditCardProduct">creditCardProduct.</param>
        public ECMProductUpdate(string tenor = default(string), ECMCreditCardProductUpdate creditCardProduct = default(ECMCreditCardProductUpdate))
        {
            this.Tenor = tenor;
            this.CreditCardProduct = creditCardProduct;
        }
        
        /// <summary>
        /// Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.</value>
        [DataMember(Name="tenor", EmitDefaultValue=false)]
        public string Tenor { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardProduct
        /// </summary>
        [DataMember(Name="creditCardProduct", EmitDefaultValue=false)]
        public ECMCreditCardProductUpdate CreditCardProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMProductUpdate {\n");
            sb.Append("  Tenor: ").Append(Tenor).Append("\n");
            sb.Append("  CreditCardProduct: ").Append(CreditCardProduct).Append("\n");
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
            return this.Equals(input as ECMProductUpdate);
        }

        /// <summary>
        /// Returns true if ECMProductUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMProductUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMProductUpdate input)
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
                    this.CreditCardProduct == input.CreditCardProduct ||
                    (this.CreditCardProduct != null &&
                    this.CreditCardProduct.Equals(input.CreditCardProduct))
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
                if (this.CreditCardProduct != null)
                    hashCode = hashCode * 59 + this.CreditCardProduct.GetHashCode();
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
