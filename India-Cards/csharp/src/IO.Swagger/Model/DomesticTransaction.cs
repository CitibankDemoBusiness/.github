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
    /// DomesticTransaction
    /// </summary>
    [DataContract]
        public partial class DomesticTransaction :  IEquatable<DomesticTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomesticTransaction" /> class.
        /// </summary>
        /// <param name="atmTransactionLimitToggleIndicator">DomesticSingleATMTransactionLimitToggleFlag.</param>
        /// <param name="atmTransactionLimitAmount">DomesticSingleATMTransactionLimit.</param>
        /// <param name="contactlessTxnLimitToggleIndicator">DomesticSingleContactlessTransactionLimitToggleFlag.</param>
        /// <param name="contactlessTransactionLimitAmount">DomesticSingleContactlessTransactionLimit.</param>
        /// <param name="contactPosTxnLimitToggleIndicator">DomesticSingleContactPOSTransactionLimitToggleFlag.</param>
        /// <param name="contactPosTransactionLimitAmount">DomesticSingleContactPOSTransactionLimit.</param>
        /// <param name="nonPosTxnLimitToggleIndicator">DomesticSingleNonPOSTransactionLimitToggleFlag.</param>
        /// <param name="nonPosTransactionLimitAmount">DomesticSingleNonPOSTransactionLimit.</param>
        public DomesticTransaction(string atmTransactionLimitToggleIndicator = default(string), double? atmTransactionLimitAmount = default(double?), string contactlessTxnLimitToggleIndicator = default(string), double? contactlessTransactionLimitAmount = default(double?), string contactPosTxnLimitToggleIndicator = default(string), double? contactPosTransactionLimitAmount = default(double?), string nonPosTxnLimitToggleIndicator = default(string), double? nonPosTransactionLimitAmount = default(double?))
        {
            this.AtmTransactionLimitToggleIndicator = atmTransactionLimitToggleIndicator;
            this.AtmTransactionLimitAmount = atmTransactionLimitAmount;
            this.ContactlessTxnLimitToggleIndicator = contactlessTxnLimitToggleIndicator;
            this.ContactlessTransactionLimitAmount = contactlessTransactionLimitAmount;
            this.ContactPosTxnLimitToggleIndicator = contactPosTxnLimitToggleIndicator;
            this.ContactPosTransactionLimitAmount = contactPosTransactionLimitAmount;
            this.NonPosTxnLimitToggleIndicator = nonPosTxnLimitToggleIndicator;
            this.NonPosTransactionLimitAmount = nonPosTransactionLimitAmount;
        }
        
        /// <summary>
        /// DomesticSingleATMTransactionLimitToggleFlag
        /// </summary>
        /// <value>DomesticSingleATMTransactionLimitToggleFlag</value>
        [DataMember(Name="atmTransactionLimitToggleIndicator", EmitDefaultValue=false)]
        public string AtmTransactionLimitToggleIndicator { get; set; }

        /// <summary>
        /// DomesticSingleATMTransactionLimit
        /// </summary>
        /// <value>DomesticSingleATMTransactionLimit</value>
        [DataMember(Name="atmTransactionLimitAmount", EmitDefaultValue=false)]
        public double? AtmTransactionLimitAmount { get; set; }

        /// <summary>
        /// DomesticSingleContactlessTransactionLimitToggleFlag
        /// </summary>
        /// <value>DomesticSingleContactlessTransactionLimitToggleFlag</value>
        [DataMember(Name="contactlessTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string ContactlessTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// DomesticSingleContactlessTransactionLimit
        /// </summary>
        /// <value>DomesticSingleContactlessTransactionLimit</value>
        [DataMember(Name="contactlessTransactionLimitAmount", EmitDefaultValue=false)]
        public double? ContactlessTransactionLimitAmount { get; set; }

        /// <summary>
        /// DomesticSingleContactPOSTransactionLimitToggleFlag
        /// </summary>
        /// <value>DomesticSingleContactPOSTransactionLimitToggleFlag</value>
        [DataMember(Name="contactPosTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string ContactPosTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// DomesticSingleContactPOSTransactionLimit
        /// </summary>
        /// <value>DomesticSingleContactPOSTransactionLimit</value>
        [DataMember(Name="contactPosTransactionLimitAmount", EmitDefaultValue=false)]
        public double? ContactPosTransactionLimitAmount { get; set; }

        /// <summary>
        /// DomesticSingleNonPOSTransactionLimitToggleFlag
        /// </summary>
        /// <value>DomesticSingleNonPOSTransactionLimitToggleFlag</value>
        [DataMember(Name="nonPosTxnLimitToggleIndicator", EmitDefaultValue=false)]
        public string NonPosTxnLimitToggleIndicator { get; set; }

        /// <summary>
        /// DomesticSingleNonPOSTransactionLimit
        /// </summary>
        /// <value>DomesticSingleNonPOSTransactionLimit</value>
        [DataMember(Name="nonPosTransactionLimitAmount", EmitDefaultValue=false)]
        public double? NonPosTransactionLimitAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomesticTransaction {\n");
            sb.Append("  AtmTransactionLimitToggleIndicator: ").Append(AtmTransactionLimitToggleIndicator).Append("\n");
            sb.Append("  AtmTransactionLimitAmount: ").Append(AtmTransactionLimitAmount).Append("\n");
            sb.Append("  ContactlessTxnLimitToggleIndicator: ").Append(ContactlessTxnLimitToggleIndicator).Append("\n");
            sb.Append("  ContactlessTransactionLimitAmount: ").Append(ContactlessTransactionLimitAmount).Append("\n");
            sb.Append("  ContactPosTxnLimitToggleIndicator: ").Append(ContactPosTxnLimitToggleIndicator).Append("\n");
            sb.Append("  ContactPosTransactionLimitAmount: ").Append(ContactPosTransactionLimitAmount).Append("\n");
            sb.Append("  NonPosTxnLimitToggleIndicator: ").Append(NonPosTxnLimitToggleIndicator).Append("\n");
            sb.Append("  NonPosTransactionLimitAmount: ").Append(NonPosTransactionLimitAmount).Append("\n");
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
            return this.Equals(input as DomesticTransaction);
        }

        /// <summary>
        /// Returns true if DomesticTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of DomesticTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomesticTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AtmTransactionLimitToggleIndicator == input.AtmTransactionLimitToggleIndicator ||
                    (this.AtmTransactionLimitToggleIndicator != null &&
                    this.AtmTransactionLimitToggleIndicator.Equals(input.AtmTransactionLimitToggleIndicator))
                ) && 
                (
                    this.AtmTransactionLimitAmount == input.AtmTransactionLimitAmount ||
                    (this.AtmTransactionLimitAmount != null &&
                    this.AtmTransactionLimitAmount.Equals(input.AtmTransactionLimitAmount))
                ) && 
                (
                    this.ContactlessTxnLimitToggleIndicator == input.ContactlessTxnLimitToggleIndicator ||
                    (this.ContactlessTxnLimitToggleIndicator != null &&
                    this.ContactlessTxnLimitToggleIndicator.Equals(input.ContactlessTxnLimitToggleIndicator))
                ) && 
                (
                    this.ContactlessTransactionLimitAmount == input.ContactlessTransactionLimitAmount ||
                    (this.ContactlessTransactionLimitAmount != null &&
                    this.ContactlessTransactionLimitAmount.Equals(input.ContactlessTransactionLimitAmount))
                ) && 
                (
                    this.ContactPosTxnLimitToggleIndicator == input.ContactPosTxnLimitToggleIndicator ||
                    (this.ContactPosTxnLimitToggleIndicator != null &&
                    this.ContactPosTxnLimitToggleIndicator.Equals(input.ContactPosTxnLimitToggleIndicator))
                ) && 
                (
                    this.ContactPosTransactionLimitAmount == input.ContactPosTransactionLimitAmount ||
                    (this.ContactPosTransactionLimitAmount != null &&
                    this.ContactPosTransactionLimitAmount.Equals(input.ContactPosTransactionLimitAmount))
                ) && 
                (
                    this.NonPosTxnLimitToggleIndicator == input.NonPosTxnLimitToggleIndicator ||
                    (this.NonPosTxnLimitToggleIndicator != null &&
                    this.NonPosTxnLimitToggleIndicator.Equals(input.NonPosTxnLimitToggleIndicator))
                ) && 
                (
                    this.NonPosTransactionLimitAmount == input.NonPosTransactionLimitAmount ||
                    (this.NonPosTransactionLimitAmount != null &&
                    this.NonPosTransactionLimitAmount.Equals(input.NonPosTransactionLimitAmount))
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
                if (this.AtmTransactionLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.AtmTransactionLimitToggleIndicator.GetHashCode();
                if (this.AtmTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.AtmTransactionLimitAmount.GetHashCode();
                if (this.ContactlessTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.ContactlessTxnLimitToggleIndicator.GetHashCode();
                if (this.ContactlessTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.ContactlessTransactionLimitAmount.GetHashCode();
                if (this.ContactPosTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.ContactPosTxnLimitToggleIndicator.GetHashCode();
                if (this.ContactPosTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.ContactPosTransactionLimitAmount.GetHashCode();
                if (this.NonPosTxnLimitToggleIndicator != null)
                    hashCode = hashCode * 59 + this.NonPosTxnLimitToggleIndicator.GetHashCode();
                if (this.NonPosTransactionLimitAmount != null)
                    hashCode = hashCode * 59 + this.NonPosTransactionLimitAmount.GetHashCode();
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