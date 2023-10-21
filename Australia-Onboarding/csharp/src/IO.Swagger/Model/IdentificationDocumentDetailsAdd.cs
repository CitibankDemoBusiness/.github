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
    /// IdentificationDocumentDetailsAdd
    /// </summary>
    [DataContract]
        public partial class IdentificationDocumentDetailsAdd :  IEquatable<IdentificationDocumentDetailsAdd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentificationDocumentDetailsAdd" /> class.
        /// </summary>
        /// <param name="idType">Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions.</param>
        /// <param name="idNumber">Unique identifier of identification document. Ex: Passport Number.</param>
        /// <param name="idExpiryDate">Expiry date of identification document in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="idIssueDate">Issuance date of identification document in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="idIssuePlace">Identification document issuance place.</param>
        /// <param name="idStatus">Identification document issuance status.</param>
        /// <param name="idIssueState">State from which identification document was issued.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description..</param>
        /// <param name="idIssueCountry">Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description..</param>
        /// <param name="isPrimaryId">Flag to mark primary identification document. Valid values: true and false.</param>
        /// <param name="referenceNumber">Medicare reference number..</param>
        /// <param name="middleName">Middle name printed on Medicare ID..</param>
        /// <param name="color">Color of Medicare ID. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idCardColor} resource to get possible values of this field with descriptions..</param>
        public IdentificationDocumentDetailsAdd(string idType = default(string), string idNumber = default(string), DateTime? idExpiryDate = default(DateTime?), DateTime? idIssueDate = default(DateTime?), string idIssuePlace = default(string), string idStatus = default(string), string idIssueState = default(string), string idIssueCountry = default(string), bool? isPrimaryId = default(bool?), string referenceNumber = default(string), string middleName = default(string), string color = default(string))
        {
            this.IdType = idType;
            this.IdNumber = idNumber;
            this.IdExpiryDate = idExpiryDate;
            this.IdIssueDate = idIssueDate;
            this.IdIssuePlace = idIssuePlace;
            this.IdStatus = idStatus;
            this.IdIssueState = idIssueState;
            this.IdIssueCountry = idIssueCountry;
            this.IsPrimaryId = isPrimaryId;
            this.ReferenceNumber = referenceNumber;
            this.MiddleName = middleName;
            this.Color = color;
        }
        
        /// <summary>
        /// Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions
        /// </summary>
        /// <value>Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions</value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public string IdType { get; set; }

        /// <summary>
        /// Unique identifier of identification document. Ex: Passport Number
        /// </summary>
        /// <value>Unique identifier of identification document. Ex: Passport Number</value>
        [DataMember(Name="idNumber", EmitDefaultValue=false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Expiry date of identification document in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Expiry date of identification document in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="idExpiryDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? IdExpiryDate { get; set; }

        /// <summary>
        /// Issuance date of identification document in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Issuance date of identification document in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="idIssueDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? IdIssueDate { get; set; }

        /// <summary>
        /// Identification document issuance place
        /// </summary>
        /// <value>Identification document issuance place</value>
        [DataMember(Name="idIssuePlace", EmitDefaultValue=false)]
        public string IdIssuePlace { get; set; }

        /// <summary>
        /// Identification document issuance status
        /// </summary>
        /// <value>Identification document issuance status</value>
        [DataMember(Name="idStatus", EmitDefaultValue=false)]
        public string IdStatus { get; set; }

        /// <summary>
        /// State from which identification document was issued.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description.
        /// </summary>
        /// <value>State from which identification document was issued.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description.</value>
        [DataMember(Name="idIssueState", EmitDefaultValue=false)]
        public string IdIssueState { get; set; }

        /// <summary>
        /// Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Country of issuance. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description.</value>
        [DataMember(Name="idIssueCountry", EmitDefaultValue=false)]
        public string IdIssueCountry { get; set; }

        /// <summary>
        /// Flag to mark primary identification document. Valid values: true and false
        /// </summary>
        /// <value>Flag to mark primary identification document. Valid values: true and false</value>
        [DataMember(Name="isPrimaryId", EmitDefaultValue=false)]
        public bool? IsPrimaryId { get; set; }

        /// <summary>
        /// Medicare reference number.
        /// </summary>
        /// <value>Medicare reference number.</value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Middle name printed on Medicare ID.
        /// </summary>
        /// <value>Middle name printed on Medicare ID.</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Color of Medicare ID. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idCardColor} resource to get possible values of this field with descriptions.
        /// </summary>
        /// <value>Color of Medicare ID. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idCardColor} resource to get possible values of this field with descriptions.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentificationDocumentDetailsAdd {\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  IdExpiryDate: ").Append(IdExpiryDate).Append("\n");
            sb.Append("  IdIssueDate: ").Append(IdIssueDate).Append("\n");
            sb.Append("  IdIssuePlace: ").Append(IdIssuePlace).Append("\n");
            sb.Append("  IdStatus: ").Append(IdStatus).Append("\n");
            sb.Append("  IdIssueState: ").Append(IdIssueState).Append("\n");
            sb.Append("  IdIssueCountry: ").Append(IdIssueCountry).Append("\n");
            sb.Append("  IsPrimaryId: ").Append(IsPrimaryId).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(input as IdentificationDocumentDetailsAdd);
        }

        /// <summary>
        /// Returns true if IdentificationDocumentDetailsAdd instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentificationDocumentDetailsAdd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationDocumentDetailsAdd input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.IdExpiryDate == input.IdExpiryDate ||
                    (this.IdExpiryDate != null &&
                    this.IdExpiryDate.Equals(input.IdExpiryDate))
                ) && 
                (
                    this.IdIssueDate == input.IdIssueDate ||
                    (this.IdIssueDate != null &&
                    this.IdIssueDate.Equals(input.IdIssueDate))
                ) && 
                (
                    this.IdIssuePlace == input.IdIssuePlace ||
                    (this.IdIssuePlace != null &&
                    this.IdIssuePlace.Equals(input.IdIssuePlace))
                ) && 
                (
                    this.IdStatus == input.IdStatus ||
                    (this.IdStatus != null &&
                    this.IdStatus.Equals(input.IdStatus))
                ) && 
                (
                    this.IdIssueState == input.IdIssueState ||
                    (this.IdIssueState != null &&
                    this.IdIssueState.Equals(input.IdIssueState))
                ) && 
                (
                    this.IdIssueCountry == input.IdIssueCountry ||
                    (this.IdIssueCountry != null &&
                    this.IdIssueCountry.Equals(input.IdIssueCountry))
                ) && 
                (
                    this.IsPrimaryId == input.IsPrimaryId ||
                    (this.IsPrimaryId != null &&
                    this.IsPrimaryId.Equals(input.IsPrimaryId))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
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
                if (this.IdType != null)
                    hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.IdExpiryDate != null)
                    hashCode = hashCode * 59 + this.IdExpiryDate.GetHashCode();
                if (this.IdIssueDate != null)
                    hashCode = hashCode * 59 + this.IdIssueDate.GetHashCode();
                if (this.IdIssuePlace != null)
                    hashCode = hashCode * 59 + this.IdIssuePlace.GetHashCode();
                if (this.IdStatus != null)
                    hashCode = hashCode * 59 + this.IdStatus.GetHashCode();
                if (this.IdIssueState != null)
                    hashCode = hashCode * 59 + this.IdIssueState.GetHashCode();
                if (this.IdIssueCountry != null)
                    hashCode = hashCode * 59 + this.IdIssueCountry.GetHashCode();
                if (this.IsPrimaryId != null)
                    hashCode = hashCode * 59 + this.IsPrimaryId.GetHashCode();
                if (this.ReferenceNumber != null)
                    hashCode = hashCode * 59 + this.ReferenceNumber.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
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
