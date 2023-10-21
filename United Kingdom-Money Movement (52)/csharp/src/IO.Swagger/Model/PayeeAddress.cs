/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    /// PayeeAddress
    /// </summary>
    [DataContract]
        public partial class PayeeAddress :  IEquatable<PayeeAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayeeAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">Address line 1 (required).</param>
        /// <param name="addressLine2">Address line 2.</param>
        /// <param name="addressLine3">Address line 3.</param>
        /// <param name="countryName">This field is to indicate the name of the country. This is a reference data field. Please use /v1/utilities/referenceData/{countryName} resource to get valid value of this field with description..</param>
        public PayeeAddress(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string countryName = default(string))
        {
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for PayeeAddress and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.CountryName = countryName;
        }
        
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
        /// This field is to indicate the name of the country. This is a reference data field. Please use /v1/utilities/referenceData/{countryName} resource to get valid value of this field with description.
        /// </summary>
        /// <value>This field is to indicate the name of the country. This is a reference data field. Please use /v1/utilities/referenceData/{countryName} resource to get valid value of this field with description.</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayeeAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
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
            return this.Equals(input as PayeeAddress);
        }

        /// <summary>
        /// Returns true if PayeeAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of PayeeAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayeeAddress input)
        {
            if (input == null)
                return false;

            return 
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
                    this.CountryName == input.CountryName ||
                    (this.CountryName != null &&
                    this.CountryName.Equals(input.CountryName))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.CountryName != null)
                    hashCode = hashCode * 59 + this.CountryName.GetHashCode();
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