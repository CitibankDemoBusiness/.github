/*
 * Cards
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
import io.swagger.client.model.DomesticTransaction;
import io.swagger.client.model.InternationalTransaction;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
/**
 * CreditCardLimitDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class CreditCardLimitDetails {
  @SerializedName("currentContactlessWthoutPinPmtLimit")
  private BigDecimal currentContactlessWthoutPinPmtLimit = null;

  @SerializedName("posSpendingLimitAmount")
  private Double posSpendingLimitAmount = null;

  @SerializedName("internetPurchaseLimitAmount")
  private Double internetPurchaseLimitAmount = null;

  @SerializedName("dailyAtmWithdrawalLimitAmount")
  private Double dailyAtmWithdrawalLimitAmount = null;

  @SerializedName("dailyTransactionLimitAmount")
  private Double dailyTransactionLimitAmount = null;

  @SerializedName("internetPurchaseActivationFlag")
  private Boolean internetPurchaseActivationFlag = null;

  @SerializedName("domesticTransaction")
  private DomesticTransaction domesticTransaction = null;

  @SerializedName("internationalTransaction")
  private InternationalTransaction internationalTransaction = null;

  public CreditCardLimitDetails currentContactlessWthoutPinPmtLimit(BigDecimal currentContactlessWthoutPinPmtLimit) {
    this.currentContactlessWthoutPinPmtLimit = currentContactlessWthoutPinPmtLimit;
    return this;
  }

   /**
   * Transaction limit set by the customer for the contact less payments without pin
   * @return currentContactlessWthoutPinPmtLimit
  **/
  @Schema(example = "200.0", description = "Transaction limit set by the customer for the contact less payments without pin")
  public BigDecimal getCurrentContactlessWthoutPinPmtLimit() {
    return currentContactlessWthoutPinPmtLimit;
  }

  public void setCurrentContactlessWthoutPinPmtLimit(BigDecimal currentContactlessWthoutPinPmtLimit) {
    this.currentContactlessWthoutPinPmtLimit = currentContactlessWthoutPinPmtLimit;
  }

  public CreditCardLimitDetails posSpendingLimitAmount(Double posSpendingLimitAmount) {
    this.posSpendingLimitAmount = posSpendingLimitAmount;
    return this;
  }

   /**
   * Point Sale Transaction Limit for the Credit card depends on customer selection
   * @return posSpendingLimitAmount
  **/
  @Schema(example = "45000.0", description = "Point Sale Transaction Limit for the Credit card depends on customer selection")
  public Double getPosSpendingLimitAmount() {
    return posSpendingLimitAmount;
  }

  public void setPosSpendingLimitAmount(Double posSpendingLimitAmount) {
    this.posSpendingLimitAmount = posSpendingLimitAmount;
  }

  public CreditCardLimitDetails internetPurchaseLimitAmount(Double internetPurchaseLimitAmount) {
    this.internetPurchaseLimitAmount = internetPurchaseLimitAmount;
    return this;
  }

   /**
   * Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction
   * @return internetPurchaseLimitAmount
  **/
  @Schema(example = "50000.0", description = "Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction")
  public Double getInternetPurchaseLimitAmount() {
    return internetPurchaseLimitAmount;
  }

  public void setInternetPurchaseLimitAmount(Double internetPurchaseLimitAmount) {
    this.internetPurchaseLimitAmount = internetPurchaseLimitAmount;
  }

  public CreditCardLimitDetails dailyAtmWithdrawalLimitAmount(Double dailyAtmWithdrawalLimitAmount) {
    this.dailyAtmWithdrawalLimitAmount = dailyAtmWithdrawalLimitAmount;
    return this;
  }

   /**
   * Field to indicate the limit on local ATM withdrawal amount
   * @return dailyAtmWithdrawalLimitAmount
  **/
  @Schema(example = "2000.0", description = "Field to indicate the limit on local ATM withdrawal amount")
  public Double getDailyAtmWithdrawalLimitAmount() {
    return dailyAtmWithdrawalLimitAmount;
  }

  public void setDailyAtmWithdrawalLimitAmount(Double dailyAtmWithdrawalLimitAmount) {
    this.dailyAtmWithdrawalLimitAmount = dailyAtmWithdrawalLimitAmount;
  }

  public CreditCardLimitDetails dailyTransactionLimitAmount(Double dailyTransactionLimitAmount) {
    this.dailyTransactionLimitAmount = dailyTransactionLimitAmount;
    return this;
  }

   /**
   * This is Daily accumulated Transaction amount Limit and set by customer.
   * @return dailyTransactionLimitAmount
  **/
  @Schema(example = "100.25", description = "This is Daily accumulated Transaction amount Limit and set by customer.")
  public Double getDailyTransactionLimitAmount() {
    return dailyTransactionLimitAmount;
  }

  public void setDailyTransactionLimitAmount(Double dailyTransactionLimitAmount) {
    this.dailyTransactionLimitAmount = dailyTransactionLimitAmount;
  }

  public CreditCardLimitDetails internetPurchaseActivationFlag(Boolean internetPurchaseActivationFlag) {
    this.internetPurchaseActivationFlag = internetPurchaseActivationFlag;
    return this;
  }

   /**
   * The indicator to enable/disable online purchase transaction (E-commerce).
   * @return internetPurchaseActivationFlag
  **/
  @Schema(example = "true", description = "The indicator to enable/disable online purchase transaction (E-commerce).")
  public Boolean isInternetPurchaseActivationFlag() {
    return internetPurchaseActivationFlag;
  }

  public void setInternetPurchaseActivationFlag(Boolean internetPurchaseActivationFlag) {
    this.internetPurchaseActivationFlag = internetPurchaseActivationFlag;
  }

  public CreditCardLimitDetails domesticTransaction(DomesticTransaction domesticTransaction) {
    this.domesticTransaction = domesticTransaction;
    return this;
  }

   /**
   * Get domesticTransaction
   * @return domesticTransaction
  **/
  @Schema(description = "")
  public DomesticTransaction getDomesticTransaction() {
    return domesticTransaction;
  }

  public void setDomesticTransaction(DomesticTransaction domesticTransaction) {
    this.domesticTransaction = domesticTransaction;
  }

  public CreditCardLimitDetails internationalTransaction(InternationalTransaction internationalTransaction) {
    this.internationalTransaction = internationalTransaction;
    return this;
  }

   /**
   * Get internationalTransaction
   * @return internationalTransaction
  **/
  @Schema(description = "")
  public InternationalTransaction getInternationalTransaction() {
    return internationalTransaction;
  }

  public void setInternationalTransaction(InternationalTransaction internationalTransaction) {
    this.internationalTransaction = internationalTransaction;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreditCardLimitDetails creditCardLimitDetails = (CreditCardLimitDetails) o;
    return Objects.equals(this.currentContactlessWthoutPinPmtLimit, creditCardLimitDetails.currentContactlessWthoutPinPmtLimit) &&
        Objects.equals(this.posSpendingLimitAmount, creditCardLimitDetails.posSpendingLimitAmount) &&
        Objects.equals(this.internetPurchaseLimitAmount, creditCardLimitDetails.internetPurchaseLimitAmount) &&
        Objects.equals(this.dailyAtmWithdrawalLimitAmount, creditCardLimitDetails.dailyAtmWithdrawalLimitAmount) &&
        Objects.equals(this.dailyTransactionLimitAmount, creditCardLimitDetails.dailyTransactionLimitAmount) &&
        Objects.equals(this.internetPurchaseActivationFlag, creditCardLimitDetails.internetPurchaseActivationFlag) &&
        Objects.equals(this.domesticTransaction, creditCardLimitDetails.domesticTransaction) &&
        Objects.equals(this.internationalTransaction, creditCardLimitDetails.internationalTransaction);
  }

  @Override
  public int hashCode() {
    return Objects.hash(currentContactlessWthoutPinPmtLimit, posSpendingLimitAmount, internetPurchaseLimitAmount, dailyAtmWithdrawalLimitAmount, dailyTransactionLimitAmount, internetPurchaseActivationFlag, domesticTransaction, internationalTransaction);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreditCardLimitDetails {\n");
    
    sb.append("    currentContactlessWthoutPinPmtLimit: ").append(toIndentedString(currentContactlessWthoutPinPmtLimit)).append("\n");
    sb.append("    posSpendingLimitAmount: ").append(toIndentedString(posSpendingLimitAmount)).append("\n");
    sb.append("    internetPurchaseLimitAmount: ").append(toIndentedString(internetPurchaseLimitAmount)).append("\n");
    sb.append("    dailyAtmWithdrawalLimitAmount: ").append(toIndentedString(dailyAtmWithdrawalLimitAmount)).append("\n");
    sb.append("    dailyTransactionLimitAmount: ").append(toIndentedString(dailyTransactionLimitAmount)).append("\n");
    sb.append("    internetPurchaseActivationFlag: ").append(toIndentedString(internetPurchaseActivationFlag)).append("\n");
    sb.append("    domesticTransaction: ").append(toIndentedString(domesticTransaction)).append("\n");
    sb.append("    internationalTransaction: ").append(toIndentedString(internationalTransaction)).append("\n");
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