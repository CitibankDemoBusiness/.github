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
import io.swagger.client.model.PartialResponseInformation;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * CreditCardAccountBalanceSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class CreditCardAccountBalanceSummary {
  @SerializedName("totalDisputedTransactionAmount")
  private Double totalDisputedTransactionAmount = null;

  @SerializedName("currentOutstandingAmount")
  private Double currentOutstandingAmount = null;

  @SerializedName("currentAccruedInterest")
  private Double currentAccruedInterest = null;

  @SerializedName("paymentDueAmount")
  private Double paymentDueAmount = null;

  @SerializedName("availablePointBalance")
  private Double availablePointBalance = null;

  @SerializedName("partialResponseInformation")
  private List<PartialResponseInformation> partialResponseInformation = null;

  public CreditCardAccountBalanceSummary totalDisputedTransactionAmount(Double totalDisputedTransactionAmount) {
    this.totalDisputedTransactionAmount = totalDisputedTransactionAmount;
    return this;
  }

   /**
   * This is the total disputed transaction amount.
   * @return totalDisputedTransactionAmount
  **/
  @Schema(example = "2500.11", description = "This is the total disputed transaction amount.")
  public Double getTotalDisputedTransactionAmount() {
    return totalDisputedTransactionAmount;
  }

  public void setTotalDisputedTransactionAmount(Double totalDisputedTransactionAmount) {
    this.totalDisputedTransactionAmount = totalDisputedTransactionAmount;
  }

  public CreditCardAccountBalanceSummary currentOutstandingAmount(Double currentOutstandingAmount) {
    this.currentOutstandingAmount = currentOutstandingAmount;
    return this;
  }

   /**
   * This includes the current intra-day transactions which yet to be posted on card.
   * @return currentOutstandingAmount
  **/
  @Schema(example = "1500.25", required = true, description = "This includes the current intra-day transactions which yet to be posted on card.")
  public Double getCurrentOutstandingAmount() {
    return currentOutstandingAmount;
  }

  public void setCurrentOutstandingAmount(Double currentOutstandingAmount) {
    this.currentOutstandingAmount = currentOutstandingAmount;
  }

  public CreditCardAccountBalanceSummary currentAccruedInterest(Double currentAccruedInterest) {
    this.currentAccruedInterest = currentAccruedInterest;
    return this;
  }

   /**
   * Interest which has been accrued till last accrual date.
   * @return currentAccruedInterest
  **/
  @Schema(example = "4.11", required = true, description = "Interest which has been accrued till last accrual date.")
  public Double getCurrentAccruedInterest() {
    return currentAccruedInterest;
  }

  public void setCurrentAccruedInterest(Double currentAccruedInterest) {
    this.currentAccruedInterest = currentAccruedInterest;
  }

  public CreditCardAccountBalanceSummary paymentDueAmount(Double paymentDueAmount) {
    this.paymentDueAmount = paymentDueAmount;
    return this;
  }

   /**
   * Total amount customer needs to pay in order to clear the balance.
   * @return paymentDueAmount
  **/
  @Schema(example = "25000.66", required = true, description = "Total amount customer needs to pay in order to clear the balance.")
  public Double getPaymentDueAmount() {
    return paymentDueAmount;
  }

  public void setPaymentDueAmount(Double paymentDueAmount) {
    this.paymentDueAmount = paymentDueAmount;
  }

  public CreditCardAccountBalanceSummary availablePointBalance(Double availablePointBalance) {
    this.availablePointBalance = availablePointBalance;
    return this;
  }

   /**
   * Available reward points on the credit card
   * @return availablePointBalance
  **/
  @Schema(example = "12511.25", description = "Available reward points on the credit card")
  public Double getAvailablePointBalance() {
    return availablePointBalance;
  }

  public void setAvailablePointBalance(Double availablePointBalance) {
    this.availablePointBalance = availablePointBalance;
  }

  public CreditCardAccountBalanceSummary partialResponseInformation(List<PartialResponseInformation> partialResponseInformation) {
    this.partialResponseInformation = partialResponseInformation;
    return this;
  }

  public CreditCardAccountBalanceSummary addPartialResponseInformationItem(PartialResponseInformation partialResponseInformationItem) {
    if (this.partialResponseInformation == null) {
      this.partialResponseInformation = new ArrayList<PartialResponseInformation>();
    }
    this.partialResponseInformation.add(partialResponseInformationItem);
    return this;
  }

   /**
   * Partial success response
   * @return partialResponseInformation
  **/
  @Schema(description = "Partial success response")
  public List<PartialResponseInformation> getPartialResponseInformation() {
    return partialResponseInformation;
  }

  public void setPartialResponseInformation(List<PartialResponseInformation> partialResponseInformation) {
    this.partialResponseInformation = partialResponseInformation;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreditCardAccountBalanceSummary creditCardAccountBalanceSummary = (CreditCardAccountBalanceSummary) o;
    return Objects.equals(this.totalDisputedTransactionAmount, creditCardAccountBalanceSummary.totalDisputedTransactionAmount) &&
        Objects.equals(this.currentOutstandingAmount, creditCardAccountBalanceSummary.currentOutstandingAmount) &&
        Objects.equals(this.currentAccruedInterest, creditCardAccountBalanceSummary.currentAccruedInterest) &&
        Objects.equals(this.paymentDueAmount, creditCardAccountBalanceSummary.paymentDueAmount) &&
        Objects.equals(this.availablePointBalance, creditCardAccountBalanceSummary.availablePointBalance) &&
        Objects.equals(this.partialResponseInformation, creditCardAccountBalanceSummary.partialResponseInformation);
  }

  @Override
  public int hashCode() {
    return Objects.hash(totalDisputedTransactionAmount, currentOutstandingAmount, currentAccruedInterest, paymentDueAmount, availablePointBalance, partialResponseInformation);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreditCardAccountBalanceSummary {\n");
    
    sb.append("    totalDisputedTransactionAmount: ").append(toIndentedString(totalDisputedTransactionAmount)).append("\n");
    sb.append("    currentOutstandingAmount: ").append(toIndentedString(currentOutstandingAmount)).append("\n");
    sb.append("    currentAccruedInterest: ").append(toIndentedString(currentAccruedInterest)).append("\n");
    sb.append("    paymentDueAmount: ").append(toIndentedString(paymentDueAmount)).append("\n");
    sb.append("    availablePointBalance: ").append(toIndentedString(availablePointBalance)).append("\n");
    sb.append("    partialResponseInformation: ").append(toIndentedString(partialResponseInformation)).append("\n");
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
