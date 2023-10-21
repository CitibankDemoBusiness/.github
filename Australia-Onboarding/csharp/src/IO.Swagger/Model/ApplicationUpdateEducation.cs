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
    /// ApplicationUpdateEducation
    /// </summary>
    [DataContract]
        public partial class ApplicationUpdateEducation :  IEquatable<ApplicationUpdateEducation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateEducation" /> class.
        /// </summary>
        /// <param name="highestEducationLevel">Highest education level of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="yearOfGraduation">Year of completing graduation. This is required if applicant is a student.</param>
        /// <param name="studentId">Unique ID of the student. This is required if applicant is a student.</param>
        /// <param name="university">University name. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values..</param>
        public ApplicationUpdateEducation(string highestEducationLevel = default(string), string yearOfGraduation = default(string), string studentId = default(string), string university = default(string))
        {
            this.HighestEducationLevel = highestEducationLevel;
            this.YearOfGraduation = yearOfGraduation;
            this.StudentId = studentId;
            this.University = university;
        }
        
        /// <summary>
        /// Highest education level of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Highest education level of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="highestEducationLevel", EmitDefaultValue=false)]
        public string HighestEducationLevel { get; set; }

        /// <summary>
        /// Year of completing graduation. This is required if applicant is a student
        /// </summary>
        /// <value>Year of completing graduation. This is required if applicant is a student</value>
        [DataMember(Name="yearOfGraduation", EmitDefaultValue=false)]
        public string YearOfGraduation { get; set; }

        /// <summary>
        /// Unique ID of the student. This is required if applicant is a student
        /// </summary>
        /// <value>Unique ID of the student. This is required if applicant is a student</value>
        [DataMember(Name="studentId", EmitDefaultValue=false)]
        public string StudentId { get; set; }

        /// <summary>
        /// University name. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>University name. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="university", EmitDefaultValue=false)]
        public string University { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUpdateEducation {\n");
            sb.Append("  HighestEducationLevel: ").Append(HighestEducationLevel).Append("\n");
            sb.Append("  YearOfGraduation: ").Append(YearOfGraduation).Append("\n");
            sb.Append("  StudentId: ").Append(StudentId).Append("\n");
            sb.Append("  University: ").Append(University).Append("\n");
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
            return this.Equals(input as ApplicationUpdateEducation);
        }

        /// <summary>
        /// Returns true if ApplicationUpdateEducation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUpdateEducation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUpdateEducation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HighestEducationLevel == input.HighestEducationLevel ||
                    (this.HighestEducationLevel != null &&
                    this.HighestEducationLevel.Equals(input.HighestEducationLevel))
                ) && 
                (
                    this.YearOfGraduation == input.YearOfGraduation ||
                    (this.YearOfGraduation != null &&
                    this.YearOfGraduation.Equals(input.YearOfGraduation))
                ) && 
                (
                    this.StudentId == input.StudentId ||
                    (this.StudentId != null &&
                    this.StudentId.Equals(input.StudentId))
                ) && 
                (
                    this.University == input.University ||
                    (this.University != null &&
                    this.University.Equals(input.University))
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
                if (this.HighestEducationLevel != null)
                    hashCode = hashCode * 59 + this.HighestEducationLevel.GetHashCode();
                if (this.YearOfGraduation != null)
                    hashCode = hashCode * 59 + this.YearOfGraduation.GetHashCode();
                if (this.StudentId != null)
                    hashCode = hashCode * 59 + this.StudentId.GetHashCode();
                if (this.University != null)
                    hashCode = hashCode * 59 + this.University.GetHashCode();
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
