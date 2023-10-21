/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.BankDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
/**
 * LoanBookingRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanBookingRequest {
  @SerializedName("payeeId")
  private String payeeId = null;

  @SerializedName("loanAmount")
  private Double loanAmount = null;

  @SerializedName("disbursementOption")
  private String disbursementOption = null;

  @SerializedName("disbursementAccountId")
  private String disbursementAccountId = null;

  @SerializedName("tenor")
  private BigDecimal tenor = null;

  @SerializedName("bankDetails")
  private BankDetails bankDetails = null;

  @SerializedName("loanPurpose")
  private String loanPurpose = null;

  @SerializedName("remarks")
  private String remarks = null;

  @SerializedName("taxId")
  private String taxId = null;

  @SerializedName("paymentReferenceId")
  private String paymentReferenceId = null;

  public LoanBookingRequest payeeId(String payeeId) {
    this.payeeId = payeeId;
    return this;
  }

   /**
   * Unique identifier associated with the payee.Typically, this is not displayed to the customer.
   * @return payeeId
  **/
  @Schema(example = "C$0003019202$AU$XX$01000540000001", description = "Unique identifier associated with the payee.Typically, this is not displayed to the customer.")
  public String getPayeeId() {
    return payeeId;
  }

  public void setPayeeId(String payeeId) {
    this.payeeId = payeeId;
  }

  public LoanBookingRequest loanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
    return this;
  }

   /**
   * This field is to indicate the loan amount for booking.
   * @return loanAmount
  **/
  @Schema(example = "680.25", required = true, description = "This field is to indicate the loan amount for booking.")
  public Double getLoanAmount() {
    return loanAmount;
  }

  public void setLoanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
  }

  public LoanBookingRequest disbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
    return this;
  }

   /**
   * This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.
   * @return disbursementOption
  **/
  @Schema(example = "STANDING_INSTRUCTION", required = true, description = "This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.")
  public String getDisbursementOption() {
    return disbursementOption;
  }

  public void setDisbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
  }

  public LoanBookingRequest disbursementAccountId(String disbursementAccountId) {
    this.disbursementAccountId = disbursementAccountId;
    return this;
  }

   /**
   * The disbursement account identifier in encrypted format. Applicable only for HK.
   * @return disbursementAccountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The disbursement account identifier in encrypted format. Applicable only for HK.")
  public String getDisbursementAccountId() {
    return disbursementAccountId;
  }

  public void setDisbursementAccountId(String disbursementAccountId) {
    this.disbursementAccountId = disbursementAccountId;
  }

  public LoanBookingRequest tenor(BigDecimal tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenure of loan in months.
   * @return tenor
  **/
  @Schema(example = "6.0", required = true, description = "Tenure of loan in months.")
  public BigDecimal getTenor() {
    return tenor;
  }

  public void setTenor(BigDecimal tenor) {
    this.tenor = tenor;
  }

  public LoanBookingRequest bankDetails(BankDetails bankDetails) {
    this.bankDetails = bankDetails;
    return this;
  }

   /**
   * Get bankDetails
   * @return bankDetails
  **/
  @Schema(description = "")
  public BankDetails getBankDetails() {
    return bankDetails;
  }

  public void setBankDetails(BankDetails bankDetails) {
    this.bankDetails = bankDetails;
  }

  public LoanBookingRequest loanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
    return this;
  }

   /**
   * This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
   * @return loanPurpose
  **/
  @Schema(example = "PERSONAL", description = "This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.")
  public String getLoanPurpose() {
    return loanPurpose;
  }

  public void setLoanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
  }

  public LoanBookingRequest remarks(String remarks) {
    this.remarks = remarks;
    return this;
  }

   /**
   * Payment notes. Free text from screen
   * @return remarks
  **/
  @Schema(description = "Payment notes. Free text from screen")
  public String getRemarks() {
    return remarks;
  }

  public void setRemarks(String remarks) {
    this.remarks = remarks;
  }

  public LoanBookingRequest taxId(String taxId) {
    this.taxId = taxId;
    return this;
  }

   /**
   * Unique Tax ID of the Customer,INN Taxpayer&#x27;s identification code applicable for Russia
   * @return taxId
  **/
  @Schema(example = "123456", description = "Unique Tax ID of the Customer,INN Taxpayer's identification code applicable for Russia")
  public String getTaxId() {
    return taxId;
  }

  public void setTaxId(String taxId) {
    this.taxId = taxId;
  }

  public LoanBookingRequest paymentReferenceId(String paymentReferenceId) {
    this.paymentReferenceId = paymentReferenceId;
    return this;
  }

   /**
   * Reference number to uniquely identify the payment, applicable for Russia
   * @return paymentReferenceId
  **/
  @Schema(example = "123456", description = "Reference number to uniquely identify the payment, applicable for Russia")
  public String getPaymentReferenceId() {
    return paymentReferenceId;
  }

  public void setPaymentReferenceId(String paymentReferenceId) {
    this.paymentReferenceId = paymentReferenceId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanBookingRequest loanBookingRequest = (LoanBookingRequest) o;
    return Objects.equals(this.payeeId, loanBookingRequest.payeeId) &&
        Objects.equals(this.loanAmount, loanBookingRequest.loanAmount) &&
        Objects.equals(this.disbursementOption, loanBookingRequest.disbursementOption) &&
        Objects.equals(this.disbursementAccountId, loanBookingRequest.disbursementAccountId) &&
        Objects.equals(this.tenor, loanBookingRequest.tenor) &&
        Objects.equals(this.bankDetails, loanBookingRequest.bankDetails) &&
        Objects.equals(this.loanPurpose, loanBookingRequest.loanPurpose) &&
        Objects.equals(this.remarks, loanBookingRequest.remarks) &&
        Objects.equals(this.taxId, loanBookingRequest.taxId) &&
        Objects.equals(this.paymentReferenceId, loanBookingRequest.paymentReferenceId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(payeeId, loanAmount, disbursementOption, disbursementAccountId, tenor, bankDetails, loanPurpose, remarks, taxId, paymentReferenceId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanBookingRequest {\n");
    
    sb.append("    payeeId: ").append(toIndentedString(payeeId)).append("\n");
    sb.append("    loanAmount: ").append(toIndentedString(loanAmount)).append("\n");
    sb.append("    disbursementOption: ").append(toIndentedString(disbursementOption)).append("\n");
    sb.append("    disbursementAccountId: ").append(toIndentedString(disbursementAccountId)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
    sb.append("    bankDetails: ").append(toIndentedString(bankDetails)).append("\n");
    sb.append("    loanPurpose: ").append(toIndentedString(loanPurpose)).append("\n");
    sb.append("    remarks: ").append(toIndentedString(remarks)).append("\n");
    sb.append("    taxId: ").append(toIndentedString(taxId)).append("\n");
    sb.append("    paymentReferenceId: ").append(toIndentedString(paymentReferenceId)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}