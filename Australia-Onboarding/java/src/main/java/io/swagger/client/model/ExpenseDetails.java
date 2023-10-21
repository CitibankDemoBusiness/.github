/*
 * Onboarding
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
/**
 * ExpenseDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ExpenseDetails {
  @SerializedName("expenseType")
  private String expenseType = null;

  @SerializedName("expenseAmount")
  private Double expenseAmount = null;

  @SerializedName("frequency")
  private String frequency = null;

  public ExpenseDetails expenseType(String expenseType) {
    this.expenseType = expenseType;
    return this;
  }

   /**
   * Expense type. This is a reference data field. Please use /v1/utilities/referenceData/{expenseType} resource to get valid value of this field with description.
   * @return expenseType
  **/
  @Schema(example = "COSTS_OF_LIVING", description = "Expense type. This is a reference data field. Please use /v1/utilities/referenceData/{expenseType} resource to get valid value of this field with description.")
  public String getExpenseType() {
    return expenseType;
  }

  public void setExpenseType(String expenseType) {
    this.expenseType = expenseType;
  }

  public ExpenseDetails expenseAmount(Double expenseAmount) {
    this.expenseAmount = expenseAmount;
    return this;
  }

   /**
   * Expenditure amount for an applicant
   * @return expenseAmount
  **/
  @Schema(example = "590.25", description = "Expenditure amount for an applicant")
  public Double getExpenseAmount() {
    return expenseAmount;
  }

  public void setExpenseAmount(Double expenseAmount) {
    this.expenseAmount = expenseAmount;
  }

  public ExpenseDetails frequency(String frequency) {
    this.frequency = frequency;
    return this;
  }

   /**
   * Expense Frequency. This is a reference data field. Please use /v1/utilities/referenceData/{frequency} resource to get valid value of this field with description.
   * @return frequency
  **/
  @Schema(example = "MONTHLY", description = "Expense Frequency. This is a reference data field. Please use /v1/utilities/referenceData/{frequency} resource to get valid value of this field with description.")
  public String getFrequency() {
    return frequency;
  }

  public void setFrequency(String frequency) {
    this.frequency = frequency;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ExpenseDetails expenseDetails = (ExpenseDetails) o;
    return Objects.equals(this.expenseType, expenseDetails.expenseType) &&
        Objects.equals(this.expenseAmount, expenseDetails.expenseAmount) &&
        Objects.equals(this.frequency, expenseDetails.frequency);
  }

  @Override
  public int hashCode() {
    return Objects.hash(expenseType, expenseAmount, frequency);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExpenseDetails {\n");
    
    sb.append("    expenseType: ").append(toIndentedString(expenseType)).append("\n");
    sb.append("    expenseAmount: ").append(toIndentedString(expenseAmount)).append("\n");
    sb.append("    frequency: ").append(toIndentedString(frequency)).append("\n");
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
