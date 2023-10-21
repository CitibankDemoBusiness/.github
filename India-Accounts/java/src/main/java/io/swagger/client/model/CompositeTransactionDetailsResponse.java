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
import io.swagger.client.model.TransactionDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * CompositeTransactionDetailsResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class CompositeTransactionDetailsResponse {
  @SerializedName("transactionDetails")
  private List<TransactionDetails> transactionDetails = null;

  public CompositeTransactionDetailsResponse transactionDetails(List<TransactionDetails> transactionDetails) {
    this.transactionDetails = transactionDetails;
    return this;
  }

  public CompositeTransactionDetailsResponse addTransactionDetailsItem(TransactionDetails transactionDetailsItem) {
    if (this.transactionDetails == null) {
      this.transactionDetails = new ArrayList<TransactionDetails>();
    }
    this.transactionDetails.add(transactionDetailsItem);
    return this;
  }

   /**
   * Composite transaction details
   * @return transactionDetails
  **/
  @Schema(description = "Composite transaction details")
  public List<TransactionDetails> getTransactionDetails() {
    return transactionDetails;
  }

  public void setTransactionDetails(List<TransactionDetails> transactionDetails) {
    this.transactionDetails = transactionDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CompositeTransactionDetailsResponse compositeTransactionDetailsResponse = (CompositeTransactionDetailsResponse) o;
    return Objects.equals(this.transactionDetails, compositeTransactionDetailsResponse.transactionDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(transactionDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CompositeTransactionDetailsResponse {\n");
    
    sb.append("    transactionDetails: ").append(toIndentedString(transactionDetails)).append("\n");
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
