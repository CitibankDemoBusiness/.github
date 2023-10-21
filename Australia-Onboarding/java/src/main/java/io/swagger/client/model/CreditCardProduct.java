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
 * CreditCardProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class CreditCardProduct {
  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("sourceCode")
  private String sourceCode = null;

  @SerializedName("organization")
  private String organization = null;

  @SerializedName("logo")
  private String logo = null;

  public CreditCardProduct productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product.
   * @return productCode
  **/
  @Schema(example = "VC830", description = "A unique code that identifies the product.")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public CreditCardProduct sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return sourceCode
  **/
  @Schema(example = "WW5ARCE1", description = "A source code to identify the product")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public CreditCardProduct organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Card issuing organization name
   * @return organization
  **/
  @Schema(example = "888", description = "Card issuing organization name")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public CreditCardProduct logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Product logo to identify the product
   * @return logo
  **/
  @Schema(example = "830", description = "Product logo to identify the product")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreditCardProduct creditCardProduct = (CreditCardProduct) o;
    return Objects.equals(this.productCode, creditCardProduct.productCode) &&
        Objects.equals(this.sourceCode, creditCardProduct.sourceCode) &&
        Objects.equals(this.organization, creditCardProduct.organization) &&
        Objects.equals(this.logo, creditCardProduct.logo);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreditCardProduct {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
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
