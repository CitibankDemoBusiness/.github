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
 * ExternalCreditCardDetailsAdd
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ExternalCreditCardDetailsAdd {
  @SerializedName("bankName")
  private String bankName = null;

  @SerializedName("creditCardNumber")
  private String creditCardNumber = null;

  public ExternalCreditCardDetailsAdd bankName(String bankName) {
    this.bankName = bankName;
    return this;
  }

   /**
   * Name of the bank issued the credit card.
   * @return bankName
  **/
  @Schema(example = "HSBC Bank", description = "Name of the bank issued the credit card.")
  public String getBankName() {
    return bankName;
  }

  public void setBankName(String bankName) {
    this.bankName = bankName;
  }

  public ExternalCreditCardDetailsAdd creditCardNumber(String creditCardNumber) {
    this.creditCardNumber = creditCardNumber;
    return this;
  }

   /**
   * Other Credit Card Number of the applicant, to be used for bill payments
   * @return creditCardNumber
  **/
  @Schema(example = "1234 1859 0000 0130", description = "Other Credit Card Number of the applicant, to be used for bill payments")
  public String getCreditCardNumber() {
    return creditCardNumber;
  }

  public void setCreditCardNumber(String creditCardNumber) {
    this.creditCardNumber = creditCardNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ExternalCreditCardDetailsAdd externalCreditCardDetailsAdd = (ExternalCreditCardDetailsAdd) o;
    return Objects.equals(this.bankName, externalCreditCardDetailsAdd.bankName) &&
        Objects.equals(this.creditCardNumber, externalCreditCardDetailsAdd.creditCardNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bankName, creditCardNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExternalCreditCardDetailsAdd {\n");
    
    sb.append("    bankName: ").append(toIndentedString(bankName)).append("\n");
    sb.append("    creditCardNumber: ").append(toIndentedString(creditCardNumber)).append("\n");
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
