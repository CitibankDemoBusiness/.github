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
import io.swagger.client.model.ApplicationAddCreditCardProduct;
import io.swagger.client.model.ApplicationAddReadyCreditProduct;
import io.swagger.client.model.ApplicationAddUnsecuredLoanProduct;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ApplicationAddProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddProduct {
  @SerializedName("creditCardProduct")
  private ApplicationAddCreditCardProduct creditCardProduct = null;

  @SerializedName("readyCreditProduct")
  private ApplicationAddReadyCreditProduct readyCreditProduct = null;

  @SerializedName("unsecuredLoanProduct")
  private ApplicationAddUnsecuredLoanProduct unsecuredLoanProduct = null;

  public ApplicationAddProduct creditCardProduct(ApplicationAddCreditCardProduct creditCardProduct) {
    this.creditCardProduct = creditCardProduct;
    return this;
  }

   /**
   * Get creditCardProduct
   * @return creditCardProduct
  **/
  @Schema(description = "")
  public ApplicationAddCreditCardProduct getCreditCardProduct() {
    return creditCardProduct;
  }

  public void setCreditCardProduct(ApplicationAddCreditCardProduct creditCardProduct) {
    this.creditCardProduct = creditCardProduct;
  }

  public ApplicationAddProduct readyCreditProduct(ApplicationAddReadyCreditProduct readyCreditProduct) {
    this.readyCreditProduct = readyCreditProduct;
    return this;
  }

   /**
   * Get readyCreditProduct
   * @return readyCreditProduct
  **/
  @Schema(description = "")
  public ApplicationAddReadyCreditProduct getReadyCreditProduct() {
    return readyCreditProduct;
  }

  public void setReadyCreditProduct(ApplicationAddReadyCreditProduct readyCreditProduct) {
    this.readyCreditProduct = readyCreditProduct;
  }

  public ApplicationAddProduct unsecuredLoanProduct(ApplicationAddUnsecuredLoanProduct unsecuredLoanProduct) {
    this.unsecuredLoanProduct = unsecuredLoanProduct;
    return this;
  }

   /**
   * Get unsecuredLoanProduct
   * @return unsecuredLoanProduct
  **/
  @Schema(description = "")
  public ApplicationAddUnsecuredLoanProduct getUnsecuredLoanProduct() {
    return unsecuredLoanProduct;
  }

  public void setUnsecuredLoanProduct(ApplicationAddUnsecuredLoanProduct unsecuredLoanProduct) {
    this.unsecuredLoanProduct = unsecuredLoanProduct;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddProduct applicationAddProduct = (ApplicationAddProduct) o;
    return Objects.equals(this.creditCardProduct, applicationAddProduct.creditCardProduct) &&
        Objects.equals(this.readyCreditProduct, applicationAddProduct.readyCreditProduct) &&
        Objects.equals(this.unsecuredLoanProduct, applicationAddProduct.unsecuredLoanProduct);
  }

  @Override
  public int hashCode() {
    return Objects.hash(creditCardProduct, readyCreditProduct, unsecuredLoanProduct);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddProduct {\n");
    
    sb.append("    creditCardProduct: ").append(toIndentedString(creditCardProduct)).append("\n");
    sb.append("    readyCreditProduct: ").append(toIndentedString(readyCreditProduct)).append("\n");
    sb.append("    unsecuredLoanProduct: ").append(toIndentedString(unsecuredLoanProduct)).append("\n");
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