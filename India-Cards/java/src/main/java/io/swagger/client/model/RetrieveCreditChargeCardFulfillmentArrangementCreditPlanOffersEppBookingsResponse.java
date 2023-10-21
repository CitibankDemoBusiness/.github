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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse {
  @SerializedName("loanReferenceId")
  private String loanReferenceId = null;

  @SerializedName("installmentAmount")
  private Double installmentAmount = null;

  @SerializedName("principalAmount")
  private Double principalAmount = null;

  @SerializedName("installmentInterestAmount")
  private Double installmentInterestAmount = null;

  @SerializedName("initialInterestAmount")
  private Double initialInterestAmount = null;

  @SerializedName("statementUnpaidBalanceAmount")
  private Double statementUnpaidBalanceAmount = null;

  @SerializedName("statementMinimumDueBalanceAmount")
  private Double statementMinimumDueBalanceAmount = null;

  @SerializedName("statementPaymentDueDate")
  private LocalDate statementPaymentDueDate = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse loanReferenceId(String loanReferenceId) {
    this.loanReferenceId = loanReferenceId;
    return this;
  }

   /**
   * The unique  reference Id used to identify this Loan from all the other Loans
   * @return loanReferenceId
  **/
  @Schema(example = "50120182023488200", required = true, description = "The unique  reference Id used to identify this Loan from all the other Loans")
  public String getLoanReferenceId() {
    return loanReferenceId;
  }

  public void setLoanReferenceId(String loanReferenceId) {
    this.loanReferenceId = loanReferenceId;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse installmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
    return this;
  }

   /**
   * Installment amount to be paid by customer in order to repay the loan.
   * @return installmentAmount
  **/
  @Schema(example = "34.95", description = "Installment amount to be paid by customer in order to repay the loan.")
  public Double getInstallmentAmount() {
    return installmentAmount;
  }

  public void setInstallmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse principalAmount(Double principalAmount) {
    this.principalAmount = principalAmount;
    return this;
  }

   /**
   * The portion of the Principal Amount Paid for the loan.
   * @return principalAmount
  **/
  @Schema(example = "5000.95", description = "The portion of the Principal Amount Paid for the loan.")
  public Double getPrincipalAmount() {
    return principalAmount;
  }

  public void setPrincipalAmount(Double principalAmount) {
    this.principalAmount = principalAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse installmentInterestAmount(Double installmentInterestAmount) {
    this.installmentInterestAmount = installmentInterestAmount;
    return this;
  }

   /**
   * The interest amount to be paid as installment.
   * @return installmentInterestAmount
  **/
  @Schema(example = "5.58", description = "The interest amount to be paid as installment.")
  public Double getInstallmentInterestAmount() {
    return installmentInterestAmount;
  }

  public void setInstallmentInterestAmount(Double installmentInterestAmount) {
    this.installmentInterestAmount = installmentInterestAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse initialInterestAmount(Double initialInterestAmount) {
    this.initialInterestAmount = initialInterestAmount;
    return this;
  }

   /**
   * Initial interest amount charged to customer from the epp booking date to the first installment start date
   * @return initialInterestAmount
  **/
  @Schema(example = "7.95", description = "Initial interest amount charged to customer from the epp booking date to the first installment start date")
  public Double getInitialInterestAmount() {
    return initialInterestAmount;
  }

  public void setInitialInterestAmount(Double initialInterestAmount) {
    this.initialInterestAmount = initialInterestAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse statementUnpaidBalanceAmount(Double statementUnpaidBalanceAmount) {
    this.statementUnpaidBalanceAmount = statementUnpaidBalanceAmount;
    return this;
  }

   /**
   * This field indicates the remaining statement balance amount that remains due and payable.
   * @return statementUnpaidBalanceAmount
  **/
  @Schema(example = "1500.11", description = "This field indicates the remaining statement balance amount that remains due and payable.")
  public Double getStatementUnpaidBalanceAmount() {
    return statementUnpaidBalanceAmount;
  }

  public void setStatementUnpaidBalanceAmount(Double statementUnpaidBalanceAmount) {
    this.statementUnpaidBalanceAmount = statementUnpaidBalanceAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse statementMinimumDueBalanceAmount(Double statementMinimumDueBalanceAmount) {
    this.statementMinimumDueBalanceAmount = statementMinimumDueBalanceAmount;
    return this;
  }

   /**
   * Minimum due amount for a payment cycle
   * @return statementMinimumDueBalanceAmount
  **/
  @Schema(example = "50.0", description = "Minimum due amount for a payment cycle")
  public Double getStatementMinimumDueBalanceAmount() {
    return statementMinimumDueBalanceAmount;
  }

  public void setStatementMinimumDueBalanceAmount(Double statementMinimumDueBalanceAmount) {
    this.statementMinimumDueBalanceAmount = statementMinimumDueBalanceAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse statementPaymentDueDate(LocalDate statementPaymentDueDate) {
    this.statementPaymentDueDate = statementPaymentDueDate;
    return this;
  }

   /**
   * Next payment due date in ISO 8601 date format YYYY-MM-DD
   * @return statementPaymentDueDate
  **/
  @Schema(example = "Mon Dec 05 00:00:00 UTC 2016", description = "Next payment due date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getStatementPaymentDueDate() {
    return statementPaymentDueDate;
  }

  public void setStatementPaymentDueDate(LocalDate statementPaymentDueDate) {
    this.statementPaymentDueDate = statementPaymentDueDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse) o;
    return Objects.equals(this.loanReferenceId, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.loanReferenceId) &&
        Objects.equals(this.installmentAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.installmentAmount) &&
        Objects.equals(this.principalAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.principalAmount) &&
        Objects.equals(this.installmentInterestAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.installmentInterestAmount) &&
        Objects.equals(this.initialInterestAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.initialInterestAmount) &&
        Objects.equals(this.statementUnpaidBalanceAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.statementUnpaidBalanceAmount) &&
        Objects.equals(this.statementMinimumDueBalanceAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.statementMinimumDueBalanceAmount) &&
        Objects.equals(this.statementPaymentDueDate, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.statementPaymentDueDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loanReferenceId, installmentAmount, principalAmount, installmentInterestAmount, initialInterestAmount, statementUnpaidBalanceAmount, statementMinimumDueBalanceAmount, statementPaymentDueDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse {\n");
    
    sb.append("    loanReferenceId: ").append(toIndentedString(loanReferenceId)).append("\n");
    sb.append("    installmentAmount: ").append(toIndentedString(installmentAmount)).append("\n");
    sb.append("    principalAmount: ").append(toIndentedString(principalAmount)).append("\n");
    sb.append("    installmentInterestAmount: ").append(toIndentedString(installmentInterestAmount)).append("\n");
    sb.append("    initialInterestAmount: ").append(toIndentedString(initialInterestAmount)).append("\n");
    sb.append("    statementUnpaidBalanceAmount: ").append(toIndentedString(statementUnpaidBalanceAmount)).append("\n");
    sb.append("    statementMinimumDueBalanceAmount: ").append(toIndentedString(statementMinimumDueBalanceAmount)).append("\n");
    sb.append("    statementPaymentDueDate: ").append(toIndentedString(statementPaymentDueDate)).append("\n");
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