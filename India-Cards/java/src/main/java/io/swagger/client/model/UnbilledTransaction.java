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
 * UnbilledTransaction
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class UnbilledTransaction {
  @SerializedName("transactionDate")
  private LocalDate transactionDate = null;

  @SerializedName("transactionDescription")
  private String transactionDescription = null;

  @SerializedName("transactionReferenceId")
  private String transactionReferenceId = null;

  @SerializedName("transactionAmount")
  private Double transactionAmount = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  public UnbilledTransaction transactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
    return this;
  }

   /**
   * Transaction date in YYYY-MM-DD format value conforming to ISO 8601.
   * @return transactionDate
  **/
  @Schema(example = "Mon May 21 00:00:00 UTC 2018", required = true, description = "Transaction date in YYYY-MM-DD format value conforming to ISO 8601.")
  public LocalDate getTransactionDate() {
    return transactionDate;
  }

  public void setTransactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
  }

  public UnbilledTransaction transactionDescription(String transactionDescription) {
    this.transactionDescription = transactionDescription;
    return this;
  }

   /**
   * Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.
   * @return transactionDescription
  **/
  @Schema(example = "TRANSIT 30000659022734 SINGAPORE SG", required = true, description = "Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.")
  public String getTransactionDescription() {
    return transactionDescription;
  }

  public void setTransactionDescription(String transactionDescription) {
    this.transactionDescription = transactionDescription;
  }

  public UnbilledTransaction transactionReferenceId(String transactionReferenceId) {
    this.transactionReferenceId = transactionReferenceId;
    return this;
  }

   /**
   * Reference Id to uniquely identify the transaction.This is applicable for successful transactions. 
   * @return transactionReferenceId
  **/
  @Schema(example = "BIMI51807310002051", description = "Reference Id to uniquely identify the transaction.This is applicable for successful transactions. ")
  public String getTransactionReferenceId() {
    return transactionReferenceId;
  }

  public void setTransactionReferenceId(String transactionReferenceId) {
    this.transactionReferenceId = transactionReferenceId;
  }

  public UnbilledTransaction transactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
    return this;
  }

   /**
   * Transaction amount in local currency.
   * @return transactionAmount
  **/
  @Schema(example = "50.55", required = true, description = "Transaction amount in local currency.")
  public Double getTransactionAmount() {
    return transactionAmount;
  }

  public void setTransactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
  }

  public UnbilledTransaction currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "EUR", description = "The currency code in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UnbilledTransaction unbilledTransaction = (UnbilledTransaction) o;
    return Objects.equals(this.transactionDate, unbilledTransaction.transactionDate) &&
        Objects.equals(this.transactionDescription, unbilledTransaction.transactionDescription) &&
        Objects.equals(this.transactionReferenceId, unbilledTransaction.transactionReferenceId) &&
        Objects.equals(this.transactionAmount, unbilledTransaction.transactionAmount) &&
        Objects.equals(this.currencyCode, unbilledTransaction.currencyCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(transactionDate, transactionDescription, transactionReferenceId, transactionAmount, currencyCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UnbilledTransaction {\n");
    
    sb.append("    transactionDate: ").append(toIndentedString(transactionDate)).append("\n");
    sb.append("    transactionDescription: ").append(toIndentedString(transactionDescription)).append("\n");
    sb.append("    transactionReferenceId: ").append(toIndentedString(transactionReferenceId)).append("\n");
    sb.append("    transactionAmount: ").append(toIndentedString(transactionAmount)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
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
