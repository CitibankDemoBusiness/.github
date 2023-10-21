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
import io.swagger.client.model.Product;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ProductCatalogueResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ProductCatalogueResponse {
  @SerializedName("products")
  private List<Product> products = new ArrayList<Product>();

  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  public ProductCatalogueResponse products(List<Product> products) {
    this.products = products;
    return this;
  }

  public ProductCatalogueResponse addProductsItem(Product productsItem) {
    this.products.add(productsItem);
    return this;
  }

   /**
   * Get products
   * @return products
  **/
  @Schema(required = true, description = "")
  public List<Product> getProducts() {
    return products;
  }

  public void setProducts(List<Product> products) {
    this.products = products;
  }

  public ProductCatalogueResponse nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * The next start index of the next subset of products.
   * @return nextStartIndex
  **/
  @Schema(example = "11", description = "The next start index of the next subset of products.")
  public String getNextStartIndex() {
    return nextStartIndex;
  }

  public void setNextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ProductCatalogueResponse productCatalogueResponse = (ProductCatalogueResponse) o;
    return Objects.equals(this.products, productCatalogueResponse.products) &&
        Objects.equals(this.nextStartIndex, productCatalogueResponse.nextStartIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(products, nextStartIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProductCatalogueResponse {\n");
    
    sb.append("    products: ").append(toIndentedString(products)).append("\n");
    sb.append("    nextStartIndex: ").append(toIndentedString(nextStartIndex)).append("\n");
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