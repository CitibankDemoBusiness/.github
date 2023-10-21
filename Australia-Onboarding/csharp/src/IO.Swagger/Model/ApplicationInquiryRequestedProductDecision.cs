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
    /// ApplicationInquiryRequestedProductDecision
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryRequestedProductDecision :  IEquatable<ApplicationInquiryRequestedProductDecision>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryRequestedProductDecision" /> class.
        /// </summary>
        /// <param name="productCode">A unique code that identifies the product (required).</param>
        /// <param name="organisationName">Card issuing Organisation code (required).</param>
        /// <param name="sourceCode">A source code to identify the product (required).</param>
        /// <param name="logo">Product logo to identify the product.</param>
        /// <param name="creditDecision">Evaluated Applicant Credit Decision.</param>
        /// <param name="creditSpecificRecommendations">creditSpecificRecommendations.</param>
        /// <param name="loanSpecificRecommendations">loanSpecificRecommendations.</param>
        /// <param name="requiredDocuments">requiredDocuments.</param>
        public ApplicationInquiryRequestedProductDecision(string productCode = default(string), string organisationName = default(string), string sourceCode = default(string), string logo = default(string), string creditDecision = default(string), List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations = default(List<ApplicationInquiryCreditSpecificRecommendations>), List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations = default(List<ApplicationInquiryLoanSpecificRecommendations>), List<ApplicationInquiryRequiredDocuments> requiredDocuments = default(List<ApplicationInquiryRequiredDocuments>))
        {
            // to ensure "productCode" is required (not null)
            if (productCode == null)
            {
                throw new InvalidDataException("productCode is a required property for ApplicationInquiryRequestedProductDecision and cannot be null");
            }
            else
            {
                this.ProductCode = productCode;
            }
            // to ensure "organisationName" is required (not null)
            if (organisationName == null)
            {
                throw new InvalidDataException("organisationName is a required property for ApplicationInquiryRequestedProductDecision and cannot be null");
            }
            else
            {
                this.OrganisationName = organisationName;
            }
            // to ensure "sourceCode" is required (not null)
            if (sourceCode == null)
            {
                throw new InvalidDataException("sourceCode is a required property for ApplicationInquiryRequestedProductDecision and cannot be null");
            }
            else
            {
                this.SourceCode = sourceCode;
            }
            this.Logo = logo;
            this.CreditDecision = creditDecision;
            this.CreditSpecificRecommendations = creditSpecificRecommendations;
            this.LoanSpecificRecommendations = loanSpecificRecommendations;
            this.RequiredDocuments = requiredDocuments;
        }
        
        /// <summary>
        /// A unique code that identifies the product
        /// </summary>
        /// <value>A unique code that identifies the product</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Card issuing Organisation code
        /// </summary>
        /// <value>Card issuing Organisation code</value>
        [DataMember(Name="organisationName", EmitDefaultValue=false)]
        public string OrganisationName { get; set; }

        /// <summary>
        /// A source code to identify the product
        /// </summary>
        /// <value>A source code to identify the product</value>
        [DataMember(Name="sourceCode", EmitDefaultValue=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// Product logo to identify the product
        /// </summary>
        /// <value>Product logo to identify the product</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Evaluated Applicant Credit Decision
        /// </summary>
        /// <value>Evaluated Applicant Credit Decision</value>
        [DataMember(Name="creditDecision", EmitDefaultValue=false)]
        public string CreditDecision { get; set; }

        /// <summary>
        /// Gets or Sets CreditSpecificRecommendations
        /// </summary>
        [DataMember(Name="creditSpecificRecommendations", EmitDefaultValue=false)]
        public List<ApplicationInquiryCreditSpecificRecommendations> CreditSpecificRecommendations { get; set; }

        /// <summary>
        /// Gets or Sets LoanSpecificRecommendations
        /// </summary>
        [DataMember(Name="loanSpecificRecommendations", EmitDefaultValue=false)]
        public List<ApplicationInquiryLoanSpecificRecommendations> LoanSpecificRecommendations { get; set; }

        /// <summary>
        /// Gets or Sets RequiredDocuments
        /// </summary>
        [DataMember(Name="requiredDocuments", EmitDefaultValue=false)]
        public List<ApplicationInquiryRequiredDocuments> RequiredDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryRequestedProductDecision {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  OrganisationName: ").Append(OrganisationName).Append("\n");
            sb.Append("  SourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CreditDecision: ").Append(CreditDecision).Append("\n");
            sb.Append("  CreditSpecificRecommendations: ").Append(CreditSpecificRecommendations).Append("\n");
            sb.Append("  LoanSpecificRecommendations: ").Append(LoanSpecificRecommendations).Append("\n");
            sb.Append("  RequiredDocuments: ").Append(RequiredDocuments).Append("\n");
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
            return this.Equals(input as ApplicationInquiryRequestedProductDecision);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryRequestedProductDecision instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryRequestedProductDecision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryRequestedProductDecision input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.OrganisationName == input.OrganisationName ||
                    (this.OrganisationName != null &&
                    this.OrganisationName.Equals(input.OrganisationName))
                ) && 
                (
                    this.SourceCode == input.SourceCode ||
                    (this.SourceCode != null &&
                    this.SourceCode.Equals(input.SourceCode))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.CreditDecision == input.CreditDecision ||
                    (this.CreditDecision != null &&
                    this.CreditDecision.Equals(input.CreditDecision))
                ) && 
                (
                    this.CreditSpecificRecommendations == input.CreditSpecificRecommendations ||
                    this.CreditSpecificRecommendations != null &&
                    input.CreditSpecificRecommendations != null &&
                    this.CreditSpecificRecommendations.SequenceEqual(input.CreditSpecificRecommendations)
                ) && 
                (
                    this.LoanSpecificRecommendations == input.LoanSpecificRecommendations ||
                    this.LoanSpecificRecommendations != null &&
                    input.LoanSpecificRecommendations != null &&
                    this.LoanSpecificRecommendations.SequenceEqual(input.LoanSpecificRecommendations)
                ) && 
                (
                    this.RequiredDocuments == input.RequiredDocuments ||
                    this.RequiredDocuments != null &&
                    input.RequiredDocuments != null &&
                    this.RequiredDocuments.SequenceEqual(input.RequiredDocuments)
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
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.OrganisationName != null)
                    hashCode = hashCode * 59 + this.OrganisationName.GetHashCode();
                if (this.SourceCode != null)
                    hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.CreditDecision != null)
                    hashCode = hashCode * 59 + this.CreditDecision.GetHashCode();
                if (this.CreditSpecificRecommendations != null)
                    hashCode = hashCode * 59 + this.CreditSpecificRecommendations.GetHashCode();
                if (this.LoanSpecificRecommendations != null)
                    hashCode = hashCode * 59 + this.LoanSpecificRecommendations.GetHashCode();
                if (this.RequiredDocuments != null)
                    hashCode = hashCode * 59 + this.RequiredDocuments.GetHashCode();
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