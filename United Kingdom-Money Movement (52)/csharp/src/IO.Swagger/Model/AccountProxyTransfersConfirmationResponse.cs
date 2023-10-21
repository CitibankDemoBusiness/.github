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
    /// AccountProxyTransfersConfirmationResponse
    /// </summary>
    [DataContract]
        public partial class AccountProxyTransfersConfirmationResponse :  IEquatable<AccountProxyTransfersConfirmationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProxyTransfersConfirmationResponse" /> class.
        /// </summary>
        /// <param name="sourceAccount">sourceAccount (required).</param>
        /// <param name="transactionReferenceId">The unique transaction reference Id used to identify this transaction from all the other transactions (required).</param>
        /// <param name="payeeEnrollmentStatus">Status to indicate if the payee is added or not to customers registered list of billers. This is a reference data. Please use /v1/utilities/referenceData/{payeeEnrollmentStatus} resource to get valid value of this field..</param>
        public AccountProxyTransfersConfirmationResponse(SourceAccount sourceAccount = default(SourceAccount), string transactionReferenceId = default(string), string payeeEnrollmentStatus = default(string))
        {
            // to ensure "sourceAccount" is required (not null)
            if (sourceAccount == null)
            {
                throw new InvalidDataException("sourceAccount is a required property for AccountProxyTransfersConfirmationResponse and cannot be null");
            }
            else
            {
                this.SourceAccount = sourceAccount;
            }
            // to ensure "transactionReferenceId" is required (not null)
            if (transactionReferenceId == null)
            {
                throw new InvalidDataException("transactionReferenceId is a required property for AccountProxyTransfersConfirmationResponse and cannot be null");
            }
            else
            {
                this.TransactionReferenceId = transactionReferenceId;
            }
            this.PayeeEnrollmentStatus = payeeEnrollmentStatus;
        }
        
        /// <summary>
        /// Gets or Sets SourceAccount
        /// </summary>
        [DataMember(Name="sourceAccount", EmitDefaultValue=false)]
        public SourceAccount SourceAccount { get; set; }

        /// <summary>
        /// The unique transaction reference Id used to identify this transaction from all the other transactions
        /// </summary>
        /// <value>The unique transaction reference Id used to identify this transaction from all the other transactions</value>
        [DataMember(Name="transactionReferenceId", EmitDefaultValue=false)]
        public string TransactionReferenceId { get; set; }

        /// <summary>
        /// Status to indicate if the payee is added or not to customers registered list of billers. This is a reference data. Please use /v1/utilities/referenceData/{payeeEnrollmentStatus} resource to get valid value of this field.
        /// </summary>
        /// <value>Status to indicate if the payee is added or not to customers registered list of billers. This is a reference data. Please use /v1/utilities/referenceData/{payeeEnrollmentStatus} resource to get valid value of this field.</value>
        [DataMember(Name="payeeEnrollmentStatus", EmitDefaultValue=false)]
        public string PayeeEnrollmentStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountProxyTransfersConfirmationResponse {\n");
            sb.Append("  SourceAccount: ").Append(SourceAccount).Append("\n");
            sb.Append("  TransactionReferenceId: ").Append(TransactionReferenceId).Append("\n");
            sb.Append("  PayeeEnrollmentStatus: ").Append(PayeeEnrollmentStatus).Append("\n");
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
            return this.Equals(input as AccountProxyTransfersConfirmationResponse);
        }

        /// <summary>
        /// Returns true if AccountProxyTransfersConfirmationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountProxyTransfersConfirmationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountProxyTransfersConfirmationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAccount == input.SourceAccount ||
                    (this.SourceAccount != null &&
                    this.SourceAccount.Equals(input.SourceAccount))
                ) && 
                (
                    this.TransactionReferenceId == input.TransactionReferenceId ||
                    (this.TransactionReferenceId != null &&
                    this.TransactionReferenceId.Equals(input.TransactionReferenceId))
                ) && 
                (
                    this.PayeeEnrollmentStatus == input.PayeeEnrollmentStatus ||
                    (this.PayeeEnrollmentStatus != null &&
                    this.PayeeEnrollmentStatus.Equals(input.PayeeEnrollmentStatus))
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
                if (this.SourceAccount != null)
                    hashCode = hashCode * 59 + this.SourceAccount.GetHashCode();
                if (this.TransactionReferenceId != null)
                    hashCode = hashCode * 59 + this.TransactionReferenceId.GetHashCode();
                if (this.PayeeEnrollmentStatus != null)
                    hashCode = hashCode * 59 + this.PayeeEnrollmentStatus.GetHashCode();
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
