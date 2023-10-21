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
import io.swagger.client.model.CorporateOfficerDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * RetrieveCreditChargeCardCorporateCardsDetailRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardCorporateCardsDetailRequest {
  @SerializedName("tokenizedCardNumber")
  private String tokenizedCardNumber = null;

  @SerializedName("corporateOfficerDetails")
  private CorporateOfficerDetails corporateOfficerDetails = null;

  public RetrieveCreditChargeCardCorporateCardsDetailRequest tokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
    return this;
  }

   /**
   * Tokenized card number
   * @return tokenizedCardNumber
  **/
  @Schema(example = "asdsdf2341d5166h", required = true, description = "Tokenized card number")
  public String getTokenizedCardNumber() {
    return tokenizedCardNumber;
  }

  public void setTokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
  }

  public RetrieveCreditChargeCardCorporateCardsDetailRequest corporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
    return this;
  }

   /**
   * Get corporateOfficerDetails
   * @return corporateOfficerDetails
  **/
  @Schema(description = "")
  public CorporateOfficerDetails getCorporateOfficerDetails() {
    return corporateOfficerDetails;
  }

  public void setCorporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardCorporateCardsDetailRequest retrieveCreditChargeCardCorporateCardsDetailRequest = (RetrieveCreditChargeCardCorporateCardsDetailRequest) o;
    return Objects.equals(this.tokenizedCardNumber, retrieveCreditChargeCardCorporateCardsDetailRequest.tokenizedCardNumber) &&
        Objects.equals(this.corporateOfficerDetails, retrieveCreditChargeCardCorporateCardsDetailRequest.corporateOfficerDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tokenizedCardNumber, corporateOfficerDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardCorporateCardsDetailRequest {\n");
    
    sb.append("    tokenizedCardNumber: ").append(toIndentedString(tokenizedCardNumber)).append("\n");
    sb.append("    corporateOfficerDetails: ").append(toIndentedString(corporateOfficerDetails)).append("\n");
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
