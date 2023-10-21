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
 * LoanSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanSummary {
  @SerializedName("loanAmount")
  private Double loanAmount = null;

  @SerializedName("loanTenure")
  private String loanTenure = null;

  @SerializedName("promotionId")
  private String promotionId = null;

  @SerializedName("interestRate")
  private Double interestRate = null;

  @SerializedName("interestRateEffectivityDate")
  private LocalDate interestRateEffectivityDate = null;

  @SerializedName("totalInterestAmount")
  private Double totalInterestAmount = null;

  @SerializedName("totalLoanAmount")
  private Double totalLoanAmount = null;

  @SerializedName("loanRemainingTermNumber")
  private Integer loanRemainingTermNumber = null;

  public LoanSummary loanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
    return this;
  }

   /**
   * Loan amount availed by customer
   * @return loanAmount
  **/
  @Schema(example = "41438.0", description = "Loan amount availed by customer")
  public Double getLoanAmount() {
    return loanAmount;
  }

  public void setLoanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
  }

  public LoanSummary loanTenure(String loanTenure) {
    this.loanTenure = loanTenure;
    return this;
  }

   /**
   * Tenure of loan against card.
   * @return loanTenure
  **/
  @Schema(example = "60", description = "Tenure of loan against card.")
  public String getLoanTenure() {
    return loanTenure;
  }

  public void setLoanTenure(String loanTenure) {
    this.loanTenure = loanTenure;
  }

  public LoanSummary promotionId(String promotionId) {
    this.promotionId = promotionId;
    return this;
  }

   /**
   * Promotion ID for the loan offered
   * @return promotionId
  **/
  @Schema(example = "PBCALCX03", description = "Promotion ID for the loan offered")
  public String getPromotionId() {
    return promotionId;
  }

  public void setPromotionId(String promotionId) {
    this.promotionId = promotionId;
  }

  public LoanSummary interestRate(Double interestRate) {
    this.interestRate = interestRate;
    return this;
  }

   /**
   * Interest rate for the loan
   * @return interestRate
  **/
  @Schema(example = "14.38", description = "Interest rate for the loan")
  public Double getInterestRate() {
    return interestRate;
  }

  public void setInterestRate(Double interestRate) {
    this.interestRate = interestRate;
  }

  public LoanSummary interestRateEffectivityDate(LocalDate interestRateEffectivityDate) {
    this.interestRateEffectivityDate = interestRateEffectivityDate;
    return this;
  }

   /**
   * Effectivity date of interest rate  in ISO 8601 date format YYYY-MM-DD
   * @return interestRateEffectivityDate
  **/
  @Schema(example = "Thu Sep 13 00:00:00 UTC 2012", description = "Effectivity date of interest rate  in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getInterestRateEffectivityDate() {
    return interestRateEffectivityDate;
  }

  public void setInterestRateEffectivityDate(LocalDate interestRateEffectivityDate) {
    this.interestRateEffectivityDate = interestRateEffectivityDate;
  }

  public LoanSummary totalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
    return this;
  }

   /**
   * Total interest amount for the loan
   * @return totalInterestAmount
  **/
  @Schema(example = "17833.0", description = "Total interest amount for the loan")
  public Double getTotalInterestAmount() {
    return totalInterestAmount;
  }

  public void setTotalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
  }

  public LoanSummary totalLoanAmount(Double totalLoanAmount) {
    this.totalLoanAmount = totalLoanAmount;
    return this;
  }

   /**
   * Total loan amount comprising of principal and interest
   * @return totalLoanAmount
  **/
  @Schema(example = "59271.64", description = "Total loan amount comprising of principal and interest")
  public Double getTotalLoanAmount() {
    return totalLoanAmount;
  }

  public void setTotalLoanAmount(Double totalLoanAmount) {
    this.totalLoanAmount = totalLoanAmount;
  }

  public LoanSummary loanRemainingTermNumber(Integer loanRemainingTermNumber) {
    this.loanRemainingTermNumber = loanRemainingTermNumber;
    return this;
  }

   /**
   * Remaining term of installment loan
   * @return loanRemainingTermNumber
  **/
  @Schema(example = "61", description = "Remaining term of installment loan")
  public Integer getLoanRemainingTermNumber() {
    return loanRemainingTermNumber;
  }

  public void setLoanRemainingTermNumber(Integer loanRemainingTermNumber) {
    this.loanRemainingTermNumber = loanRemainingTermNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanSummary loanSummary = (LoanSummary) o;
    return Objects.equals(this.loanAmount, loanSummary.loanAmount) &&
        Objects.equals(this.loanTenure, loanSummary.loanTenure) &&
        Objects.equals(this.promotionId, loanSummary.promotionId) &&
        Objects.equals(this.interestRate, loanSummary.interestRate) &&
        Objects.equals(this.interestRateEffectivityDate, loanSummary.interestRateEffectivityDate) &&
        Objects.equals(this.totalInterestAmount, loanSummary.totalInterestAmount) &&
        Objects.equals(this.totalLoanAmount, loanSummary.totalLoanAmount) &&
        Objects.equals(this.loanRemainingTermNumber, loanSummary.loanRemainingTermNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loanAmount, loanTenure, promotionId, interestRate, interestRateEffectivityDate, totalInterestAmount, totalLoanAmount, loanRemainingTermNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanSummary {\n");
    
    sb.append("    loanAmount: ").append(toIndentedString(loanAmount)).append("\n");
    sb.append("    loanTenure: ").append(toIndentedString(loanTenure)).append("\n");
    sb.append("    promotionId: ").append(toIndentedString(promotionId)).append("\n");
    sb.append("    interestRate: ").append(toIndentedString(interestRate)).append("\n");
    sb.append("    interestRateEffectivityDate: ").append(toIndentedString(interestRateEffectivityDate)).append("\n");
    sb.append("    totalInterestAmount: ").append(toIndentedString(totalInterestAmount)).append("\n");
    sb.append("    totalLoanAmount: ").append(toIndentedString(totalLoanAmount)).append("\n");
    sb.append("    loanRemainingTermNumber: ").append(toIndentedString(loanRemainingTermNumber)).append("\n");
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