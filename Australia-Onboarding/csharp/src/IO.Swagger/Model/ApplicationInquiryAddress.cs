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
    /// ApplicationInquiryAddress
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryAddress :  IEquatable<ApplicationInquiryAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryAddress" /> class.
        /// </summary>
        /// <param name="addressType">Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="addressLine1">Address line 1.</param>
        /// <param name="addressLine2">Address line 2.</param>
        /// <param name="addressLine3">Address line 3.</param>
        /// <param name="addressLine4">Address line 4.</param>
        /// <param name="cityName">City.</param>
        /// <param name="state">State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="postalCode">Postal/ZIP code.</param>
        /// <param name="provinceCode">Province code.</param>
        /// <param name="countryCode">ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="okToMail">Applicant&#x27;s consent for receiving mail. Valid values: true and false.</param>
        /// <param name="residenceDurationInYears">Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address..</param>
        /// <param name="residenceDurationInMonths">Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address..</param>
        /// <param name="countrySpecificAddress">countrySpecificAddress.</param>
        public ApplicationInquiryAddress(string addressType = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string cityName = default(string), string state = default(string), string postalCode = default(string), string provinceCode = default(string), string countryCode = default(string), bool? okToMail = default(bool?), int? residenceDurationInYears = default(int?), int? residenceDurationInMonths = default(int?), ApplicationInquiryCountrySpecificAddress countrySpecificAddress = default(ApplicationInquiryCountrySpecificAddress))
        {
            this.AddressType = addressType;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.CityName = cityName;
            this.State = state;
            this.PostalCode = postalCode;
            this.ProvinceCode = provinceCode;
            this.CountryCode = countryCode;
            this.OkToMail = okToMail;
            this.ResidenceDurationInYears = residenceDurationInYears;
            this.ResidenceDurationInMonths = residenceDurationInMonths;
            this.CountrySpecificAddress = countrySpecificAddress;
        }
        
        /// <summary>
        /// Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        /// <value>Address line 1</value>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        /// <value>Address line 2</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address line 3
        /// </summary>
        /// <value>Address line 3</value>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Address line 4
        /// </summary>
        /// <value>Address line 4</value>
        [DataMember(Name="addressLine4", EmitDefaultValue=false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="cityName", EmitDefaultValue=false)]
        public string CityName { get; set; }

        /// <summary>
        /// State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Postal/ZIP code
        /// </summary>
        /// <value>Postal/ZIP code</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Province code
        /// </summary>
        /// <value>Province code</value>
        [DataMember(Name="provinceCode", EmitDefaultValue=false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Applicant&#x27;s consent for receiving mail. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s consent for receiving mail. Valid values: true and false</value>
        [DataMember(Name="okToMail", EmitDefaultValue=false)]
        public bool? OkToMail { get; set; }

        /// <summary>
        /// Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address.
        /// </summary>
        /// <value>Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address.</value>
        [DataMember(Name="residenceDurationInYears", EmitDefaultValue=false)]
        public int? ResidenceDurationInYears { get; set; }

        /// <summary>
        /// Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address.
        /// </summary>
        /// <value>Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address.</value>
        [DataMember(Name="residenceDurationInMonths", EmitDefaultValue=false)]
        public int? ResidenceDurationInMonths { get; set; }

        /// <summary>
        /// Gets or Sets CountrySpecificAddress
        /// </summary>
        [DataMember(Name="countrySpecificAddress", EmitDefaultValue=false)]
        public ApplicationInquiryCountrySpecificAddress CountrySpecificAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryAddress {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  OkToMail: ").Append(OkToMail).Append("\n");
            sb.Append("  ResidenceDurationInYears: ").Append(ResidenceDurationInYears).Append("\n");
            sb.Append("  ResidenceDurationInMonths: ").Append(ResidenceDurationInMonths).Append("\n");
            sb.Append("  CountrySpecificAddress: ").Append(CountrySpecificAddress).Append("\n");
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
            return this.Equals(input as ApplicationInquiryAddress);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.OkToMail == input.OkToMail ||
                    (this.OkToMail != null &&
                    this.OkToMail.Equals(input.OkToMail))
                ) && 
                (
                    this.ResidenceDurationInYears == input.ResidenceDurationInYears ||
                    (this.ResidenceDurationInYears != null &&
                    this.ResidenceDurationInYears.Equals(input.ResidenceDurationInYears))
                ) && 
                (
                    this.ResidenceDurationInMonths == input.ResidenceDurationInMonths ||
                    (this.ResidenceDurationInMonths != null &&
                    this.ResidenceDurationInMonths.Equals(input.ResidenceDurationInMonths))
                ) && 
                (
                    this.CountrySpecificAddress == input.CountrySpecificAddress ||
                    (this.CountrySpecificAddress != null &&
                    this.CountrySpecificAddress.Equals(input.CountrySpecificAddress))
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
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.CityName != null)
                    hashCode = hashCode * 59 + this.CityName.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.ProvinceCode != null)
                    hashCode = hashCode * 59 + this.ProvinceCode.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.OkToMail != null)
                    hashCode = hashCode * 59 + this.OkToMail.GetHashCode();
                if (this.ResidenceDurationInYears != null)
                    hashCode = hashCode * 59 + this.ResidenceDurationInYears.GetHashCode();
                if (this.ResidenceDurationInMonths != null)
                    hashCode = hashCode * 59 + this.ResidenceDurationInMonths.GetHashCode();
                if (this.CountrySpecificAddress != null)
                    hashCode = hashCode * 59 + this.CountrySpecificAddress.GetHashCode();
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
