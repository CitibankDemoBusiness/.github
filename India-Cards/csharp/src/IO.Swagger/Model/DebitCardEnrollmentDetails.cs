/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    /// DebitCardEnrollmentDetails
    /// </summary>
    [DataContract]
        public partial class DebitCardEnrollmentDetails :  IEquatable<DebitCardEnrollmentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebitCardEnrollmentDetails" /> class.
        /// </summary>
        /// <param name="internetPurchaseAccessFlag">Flag to indicate if internet purchase access is enabled or not on the debit/credit card.</param>
        /// <param name="contactlessPaymentEnrolledFlag">Flag to indicate if contact-less payment is enabled or not on the debit/credit card.</param>
        /// <param name="overseasAtmAccessAllowedFlag">This field is to indicate if overseas ATM access is allowed to the card..</param>
        public DebitCardEnrollmentDetails(bool? internetPurchaseAccessFlag = default(bool?), bool? contactlessPaymentEnrolledFlag = default(bool?), bool? overseasAtmAccessAllowedFlag = default(bool?))
        {
            this.InternetPurchaseAccessFlag = internetPurchaseAccessFlag;
            this.ContactlessPaymentEnrolledFlag = contactlessPaymentEnrolledFlag;
            this.OverseasAtmAccessAllowedFlag = overseasAtmAccessAllowedFlag;
        }
        
        /// <summary>
        /// Flag to indicate if internet purchase access is enabled or not on the debit/credit card
        /// </summary>
        /// <value>Flag to indicate if internet purchase access is enabled or not on the debit/credit card</value>
        [DataMember(Name="internetPurchaseAccessFlag", EmitDefaultValue=false)]
        public bool? InternetPurchaseAccessFlag { get; set; }

        /// <summary>
        /// Flag to indicate if contact-less payment is enabled or not on the debit/credit card
        /// </summary>
        /// <value>Flag to indicate if contact-less payment is enabled or not on the debit/credit card</value>
        [DataMember(Name="contactlessPaymentEnrolledFlag", EmitDefaultValue=false)]
        public bool? ContactlessPaymentEnrolledFlag { get; set; }

        /// <summary>
        /// This field is to indicate if overseas ATM access is allowed to the card.
        /// </summary>
        /// <value>This field is to indicate if overseas ATM access is allowed to the card.</value>
        [DataMember(Name="overseasAtmAccessAllowedFlag", EmitDefaultValue=false)]
        public bool? OverseasAtmAccessAllowedFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebitCardEnrollmentDetails {\n");
            sb.Append("  InternetPurchaseAccessFlag: ").Append(InternetPurchaseAccessFlag).Append("\n");
            sb.Append("  ContactlessPaymentEnrolledFlag: ").Append(ContactlessPaymentEnrolledFlag).Append("\n");
            sb.Append("  OverseasAtmAccessAllowedFlag: ").Append(OverseasAtmAccessAllowedFlag).Append("\n");
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
            return this.Equals(input as DebitCardEnrollmentDetails);
        }

        /// <summary>
        /// Returns true if DebitCardEnrollmentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DebitCardEnrollmentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebitCardEnrollmentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InternetPurchaseAccessFlag == input.InternetPurchaseAccessFlag ||
                    (this.InternetPurchaseAccessFlag != null &&
                    this.InternetPurchaseAccessFlag.Equals(input.InternetPurchaseAccessFlag))
                ) && 
                (
                    this.ContactlessPaymentEnrolledFlag == input.ContactlessPaymentEnrolledFlag ||
                    (this.ContactlessPaymentEnrolledFlag != null &&
                    this.ContactlessPaymentEnrolledFlag.Equals(input.ContactlessPaymentEnrolledFlag))
                ) && 
                (
                    this.OverseasAtmAccessAllowedFlag == input.OverseasAtmAccessAllowedFlag ||
                    (this.OverseasAtmAccessAllowedFlag != null &&
                    this.OverseasAtmAccessAllowedFlag.Equals(input.OverseasAtmAccessAllowedFlag))
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
                if (this.InternetPurchaseAccessFlag != null)
                    hashCode = hashCode * 59 + this.InternetPurchaseAccessFlag.GetHashCode();
                if (this.ContactlessPaymentEnrolledFlag != null)
                    hashCode = hashCode * 59 + this.ContactlessPaymentEnrolledFlag.GetHashCode();
                if (this.OverseasAtmAccessAllowedFlag != null)
                    hashCode = hashCode * 59 + this.OverseasAtmAccessAllowedFlag.GetHashCode();
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