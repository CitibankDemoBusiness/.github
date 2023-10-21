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
/**
 * LoanBookingPreLoginResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanBookingPreLoginResponse {
  @SerializedName("loanReferenceId")
  private String loanReferenceId = null;

  @SerializedName("paymentMethod")
  private String paymentMethod = null;

  public LoanBookingPreLoginResponse loanReferenceId(String loanReferenceId) {
    this.loanReferenceId = loanReferenceId;
    return this;
  }

   /**
   * The unique  reference Id used to identify this Loan from all the other Loans
   * @return loanReferenceId
  **/
  @Schema(example = "BIMI51807310002051", required = true, description = "The unique  reference Id used to identify this Loan from all the other Loans")
  public String getLoanReferenceId() {
    return loanReferenceId;
  }

  public void setLoanReferenceId(String loanReferenceId) {
    this.loanReferenceId = loanReferenceId;
  }

  public LoanBookingPreLoginResponse paymentMethod(String paymentMethod) {
    this.paymentMethod = paymentMethod;
    return this;
  }

   /**
   * The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.
   * @return paymentMethod
  **/
  @Schema(example = "GIRO", description = "The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.")
  public String getPaymentMethod() {
    return paymentMethod;
  }

  public void setPaymentMethod(String paymentMethod) {
    this.paymentMethod = paymentMethod;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanBookingPreLoginResponse loanBookingPreLoginResponse = (LoanBookingPreLoginResponse) o;
    return Objects.equals(this.loanReferenceId, loanBookingPreLoginResponse.loanReferenceId) &&
        Objects.equals(this.paymentMethod, loanBookingPreLoginResponse.paymentMethod);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loanReferenceId, paymentMethod);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanBookingPreLoginResponse {\n");
    
    sb.append("    loanReferenceId: ").append(toIndentedString(loanReferenceId)).append("\n");
    sb.append("    paymentMethod: ").append(toIndentedString(paymentMethod)).append("\n");
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