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
    /// SourceAccountsCrossBorderWireTransfer
    /// </summary>
    [DataContract]
        public partial class SourceAccountsCrossBorderWireTransfer :  IEquatable<SourceAccountsCrossBorderWireTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceAccountsCrossBorderWireTransfer" /> class.
        /// </summary>
        /// <param name="sourceAccountId">The primary identifier for ownership of an account.The source account identifier in encrypted format.Typically, this is not displayed to the customer,use displayAccountNumber instead. (required).</param>
        /// <param name="displaySourceAccountNumber">A masked account number that can be displayed to the customer (required).</param>
        /// <param name="productName">The name of the product.</param>
        /// <param name="sourceAccountCurrencyCode">The currency code of the source account in ISO 4217 format (required).</param>
        /// <param name="accountNickname">The nickname of the account assigned by the customer.</param>
        /// <param name="accountGroup">Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. (required).</param>
        /// <param name="availableBalance">The available balance including any pending or in progress deposits and withdrawals.</param>
        public SourceAccountsCrossBorderWireTransfer(string sourceAccountId = default(string), string displaySourceAccountNumber = default(string), string productName = default(string), string sourceAccountCurrencyCode = default(string), string accountNickname = default(string), string accountGroup = default(string), double? availableBalance = default(double?))
        {
            // to ensure "sourceAccountId" is required (not null)
            if (sourceAccountId == null)
            {
                throw new InvalidDataException("sourceAccountId is a required property for SourceAccountsCrossBorderWireTransfer and cannot be null");
            }
            else
            {
                this.SourceAccountId = sourceAccountId;
            }
            // to ensure "displaySourceAccountNumber" is required (not null)
            if (displaySourceAccountNumber == null)
            {
                throw new InvalidDataException("displaySourceAccountNumber is a required property for SourceAccountsCrossBorderWireTransfer and cannot be null");
            }
            else
            {
                this.DisplaySourceAccountNumber = displaySourceAccountNumber;
            }
            // to ensure "sourceAccountCurrencyCode" is required (not null)
            if (sourceAccountCurrencyCode == null)
            {
                throw new InvalidDataException("sourceAccountCurrencyCode is a required property for SourceAccountsCrossBorderWireTransfer and cannot be null");
            }
            else
            {
                this.SourceAccountCurrencyCode = sourceAccountCurrencyCode;
            }
            // to ensure "accountGroup" is required (not null)
            if (accountGroup == null)
            {
                throw new InvalidDataException("accountGroup is a required property for SourceAccountsCrossBorderWireTransfer and cannot be null");
            }
            else
            {
                this.AccountGroup = accountGroup;
            }
            this.ProductName = productName;
            this.AccountNickname = accountNickname;
            this.AvailableBalance = availableBalance;
        }
        
        /// <summary>
        /// The primary identifier for ownership of an account.The source account identifier in encrypted format.Typically, this is not displayed to the customer,use displayAccountNumber instead.
        /// </summary>
        /// <value>The primary identifier for ownership of an account.The source account identifier in encrypted format.Typically, this is not displayed to the customer,use displayAccountNumber instead.</value>
        [DataMember(Name="sourceAccountId", EmitDefaultValue=false)]
        public string SourceAccountId { get; set; }

        /// <summary>
        /// A masked account number that can be displayed to the customer
        /// </summary>
        /// <value>A masked account number that can be displayed to the customer</value>
        [DataMember(Name="displaySourceAccountNumber", EmitDefaultValue=false)]
        public string DisplaySourceAccountNumber { get; set; }

        /// <summary>
        /// The name of the product
        /// </summary>
        /// <value>The name of the product</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// The currency code of the source account in ISO 4217 format
        /// </summary>
        /// <value>The currency code of the source account in ISO 4217 format</value>
        [DataMember(Name="sourceAccountCurrencyCode", EmitDefaultValue=false)]
        public string SourceAccountCurrencyCode { get; set; }

        /// <summary>
        /// The nickname of the account assigned by the customer
        /// </summary>
        /// <value>The nickname of the account assigned by the customer</value>
        [DataMember(Name="accountNickname", EmitDefaultValue=false)]
        public string AccountNickname { get; set; }

        /// <summary>
        /// Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description.</value>
        [DataMember(Name="accountGroup", EmitDefaultValue=false)]
        public string AccountGroup { get; set; }

        /// <summary>
        /// The available balance including any pending or in progress deposits and withdrawals
        /// </summary>
        /// <value>The available balance including any pending or in progress deposits and withdrawals</value>
        [DataMember(Name="availableBalance", EmitDefaultValue=false)]
        public double? AvailableBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceAccountsCrossBorderWireTransfer {\n");
            sb.Append("  SourceAccountId: ").Append(SourceAccountId).Append("\n");
            sb.Append("  DisplaySourceAccountNumber: ").Append(DisplaySourceAccountNumber).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  SourceAccountCurrencyCode: ").Append(SourceAccountCurrencyCode).Append("\n");
            sb.Append("  AccountNickname: ").Append(AccountNickname).Append("\n");
            sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
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
            return this.Equals(input as SourceAccountsCrossBorderWireTransfer);
        }

        /// <summary>
        /// Returns true if SourceAccountsCrossBorderWireTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceAccountsCrossBorderWireTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceAccountsCrossBorderWireTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAccountId == input.SourceAccountId ||
                    (this.SourceAccountId != null &&
                    this.SourceAccountId.Equals(input.SourceAccountId))
                ) && 
                (
                    this.DisplaySourceAccountNumber == input.DisplaySourceAccountNumber ||
                    (this.DisplaySourceAccountNumber != null &&
                    this.DisplaySourceAccountNumber.Equals(input.DisplaySourceAccountNumber))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.SourceAccountCurrencyCode == input.SourceAccountCurrencyCode ||
                    (this.SourceAccountCurrencyCode != null &&
                    this.SourceAccountCurrencyCode.Equals(input.SourceAccountCurrencyCode))
                ) && 
                (
                    this.AccountNickname == input.AccountNickname ||
                    (this.AccountNickname != null &&
                    this.AccountNickname.Equals(input.AccountNickname))
                ) && 
                (
                    this.AccountGroup == input.AccountGroup ||
                    (this.AccountGroup != null &&
                    this.AccountGroup.Equals(input.AccountGroup))
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    (this.AvailableBalance != null &&
                    this.AvailableBalance.Equals(input.AvailableBalance))
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
                if (this.SourceAccountId != null)
                    hashCode = hashCode * 59 + this.SourceAccountId.GetHashCode();
                if (this.DisplaySourceAccountNumber != null)
                    hashCode = hashCode * 59 + this.DisplaySourceAccountNumber.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.SourceAccountCurrencyCode != null)
                    hashCode = hashCode * 59 + this.SourceAccountCurrencyCode.GetHashCode();
                if (this.AccountNickname != null)
                    hashCode = hashCode * 59 + this.AccountNickname.GetHashCode();
                if (this.AccountGroup != null)
                    hashCode = hashCode * 59 + this.AccountGroup.GetHashCode();
                if (this.AvailableBalance != null)
                    hashCode = hashCode * 59 + this.AvailableBalance.GetHashCode();
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
