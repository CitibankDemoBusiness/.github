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
    /// ApplicantAddPhone
    /// </summary>
    [DataContract]
        public partial class ApplicantAddPhone :  IEquatable<ApplicantAddPhone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantAddPhone" /> class.
        /// </summary>
        /// <param name="phoneType">The type of phone.This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values. (required).</param>
        /// <param name="phoneCountryCode">Country code of phone number (required).</param>
        /// <param name="areaCode">The area code of phone number.</param>
        /// <param name="phoneNumber">Applicant&#x27;s phone number (required).</param>
        /// <param name="extension">Extension of phone number.</param>
        /// <param name="okToSms">Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false.</param>
        /// <param name="okToCall">Applicant&#x27;s consent for receiving phone calls. Valid values: true and false.</param>
        public ApplicantAddPhone(string phoneType = default(string), string phoneCountryCode = default(string), string areaCode = default(string), string phoneNumber = default(string), string extension = default(string), bool? okToSms = default(bool?), bool? okToCall = default(bool?))
        {
            // to ensure "phoneType" is required (not null)
            if (phoneType == null)
            {
                throw new InvalidDataException("phoneType is a required property for ApplicantAddPhone and cannot be null");
            }
            else
            {
                this.PhoneType = phoneType;
            }
            // to ensure "phoneCountryCode" is required (not null)
            if (phoneCountryCode == null)
            {
                throw new InvalidDataException("phoneCountryCode is a required property for ApplicantAddPhone and cannot be null");
            }
            else
            {
                this.PhoneCountryCode = phoneCountryCode;
            }
            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new InvalidDataException("phoneNumber is a required property for ApplicantAddPhone and cannot be null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }
            this.AreaCode = areaCode;
            this.Extension = extension;
            this.OkToSms = okToSms;
            this.OkToCall = okToCall;
        }
        
        /// <summary>
        /// The type of phone.This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>The type of phone.This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get valid value of this field with description. You can use phoneType field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="phoneType", EmitDefaultValue=false)]
        public string PhoneType { get; set; }

        /// <summary>
        /// Country code of phone number
        /// </summary>
        /// <value>Country code of phone number</value>
        [DataMember(Name="phoneCountryCode", EmitDefaultValue=false)]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// The area code of phone number
        /// </summary>
        /// <value>The area code of phone number</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Applicant&#x27;s phone number
        /// </summary>
        /// <value>Applicant&#x27;s phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Extension of phone number
        /// </summary>
        /// <value>Extension of phone number</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s consent for receiving sms. This is applicable only if phone type is MOBILE. Valid values: true and false</value>
        [DataMember(Name="okToSms", EmitDefaultValue=false)]
        public bool? OkToSms { get; set; }

        /// <summary>
        /// Applicant&#x27;s consent for receiving phone calls. Valid values: true and false
        /// </summary>
        /// <value>Applicant&#x27;s consent for receiving phone calls. Valid values: true and false</value>
        [DataMember(Name="okToCall", EmitDefaultValue=false)]
        public bool? OkToCall { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicantAddPhone {\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  PhoneCountryCode: ").Append(PhoneCountryCode).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  OkToSms: ").Append(OkToSms).Append("\n");
            sb.Append("  OkToCall: ").Append(OkToCall).Append("\n");
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
            return this.Equals(input as ApplicantAddPhone);
        }

        /// <summary>
        /// Returns true if ApplicantAddPhone instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantAddPhone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantAddPhone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.PhoneCountryCode == input.PhoneCountryCode ||
                    (this.PhoneCountryCode != null &&
                    this.PhoneCountryCode.Equals(input.PhoneCountryCode))
                ) && 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.OkToSms == input.OkToSms ||
                    (this.OkToSms != null &&
                    this.OkToSms.Equals(input.OkToSms))
                ) && 
                (
                    this.OkToCall == input.OkToCall ||
                    (this.OkToCall != null &&
                    this.OkToCall.Equals(input.OkToCall))
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
                if (this.PhoneType != null)
                    hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.PhoneCountryCode != null)
                    hashCode = hashCode * 59 + this.PhoneCountryCode.GetHashCode();
                if (this.AreaCode != null)
                    hashCode = hashCode * 59 + this.AreaCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.OkToSms != null)
                    hashCode = hashCode * 59 + this.OkToSms.GetHashCode();
                if (this.OkToCall != null)
                    hashCode = hashCode * 59 + this.OkToCall.GetHashCode();
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
