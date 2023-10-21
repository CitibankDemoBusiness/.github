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
    /// ApplicationInquiryProduct
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryProduct :  IEquatable<ApplicationInquiryProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryProduct" /> class.
        /// </summary>
        /// <param name="creditCardProduct">creditCardProduct.</param>
        /// <param name="readyCreditProduct">readyCreditProduct.</param>
        /// <param name="unsecuredLoanProduct">unsecuredLoanProduct.</param>
        public ApplicationInquiryProduct(ApplicationInquiryCreditCardProduct creditCardProduct = default(ApplicationInquiryCreditCardProduct), ApplicationInquiryReadyCreditProduct readyCreditProduct = default(ApplicationInquiryReadyCreditProduct), ApplicationInquiryUnsecuredLoanProduct unsecuredLoanProduct = default(ApplicationInquiryUnsecuredLoanProduct))
        {
            this.CreditCardProduct = creditCardProduct;
            this.ReadyCreditProduct = readyCreditProduct;
            this.UnsecuredLoanProduct = unsecuredLoanProduct;
        }
        
        /// <summary>
        /// Gets or Sets CreditCardProduct
        /// </summary>
        [DataMember(Name="creditCardProduct", EmitDefaultValue=false)]
        public ApplicationInquiryCreditCardProduct CreditCardProduct { get; set; }

        /// <summary>
        /// Gets or Sets ReadyCreditProduct
        /// </summary>
        [DataMember(Name="readyCreditProduct", EmitDefaultValue=false)]
        public ApplicationInquiryReadyCreditProduct ReadyCreditProduct { get; set; }

        /// <summary>
        /// Gets or Sets UnsecuredLoanProduct
        /// </summary>
        [DataMember(Name="unsecuredLoanProduct", EmitDefaultValue=false)]
        public ApplicationInquiryUnsecuredLoanProduct UnsecuredLoanProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryProduct {\n");
            sb.Append("  CreditCardProduct: ").Append(CreditCardProduct).Append("\n");
            sb.Append("  ReadyCreditProduct: ").Append(ReadyCreditProduct).Append("\n");
            sb.Append("  UnsecuredLoanProduct: ").Append(UnsecuredLoanProduct).Append("\n");
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
            return this.Equals(input as ApplicationInquiryProduct);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreditCardProduct == input.CreditCardProduct ||
                    (this.CreditCardProduct != null &&
                    this.CreditCardProduct.Equals(input.CreditCardProduct))
                ) && 
                (
                    this.ReadyCreditProduct == input.ReadyCreditProduct ||
                    (this.ReadyCreditProduct != null &&
                    this.ReadyCreditProduct.Equals(input.ReadyCreditProduct))
                ) && 
                (
                    this.UnsecuredLoanProduct == input.UnsecuredLoanProduct ||
                    (this.UnsecuredLoanProduct != null &&
                    this.UnsecuredLoanProduct.Equals(input.UnsecuredLoanProduct))
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
                if (this.CreditCardProduct != null)
                    hashCode = hashCode * 59 + this.CreditCardProduct.GetHashCode();
                if (this.ReadyCreditProduct != null)
                    hashCode = hashCode * 59 + this.ReadyCreditProduct.GetHashCode();
                if (this.UnsecuredLoanProduct != null)
                    hashCode = hashCode * 59 + this.UnsecuredLoanProduct.GetHashCode();
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
