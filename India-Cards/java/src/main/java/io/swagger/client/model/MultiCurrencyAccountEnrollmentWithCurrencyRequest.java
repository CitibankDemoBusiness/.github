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
 * MultiCurrencyAccountEnrollmentWithCurrencyRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class MultiCurrencyAccountEnrollmentWithCurrencyRequest {
  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("accountId")
  private String accountId = null;

  public MultiCurrencyAccountEnrollmentWithCurrencyRequest currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * Currency code  in ISO 4217 format, which needs to be added to multi currency account by creating new account for that foreign currency
   * @return currencyCode
  **/
  @Schema(example = "AUD", required = true, description = "Currency code  in ISO 4217 format, which needs to be added to multi currency account by creating new account for that foreign currency")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public MultiCurrencyAccountEnrollmentWithCurrencyRequest accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The customer account identifier in encrypted format
   * @return accountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The customer account identifier in encrypted format")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MultiCurrencyAccountEnrollmentWithCurrencyRequest multiCurrencyAccountEnrollmentWithCurrencyRequest = (MultiCurrencyAccountEnrollmentWithCurrencyRequest) o;
    return Objects.equals(this.currencyCode, multiCurrencyAccountEnrollmentWithCurrencyRequest.currencyCode) &&
        Objects.equals(this.accountId, multiCurrencyAccountEnrollmentWithCurrencyRequest.accountId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(currencyCode, accountId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MultiCurrencyAccountEnrollmentWithCurrencyRequest {\n");
    
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
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
