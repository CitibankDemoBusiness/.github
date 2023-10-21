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
import io.swagger.client.model.ApplicationAddApplicant;
import io.swagger.client.model.ApplicationAddProduct;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ApplicationAddRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddRequest {
  @SerializedName("product")
  private ApplicationAddProduct product = null;

  @SerializedName("applicant")
  private ApplicationAddApplicant applicant = null;

  public ApplicationAddRequest product(ApplicationAddProduct product) {
    this.product = product;
    return this;
  }

   /**
   * Get product
   * @return product
  **/
  @Schema(required = true, description = "")
  public ApplicationAddProduct getProduct() {
    return product;
  }

  public void setProduct(ApplicationAddProduct product) {
    this.product = product;
  }

  public ApplicationAddRequest applicant(ApplicationAddApplicant applicant) {
    this.applicant = applicant;
    return this;
  }

   /**
   * Get applicant
   * @return applicant
  **/
  @Schema(required = true, description = "")
  public ApplicationAddApplicant getApplicant() {
    return applicant;
  }

  public void setApplicant(ApplicationAddApplicant applicant) {
    this.applicant = applicant;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddRequest applicationAddRequest = (ApplicationAddRequest) o;
    return Objects.equals(this.product, applicationAddRequest.product) &&
        Objects.equals(this.applicant, applicationAddRequest.applicant);
  }

  @Override
  public int hashCode() {
    return Objects.hash(product, applicant);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddRequest {\n");
    
    sb.append("    product: ").append(toIndentedString(product)).append("\n");
    sb.append("    applicant: ").append(toIndentedString(applicant)).append("\n");
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
