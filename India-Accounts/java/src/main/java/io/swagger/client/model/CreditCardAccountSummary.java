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
 * CreditCardAccountSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class CreditCardAccountSummary {
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

  @SerializedName("outstandingBalance")
  private Double outstandingBalance = null;

  @SerializedName("availableCredit")
  private Double availableCredit = null;

  @SerializedName("creditLimit")
  private Double creditLimit = null;

  @SerializedName("minimumDueAmount")
  private Double minimumDueAmount = null;

  @SerializedName("paymentDueDate")
  private LocalDate paymentDueDate = null;

  @SerializedName("alternateCurrency")
  private String alternateCurrency = null;

  @SerializedName("alternateCurrencyCurrentBalance")
  private Double alternateCurrencyCurrentBalance = null;

  @SerializedName("cardHolderType")
  private String cardHolderType = null;

  public CreditCardAccountSummary productName(String productName) {
    this.productName = productName;
    return this;
  }

   /**
   * The name of the product
   * @return productName
  **/
  @Schema(example = "Citibank Platinum Visa", description = "The name of the product")
  public String getProductName() {
    return productName;
  }

  public void setProductName(String productName) {
    this.productName = productName;
  }

  public CreditCardAccountSummary productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "0071_VC301", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public CreditCardAccountSummary accountNickname(String accountNickname) {
    this.accountNickname = accountNickname;
    return this;
  }

   /**
   * The nickname of the account assigned by the customer
   * @return accountNickname
  **/
  @Schema(example = "Credit Card Account for My Travels", description = "The nickname of the account assigned by the customer")
  public String getAccountNickname() {
    return accountNickname;
  }

  public void setAccountNickname(String accountNickname) {
    this.accountNickname = accountNickname;
  }

  public CreditCardAccountSummary displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXXXXXXXX0364", description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public CreditCardAccountSummary accountId(String accountId) {
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

  public CreditCardAccountSummary currencyCode(String currencyCode) {
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

  public CreditCardAccountSummary accountClassification(String accountClassification) {
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

  public CreditCardAccountSummary accountStatus(String accountStatus) {
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

  public CreditCardAccountSummary outstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
    return this;
  }

   /**
   * The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels)
   * @return outstandingBalance
  **/
  @Schema(example = "10000.25", description = "The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels)")
  public Double getOutstandingBalance() {
    return outstandingBalance;
  }

  public void setOutstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
  }

  public CreditCardAccountSummary availableCredit(Double availableCredit) {
    this.availableCredit = availableCredit;
    return this;
  }

   /**
   * Available Credit limit on the credit card
   * @return availableCredit
  **/
  @Schema(example = "15000.25", description = "Available Credit limit on the credit card")
  public Double getAvailableCredit() {
    return availableCredit;
  }

  public void setAvailableCredit(Double availableCredit) {
    this.availableCredit = availableCredit;
  }

  public CreditCardAccountSummary creditLimit(Double creditLimit) {
    this.creditLimit = creditLimit;
    return this;
  }

   /**
   * The maximum amount of credit that extend to a customer
   * @return creditLimit
  **/
  @Schema(example = "25000.25", description = "The maximum amount of credit that extend to a customer")
  public Double getCreditLimit() {
    return creditLimit;
  }

  public void setCreditLimit(Double creditLimit) {
    this.creditLimit = creditLimit;
  }

  public CreditCardAccountSummary minimumDueAmount(Double minimumDueAmount) {
    this.minimumDueAmount = minimumDueAmount;
    return this;
  }

   /**
   * Minimum due amount for a payment cycle
   * @return minimumDueAmount
  **/
  @Schema(example = "256.5", description = "Minimum due amount for a payment cycle")
  public Double getMinimumDueAmount() {
    return minimumDueAmount;
  }

  public void setMinimumDueAmount(Double minimumDueAmount) {
    this.minimumDueAmount = minimumDueAmount;
  }

  public CreditCardAccountSummary paymentDueDate(LocalDate paymentDueDate) {
    this.paymentDueDate = paymentDueDate;
    return this;
  }

   /**
   * The payment due date in ISO 8601 date format YYYY-MM-DD
   * @return paymentDueDate
  **/
  @Schema(example = "Wed Oct 05 00:00:00 UTC 2016", description = "The payment due date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getPaymentDueDate() {
    return paymentDueDate;
  }

  public void setPaymentDueDate(LocalDate paymentDueDate) {
    this.paymentDueDate = paymentDueDate;
  }

  public CreditCardAccountSummary alternateCurrency(String alternateCurrency) {
    this.alternateCurrency = alternateCurrency;
    return this;
  }

   /**
   * The alternate currency
   * @return alternateCurrency
  **/
  @Schema(example = "USD", description = "The alternate currency")
  public String getAlternateCurrency() {
    return alternateCurrency;
  }

  public void setAlternateCurrency(String alternateCurrency) {
    this.alternateCurrency = alternateCurrency;
  }

  public CreditCardAccountSummary alternateCurrencyCurrentBalance(Double alternateCurrencyCurrentBalance) {
    this.alternateCurrencyCurrentBalance = alternateCurrencyCurrentBalance;
    return this;
  }

   /**
   * The current balance in alternate currency
   * @return alternateCurrencyCurrentBalance
  **/
  @Schema(example = "1534.25", description = "The current balance in alternate currency")
  public Double getAlternateCurrencyCurrentBalance() {
    return alternateCurrencyCurrentBalance;
  }

  public void setAlternateCurrencyCurrentBalance(Double alternateCurrencyCurrentBalance) {
    this.alternateCurrencyCurrentBalance = alternateCurrencyCurrentBalance;
  }

  public CreditCardAccountSummary cardHolderType(String cardHolderType) {
    this.cardHolderType = cardHolderType;
    return this;
  }

   /**
   * Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description.
   * @return cardHolderType
  **/
  @Schema(example = "PRIMARY", description = "Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description.")
  public String getCardHolderType() {
    return cardHolderType;
  }

  public void setCardHolderType(String cardHolderType) {
    this.cardHolderType = cardHolderType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreditCardAccountSummary creditCardAccountSummary = (CreditCardAccountSummary) o;
    return Objects.equals(this.productName, creditCardAccountSummary.productName) &&
        Objects.equals(this.productCode, creditCardAccountSummary.productCode) &&
        Objects.equals(this.accountNickname, creditCardAccountSummary.accountNickname) &&
        Objects.equals(this.displayAccountNumber, creditCardAccountSummary.displayAccountNumber) &&
        Objects.equals(this.accountId, creditCardAccountSummary.accountId) &&
        Objects.equals(this.currencyCode, creditCardAccountSummary.currencyCode) &&
        Objects.equals(this.accountClassification, creditCardAccountSummary.accountClassification) &&
        Objects.equals(this.accountStatus, creditCardAccountSummary.accountStatus) &&
        Objects.equals(this.outstandingBalance, creditCardAccountSummary.outstandingBalance) &&
        Objects.equals(this.availableCredit, creditCardAccountSummary.availableCredit) &&
        Objects.equals(this.creditLimit, creditCardAccountSummary.creditLimit) &&
        Objects.equals(this.minimumDueAmount, creditCardAccountSummary.minimumDueAmount) &&
        Objects.equals(this.paymentDueDate, creditCardAccountSummary.paymentDueDate) &&
        Objects.equals(this.alternateCurrency, creditCardAccountSummary.alternateCurrency) &&
        Objects.equals(this.alternateCurrencyCurrentBalance, creditCardAccountSummary.alternateCurrencyCurrentBalance) &&
        Objects.equals(this.cardHolderType, creditCardAccountSummary.cardHolderType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productName, productCode, accountNickname, displayAccountNumber, accountId, currencyCode, accountClassification, accountStatus, outstandingBalance, availableCredit, creditLimit, minimumDueAmount, paymentDueDate, alternateCurrency, alternateCurrencyCurrentBalance, cardHolderType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreditCardAccountSummary {\n");
    
    sb.append("    productName: ").append(toIndentedString(productName)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    accountNickname: ").append(toIndentedString(accountNickname)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    accountClassification: ").append(toIndentedString(accountClassification)).append("\n");
    sb.append("    accountStatus: ").append(toIndentedString(accountStatus)).append("\n");
    sb.append("    outstandingBalance: ").append(toIndentedString(outstandingBalance)).append("\n");
    sb.append("    availableCredit: ").append(toIndentedString(availableCredit)).append("\n");
    sb.append("    creditLimit: ").append(toIndentedString(creditLimit)).append("\n");
    sb.append("    minimumDueAmount: ").append(toIndentedString(minimumDueAmount)).append("\n");
    sb.append("    paymentDueDate: ").append(toIndentedString(paymentDueDate)).append("\n");
    sb.append("    alternateCurrency: ").append(toIndentedString(alternateCurrency)).append("\n");
    sb.append("    alternateCurrencyCurrentBalance: ").append(toIndentedString(alternateCurrencyCurrentBalance)).append("\n");
    sb.append("    cardHolderType: ").append(toIndentedString(cardHolderType)).append("\n");
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
