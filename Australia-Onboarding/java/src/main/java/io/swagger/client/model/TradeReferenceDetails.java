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
 * TradeReferenceDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class TradeReferenceDetails {
  @SerializedName("referenceName")
  private String referenceName = null;

  @SerializedName("relationship")
  private String relationship = null;

  @SerializedName("accountantName")
  private String accountantName = null;

  public TradeReferenceDetails referenceName(String referenceName) {
    this.referenceName = referenceName;
    return this;
  }

   /**
   * Reference Name from the Trade done by the customer.
   * @return referenceName
  **/
  @Schema(example = "Gorge, ABC Corp", description = "Reference Name from the Trade done by the customer.")
  public String getReferenceName() {
    return referenceName;
  }

  public void setReferenceName(String referenceName) {
    this.referenceName = referenceName;
  }

  public TradeReferenceDetails relationship(String relationship) {
    this.relationship = relationship;
    return this;
  }

   /**
   * Trade Reference Relationship. This is a reference data field.Please use /v1/utilities/referenceData/{tradeReferenceRelationshipGCG} resource to get valid value of this field with description.
   * @return relationship
  **/
  @Schema(example = "SUPPLIER", description = "Trade Reference Relationship. This is a reference data field.Please use /v1/utilities/referenceData/{tradeReferenceRelationshipGCG} resource to get valid value of this field with description.")
  public String getRelationship() {
    return relationship;
  }

  public void setRelationship(String relationship) {
    this.relationship = relationship;
  }

  public TradeReferenceDetails accountantName(String accountantName) {
    this.accountantName = accountantName;
    return this;
  }

   /**
   * Accountant  Name from the Trade done by the customer.
   * @return accountantName
  **/
  @Schema(example = "Eric", description = "Accountant  Name from the Trade done by the customer.")
  public String getAccountantName() {
    return accountantName;
  }

  public void setAccountantName(String accountantName) {
    this.accountantName = accountantName;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TradeReferenceDetails tradeReferenceDetails = (TradeReferenceDetails) o;
    return Objects.equals(this.referenceName, tradeReferenceDetails.referenceName) &&
        Objects.equals(this.relationship, tradeReferenceDetails.relationship) &&
        Objects.equals(this.accountantName, tradeReferenceDetails.accountantName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(referenceName, relationship, accountantName);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TradeReferenceDetails {\n");
    
    sb.append("    referenceName: ").append(toIndentedString(referenceName)).append("\n");
    sb.append("    relationship: ").append(toIndentedString(relationship)).append("\n");
    sb.append("    accountantName: ").append(toIndentedString(accountantName)).append("\n");
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
