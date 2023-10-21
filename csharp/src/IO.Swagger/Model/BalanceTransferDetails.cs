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
    /// BalanceTransferDetails
    /// </summary>
    [DataContract]
        public partial class BalanceTransferDetails :  IEquatable<BalanceTransferDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceTransferDetails" /> class.
        /// </summary>
        /// <param name="amountToTransfer">Amount to Transfer (required).</param>
        /// <param name="issuingOrganizationName">Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description..</param>
        /// <param name="accountName">Customer&#x27;s account Name.</param>
        /// <param name="accountReferenceNumber">Customer&#x27;s account reference number with biller..</param>
        /// <param name="billerCode">It is a unique code to identify a BPAY biller.</param>
        /// <param name="campaignId">Campaign code of the balance transfer..</param>
        /// <param name="paymentType">Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="bsbCode">BSB Code for EFT payment mode..</param>
        public BalanceTransferDetails(double? amountToTransfer = default(double?), string issuingOrganizationName = default(string), string accountName = default(string), string accountReferenceNumber = default(string), string billerCode = default(string), string campaignId = default(string), string paymentType = default(string), string bsbCode = default(string))
        {
            // to ensure "amountToTransfer" is required (not null)
            if (amountToTransfer == null)
            {
                throw new InvalidDataException("amountToTransfer is a required property for BalanceTransferDetails and cannot be null");
            }
            else
            {
                this.AmountToTransfer = amountToTransfer;
            }
            this.IssuingOrganizationName = issuingOrganizationName;
            this.AccountName = accountName;
            this.AccountReferenceNumber = accountReferenceNumber;
            this.BillerCode = billerCode;
            this.CampaignId = campaignId;
            this.PaymentType = paymentType;
            this.BsbCode = bsbCode;
        }
        
        /// <summary>
        /// Amount to Transfer
        /// </summary>
        /// <value>Amount to Transfer</value>
        [DataMember(Name="amountToTransfer", EmitDefaultValue=false)]
        public double? AmountToTransfer { get; set; }

        /// <summary>
        /// Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description.</value>
        [DataMember(Name="issuingOrganizationName", EmitDefaultValue=false)]
        public string IssuingOrganizationName { get; set; }

        /// <summary>
        /// Customer&#x27;s account Name
        /// </summary>
        /// <value>Customer&#x27;s account Name</value>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Customer&#x27;s account reference number with biller.
        /// </summary>
        /// <value>Customer&#x27;s account reference number with biller.</value>
        [DataMember(Name="accountReferenceNumber", EmitDefaultValue=false)]
        public string AccountReferenceNumber { get; set; }

        /// <summary>
        /// It is a unique code to identify a BPAY biller
        /// </summary>
        /// <value>It is a unique code to identify a BPAY biller</value>
        [DataMember(Name="billerCode", EmitDefaultValue=false)]
        public string BillerCode { get; set; }

        /// <summary>
        /// Campaign code of the balance transfer.
        /// </summary>
        /// <value>Campaign code of the balance transfer.</value>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// BSB Code for EFT payment mode.
        /// </summary>
        /// <value>BSB Code for EFT payment mode.</value>
        [DataMember(Name="bsbCode", EmitDefaultValue=false)]
        public string BsbCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BalanceTransferDetails {\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
            sb.Append("  IssuingOrganizationName: ").Append(IssuingOrganizationName).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountReferenceNumber: ").Append(AccountReferenceNumber).Append("\n");
            sb.Append("  BillerCode: ").Append(BillerCode).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  BsbCode: ").Append(BsbCode).Append("\n");
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
            return this.Equals(input as BalanceTransferDetails);
        }

        /// <summary>
        /// Returns true if BalanceTransferDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BalanceTransferDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BalanceTransferDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmountToTransfer == input.AmountToTransfer ||
                    (this.AmountToTransfer != null &&
                    this.AmountToTransfer.Equals(input.AmountToTransfer))
                ) && 
                (
                    this.IssuingOrganizationName == input.IssuingOrganizationName ||
                    (this.IssuingOrganizationName != null &&
                    this.IssuingOrganizationName.Equals(input.IssuingOrganizationName))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountReferenceNumber == input.AccountReferenceNumber ||
                    (this.AccountReferenceNumber != null &&
                    this.AccountReferenceNumber.Equals(input.AccountReferenceNumber))
                ) && 
                (
                    this.BillerCode == input.BillerCode ||
                    (this.BillerCode != null &&
                    this.BillerCode.Equals(input.BillerCode))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.BsbCode == input.BsbCode ||
                    (this.BsbCode != null &&
                    this.BsbCode.Equals(input.BsbCode))
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
                if (this.AmountToTransfer != null)
                    hashCode = hashCode * 59 + this.AmountToTransfer.GetHashCode();
                if (this.IssuingOrganizationName != null)
                    hashCode = hashCode * 59 + this.IssuingOrganizationName.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountReferenceNumber != null)
                    hashCode = hashCode * 59 + this.AccountReferenceNumber.GetHashCode();
                if (this.BillerCode != null)
                    hashCode = hashCode * 59 + this.BillerCode.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.BsbCode != null)
                    hashCode = hashCode * 59 + this.BsbCode.GetHashCode();
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
