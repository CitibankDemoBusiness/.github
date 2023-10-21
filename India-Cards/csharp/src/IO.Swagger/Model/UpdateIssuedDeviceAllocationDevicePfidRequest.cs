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
    /// UpdateIssuedDeviceAllocationDevicePfidRequest
    /// </summary>
    [DataContract]
        public partial class UpdateIssuedDeviceAllocationDevicePfidRequest :  IEquatable<UpdateIssuedDeviceAllocationDevicePfidRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIssuedDeviceAllocationDevicePfidRequest" /> class.
        /// </summary>
        /// <param name="requestTimestamp">Date time in MMDDYYYYHHMMSS Format. (required).</param>
        /// <param name="cardReferenceId">Card reference Id (RFID). It is generated by ECS against card number.$$M (required).</param>
        /// <param name="paymentFinancialInstrumentId">Payment financial instrument Id (PFID). It is generated by partner against RFID+CardNumber.$$M (required).</param>
        public UpdateIssuedDeviceAllocationDevicePfidRequest(int? requestTimestamp = default(int?), string cardReferenceId = default(string), string paymentFinancialInstrumentId = default(string))
        {
            // to ensure "requestTimestamp" is required (not null)
            if (requestTimestamp == null)
            {
                throw new InvalidDataException("requestTimestamp is a required property for UpdateIssuedDeviceAllocationDevicePfidRequest and cannot be null");
            }
            else
            {
                this.RequestTimestamp = requestTimestamp;
            }
            // to ensure "cardReferenceId" is required (not null)
            if (cardReferenceId == null)
            {
                throw new InvalidDataException("cardReferenceId is a required property for UpdateIssuedDeviceAllocationDevicePfidRequest and cannot be null");
            }
            else
            {
                this.CardReferenceId = cardReferenceId;
            }
            // to ensure "paymentFinancialInstrumentId" is required (not null)
            if (paymentFinancialInstrumentId == null)
            {
                throw new InvalidDataException("paymentFinancialInstrumentId is a required property for UpdateIssuedDeviceAllocationDevicePfidRequest and cannot be null");
            }
            else
            {
                this.PaymentFinancialInstrumentId = paymentFinancialInstrumentId;
            }
        }
        
        /// <summary>
        /// Date time in MMDDYYYYHHMMSS Format.
        /// </summary>
        /// <value>Date time in MMDDYYYYHHMMSS Format.</value>
        [DataMember(Name="requestTimestamp", EmitDefaultValue=false)]
        public int? RequestTimestamp { get; set; }

        /// <summary>
        /// Card reference Id (RFID). It is generated by ECS against card number.$$M
        /// </summary>
        /// <value>Card reference Id (RFID). It is generated by ECS against card number.$$M</value>
        [DataMember(Name="cardReferenceId", EmitDefaultValue=false)]
        public string CardReferenceId { get; set; }

        /// <summary>
        /// Payment financial instrument Id (PFID). It is generated by partner against RFID+CardNumber.$$M
        /// </summary>
        /// <value>Payment financial instrument Id (PFID). It is generated by partner against RFID+CardNumber.$$M</value>
        [DataMember(Name="paymentFinancialInstrumentId", EmitDefaultValue=false)]
        public string PaymentFinancialInstrumentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateIssuedDeviceAllocationDevicePfidRequest {\n");
            sb.Append("  RequestTimestamp: ").Append(RequestTimestamp).Append("\n");
            sb.Append("  CardReferenceId: ").Append(CardReferenceId).Append("\n");
            sb.Append("  PaymentFinancialInstrumentId: ").Append(PaymentFinancialInstrumentId).Append("\n");
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
            return this.Equals(input as UpdateIssuedDeviceAllocationDevicePfidRequest);
        }

        /// <summary>
        /// Returns true if UpdateIssuedDeviceAllocationDevicePfidRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateIssuedDeviceAllocationDevicePfidRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateIssuedDeviceAllocationDevicePfidRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestTimestamp == input.RequestTimestamp ||
                    (this.RequestTimestamp != null &&
                    this.RequestTimestamp.Equals(input.RequestTimestamp))
                ) && 
                (
                    this.CardReferenceId == input.CardReferenceId ||
                    (this.CardReferenceId != null &&
                    this.CardReferenceId.Equals(input.CardReferenceId))
                ) && 
                (
                    this.PaymentFinancialInstrumentId == input.PaymentFinancialInstrumentId ||
                    (this.PaymentFinancialInstrumentId != null &&
                    this.PaymentFinancialInstrumentId.Equals(input.PaymentFinancialInstrumentId))
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
                if (this.RequestTimestamp != null)
                    hashCode = hashCode * 59 + this.RequestTimestamp.GetHashCode();
                if (this.CardReferenceId != null)
                    hashCode = hashCode * 59 + this.CardReferenceId.GetHashCode();
                if (this.PaymentFinancialInstrumentId != null)
                    hashCode = hashCode * 59 + this.PaymentFinancialInstrumentId.GetHashCode();
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