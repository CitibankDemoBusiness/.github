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
import io.swagger.client.model.ExpenseDetails;
import io.swagger.client.model.IncomeDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * FinancialInformation
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class FinancialInformation {
  @SerializedName("expenseDetails")
  private List<ExpenseDetails> expenseDetails = null;

  @SerializedName("incomeDetails")
  private List<IncomeDetails> incomeDetails = null;

  public FinancialInformation expenseDetails(List<ExpenseDetails> expenseDetails) {
    this.expenseDetails = expenseDetails;
    return this;
  }

  public FinancialInformation addExpenseDetailsItem(ExpenseDetails expenseDetailsItem) {
    if (this.expenseDetails == null) {
      this.expenseDetails = new ArrayList<ExpenseDetails>();
    }
    this.expenseDetails.add(expenseDetailsItem);
    return this;
  }

   /**
   * Get expenseDetails
   * @return expenseDetails
  **/
  @Schema(description = "")
  public List<ExpenseDetails> getExpenseDetails() {
    return expenseDetails;
  }

  public void setExpenseDetails(List<ExpenseDetails> expenseDetails) {
    this.expenseDetails = expenseDetails;
  }

  public FinancialInformation incomeDetails(List<IncomeDetails> incomeDetails) {
    this.incomeDetails = incomeDetails;
    return this;
  }

  public FinancialInformation addIncomeDetailsItem(IncomeDetails incomeDetailsItem) {
    if (this.incomeDetails == null) {
      this.incomeDetails = new ArrayList<IncomeDetails>();
    }
    this.incomeDetails.add(incomeDetailsItem);
    return this;
  }

   /**
   * Get incomeDetails
   * @return incomeDetails
  **/
  @Schema(description = "")
  public List<IncomeDetails> getIncomeDetails() {
    return incomeDetails;
  }

  public void setIncomeDetails(List<IncomeDetails> incomeDetails) {
    this.incomeDetails = incomeDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FinancialInformation financialInformation = (FinancialInformation) o;
    return Objects.equals(this.expenseDetails, financialInformation.expenseDetails) &&
        Objects.equals(this.incomeDetails, financialInformation.incomeDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(expenseDetails, incomeDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FinancialInformation {\n");
    
    sb.append("    expenseDetails: ").append(toIndentedString(expenseDetails)).append("\n");
    sb.append("    incomeDetails: ").append(toIndentedString(incomeDetails)).append("\n");
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
