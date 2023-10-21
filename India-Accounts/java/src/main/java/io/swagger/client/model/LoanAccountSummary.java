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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * LoanAccountSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanAccountSummary {
  @SerializedName("productName")
  private String productName = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("accountNickname")
  private String accountNickname = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("accountClassification")
  private String accountClassification = null;

  @SerializedName("accountStatus")
  private String accountStatus = null;

  @SerializedName("originalPrincipalAmount")
  private Double originalPrincipalAmount = null;

  @SerializedName("outstandingBalance")
  private Double outstandingBalance = null;

  @SerializedName("nextPaymentAmount")
  private Double nextPaymentAmount = null;

  @SerializedName("nextPaymentDate")
  private LocalDate nextPaymentDate = null;

  public LoanAccountSummary productName(String productName) {
    this.productName = productName;
    return this;
  }

   /**
   * The name of the product
   * @return productName
  **/
  @Schema(example = "Personal Loan Account", description = "The name of the product")
  public String getProductName() {
    return productName;
  }

  public void setProductName(String productName) {
    this.productName = productName;
  }

  public LoanAccountSummary productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "PL_001", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public LoanAccountSummary accountNickname(String accountNickname) {
    this.accountNickname = accountNickname;
    return this;
  }

   /**
   * The nickname of the account assigned by the customer
   * @return accountNickname
  **/
  @Schema(example = "Personal Loan Account", description = "The nickname of the account assigned by the customer")
  public String getAccountNickname() {
    return accountNickname;
  }

  public void setAccountNickname(String accountNickname) {
    this.accountNickname = accountNickname;
  }

  public LoanAccountSummary displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2391", description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public LoanAccountSummary accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The customer account identifier in encrypted format.
   * @return accountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The customer account identifier in encrypted format.")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public LoanAccountSummary currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "AUD", description = "The currency code in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public LoanAccountSummary accountClassification(String accountClassification) {
    this.accountClassification = accountClassification;
    return this;
  }

   /**
   * Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return accountClassification
  **/
  @Schema(example = "LIABILITY", description = "Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getAccountClassification() {
    return accountClassification;
  }

  public void setAccountClassification(String accountClassification) {
    this.accountClassification = accountClassification;
  }

  public LoanAccountSummary accountStatus(String accountStatus) {
    this.accountStatus = accountStatus;
    return this;
  }

   /**
   * Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return accountStatus
  **/
  @Schema(example = "ACTIVE", description = "Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getAccountStatus() {
    return accountStatus;
  }

  public void setAccountStatus(String accountStatus) {
    this.accountStatus = accountStatus;
  }

  public LoanAccountSummary originalPrincipalAmount(Double originalPrincipalAmount) {
    this.originalPrincipalAmount = originalPrincipalAmount;
    return this;
  }

   /**
   * The amount borrowed
   * @return originalPrincipalAmount
  **/
  @Schema(example = "10000.25", description = "The amount borrowed")
  public Double getOriginalPrincipalAmount() {
    return originalPrincipalAmount;
  }

  public void setOriginalPrincipalAmount(Double originalPrincipalAmount) {
    this.originalPrincipalAmount = originalPrincipalAmount;
  }

  public LoanAccountSummary outstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
    return this;
  }

   /**
   * The amount of money owed.
   * @return outstandingBalance
  **/
  @Schema(example = "15000.25", description = "The amount of money owed.")
  public Double getOutstandingBalance() {
    return outstandingBalance;
  }

  public void setOutstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
  }

  public LoanAccountSummary nextPaymentAmount(Double nextPaymentAmount) {
    this.nextPaymentAmount = nextPaymentAmount;
    return this;
  }

   /**
   * The next payment amount due
   * @return nextPaymentAmount
  **/
  @Schema(example = "9230.67", description = "The next payment amount due")
  public Double getNextPaymentAmount() {
    return nextPaymentAmount;
  }

  public void setNextPaymentAmount(Double nextPaymentAmount) {
    this.nextPaymentAmount = nextPaymentAmount;
  }

  public LoanAccountSummary nextPaymentDate(LocalDate nextPaymentDate) {
    this.nextPaymentDate = nextPaymentDate;
    return this;
  }

   /**
   * The date of the next payment in ISO 8601 date format YYYY-MM-DD
   * @return nextPaymentDate
  **/
  @Schema(example = "Wed Jun 13 00:00:00 UTC 2018", description = "The date of the next payment in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getNextPaymentDate() {
    return nextPaymentDate;
  }

  public void setNextPaymentDate(LocalDate nextPaymentDate) {
    this.nextPaymentDate = nextPaymentDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanAccountSummary loanAccountSummary = (LoanAccountSummary) o;
    return Objects.equals(this.productName, loanAccountSummary.productName) &&
        Objects.equals(this.productCode, loanAccountSummary.productCode) &&
        Objects.equals(this.accountNickname, loanAccountSummary.accountNickname) &&
        Objects.equals(this.displayAccountNumber, loanAccountSummary.displayAccountNumber) &&
        Objects.equals(this.accountId, loanAccountSummary.accountId) &&
        Objects.equals(this.currencyCode, loanAccountSummary.currencyCode) &&
        Objects.equals(this.accountClassification, loanAccountSummary.accountClassification) &&
        Objects.equals(this.accountStatus, loanAccountSummary.accountStatus) &&
        Objects.equals(this.originalPrincipalAmount, loanAccountSummary.originalPrincipalAmount) &&
        Objects.equals(this.outstandingBalance, loanAccountSummary.outstandingBalance) &&
        Objects.equals(this.nextPaymentAmount, loanAccountSummary.nextPaymentAmount) &&
        Objects.equals(this.nextPaymentDate, loanAccountSummary.nextPaymentDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productName, productCode, accountNickname, displayAccountNumber, accountId, currencyCode, accountClassification, accountStatus, originalPrincipalAmount, outstandingBalance, nextPaymentAmount, nextPaymentDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanAccountSummary {\n");
    
    sb.append("    productName: ").append(toIndentedString(productName)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    accountNickname: ").append(toIndentedString(accountNickname)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    accountClassification: ").append(toIndentedString(accountClassification)).append("\n");
    sb.append("    accountStatus: ").append(toIndentedString(accountStatus)).append("\n");
    sb.append("    originalPrincipalAmount: ").append(toIndentedString(originalPrincipalAmount)).append("\n");
    sb.append("    outstandingBalance: ").append(toIndentedString(outstandingBalance)).append("\n");
    sb.append("    nextPaymentAmount: ").append(toIndentedString(nextPaymentAmount)).append("\n");
    sb.append("    nextPaymentDate: ").append(toIndentedString(nextPaymentDate)).append("\n");
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
