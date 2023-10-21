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
    /// AdhocExternalDmstcSrcAcctEligibilityResponse
    /// </summary>
    [DataContract]
        public partial class AdhocExternalDmstcSrcAcctEligibilityResponse :  IEquatable<AdhocExternalDmstcSrcAcctEligibilityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdhocExternalDmstcSrcAcctEligibilityResponse" /> class.
        /// </summary>
        /// <param name="sourceAccounts">sourceAccounts (required).</param>
        /// <param name="nextStartIndex">In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data..</param>
        public AdhocExternalDmstcSrcAcctEligibilityResponse(List<SourceAccounts> sourceAccounts = default(List<SourceAccounts>), string nextStartIndex = default(string))
        {
            // to ensure "sourceAccounts" is required (not null)
            if (sourceAccounts == null)
            {
                throw new InvalidDataException("sourceAccounts is a required property for AdhocExternalDmstcSrcAcctEligibilityResponse and cannot be null");
            }
            else
            {
                this.SourceAccounts = sourceAccounts;
            }
            this.NextStartIndex = nextStartIndex;
        }
        
        /// <summary>
        /// Gets or Sets SourceAccounts
        /// </summary>
        [DataMember(Name="sourceAccounts", EmitDefaultValue=false)]
        public List<SourceAccounts> SourceAccounts { get; set; }

        /// <summary>
        /// In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
        /// </summary>
        /// <value>In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.</value>
        [DataMember(Name="nextStartIndex", EmitDefaultValue=false)]
        public string NextStartIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdhocExternalDmstcSrcAcctEligibilityResponse {\n");
            sb.Append("  SourceAccounts: ").Append(SourceAccounts).Append("\n");
            sb.Append("  NextStartIndex: ").Append(NextStartIndex).Append("\n");
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
            return this.Equals(input as AdhocExternalDmstcSrcAcctEligibilityResponse);
        }

        /// <summary>
        /// Returns true if AdhocExternalDmstcSrcAcctEligibilityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdhocExternalDmstcSrcAcctEligibilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdhocExternalDmstcSrcAcctEligibilityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceAccounts == input.SourceAccounts ||
                    this.SourceAccounts != null &&
                    input.SourceAccounts != null &&
                    this.SourceAccounts.SequenceEqual(input.SourceAccounts)
                ) && 
                (
                    this.NextStartIndex == input.NextStartIndex ||
                    (this.NextStartIndex != null &&
                    this.NextStartIndex.Equals(input.NextStartIndex))
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
                if (this.SourceAccounts != null)
                    hashCode = hashCode * 59 + this.SourceAccounts.GetHashCode();
                if (this.NextStartIndex != null)
                    hashCode = hashCode * 59 + this.NextStartIndex.GetHashCode();
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
