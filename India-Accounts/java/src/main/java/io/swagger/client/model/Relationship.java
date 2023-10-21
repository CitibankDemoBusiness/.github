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
 * Relationship
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class Relationship {
  @SerializedName("relationshipName")
  private String relationshipName = null;

  @SerializedName("relationshipType")
  private String relationshipType = null;

  public Relationship relationshipName(String relationshipName) {
    this.relationshipName = relationshipName;
    return this;
  }

   /**
   * The relationship name for a customer
   * @return relationshipName
  **/
  @Schema(example = "Javier Perez Cuellar- Individual", description = "The relationship name for a customer")
  public String getRelationshipName() {
    return relationshipName;
  }

  public void setRelationshipName(String relationshipName) {
    this.relationshipName = relationshipName;
  }

  public Relationship relationshipType(String relationshipType) {
    this.relationshipType = relationshipType;
    return this;
  }

   /**
   * This is a reference data field. Please use /v1/apac/utilities/referenceData/{relationshipType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return relationshipType
  **/
  @Schema(example = "SOLE_OWNER", description = "This is a reference data field. Please use /v1/apac/utilities/referenceData/{relationshipType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getRelationshipType() {
    return relationshipType;
  }

  public void setRelationshipType(String relationshipType) {
    this.relationshipType = relationshipType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Relationship relationship = (Relationship) o;
    return Objects.equals(this.relationshipName, relationship.relationshipName) &&
        Objects.equals(this.relationshipType, relationship.relationshipType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(relationshipName, relationshipType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Relationship {\n");
    
    sb.append("    relationshipName: ").append(toIndentedString(relationshipName)).append("\n");
    sb.append("    relationshipType: ").append(toIndentedString(relationshipType)).append("\n");
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
