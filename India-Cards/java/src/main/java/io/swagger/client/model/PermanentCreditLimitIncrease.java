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
/**
 * PermanentCreditLimitIncrease
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class PermanentCreditLimitIncrease {
  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("requestedCreditLimitAmount")
  private Double requestedCreditLimitAmount = null;

  public PermanentCreditLimitIncrease cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * Unique Id of the card in encrypted format.
   * @return cardId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "Unique Id of the card in encrypted format.")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public PermanentCreditLimitIncrease requestedCreditLimitAmount(Double requestedCreditLimitAmount) {
    this.requestedCreditLimitAmount = requestedCreditLimitAmount;
    return this;
  }

   /**
   * Customers preferred revised credit limit. This is the combined limit  shared with all the existing credit cards of the customer
   * @return requestedCreditLimitAmount
  **/
  @Schema(example = "10000.25", required = true, description = "Customers preferred revised credit limit. This is the combined limit  shared with all the existing credit cards of the customer")
  public Double getRequestedCreditLimitAmount() {
    return requestedCreditLimitAmount;
  }

  public void setRequestedCreditLimitAmount(Double requestedCreditLimitAmount) {
    this.requestedCreditLimitAmount = requestedCreditLimitAmount;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PermanentCreditLimitIncrease permanentCreditLimitIncrease = (PermanentCreditLimitIncrease) o;
    return Objects.equals(this.cardId, permanentCreditLimitIncrease.cardId) &&
        Objects.equals(this.requestedCreditLimitAmount, permanentCreditLimitIncrease.requestedCreditLimitAmount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardId, requestedCreditLimitAmount);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PermanentCreditLimitIncrease {\n");
    
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    requestedCreditLimitAmount: ").append(toIndentedString(requestedCreditLimitAmount)).append("\n");
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
