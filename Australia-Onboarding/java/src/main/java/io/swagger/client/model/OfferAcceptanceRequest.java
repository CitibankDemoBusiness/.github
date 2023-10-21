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
import io.swagger.client.model.ProductConfirmation;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * OfferAcceptanceRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class OfferAcceptanceRequest {
  @SerializedName("counterProductAcceptedFlag")
  private Boolean counterProductAcceptedFlag = null;

  @SerializedName("counterProductConfirmation")
  private List<ProductConfirmation> counterProductConfirmation = null;

  @SerializedName("requestedProductConfirmation")
  private List<ProductConfirmation> requestedProductConfirmation = new ArrayList<ProductConfirmation>();

  @SerializedName("controlFlowId")
  private String controlFlowId = null;

  public OfferAcceptanceRequest counterProductAcceptedFlag(Boolean counterProductAcceptedFlag) {
    this.counterProductAcceptedFlag = counterProductAcceptedFlag;
    return this;
  }

   /**
   * Flag to indicate a counter offer selected by an applicant. Valid values: true and false
   * @return counterProductAcceptedFlag
  **/
  @Schema(example = "true", description = "Flag to indicate a counter offer selected by an applicant. Valid values: true and false")
  public Boolean isCounterProductAcceptedFlag() {
    return counterProductAcceptedFlag;
  }

  public void setCounterProductAcceptedFlag(Boolean counterProductAcceptedFlag) {
    this.counterProductAcceptedFlag = counterProductAcceptedFlag;
  }

  public OfferAcceptanceRequest counterProductConfirmation(List<ProductConfirmation> counterProductConfirmation) {
    this.counterProductConfirmation = counterProductConfirmation;
    return this;
  }

  public OfferAcceptanceRequest addCounterProductConfirmationItem(ProductConfirmation counterProductConfirmationItem) {
    if (this.counterProductConfirmation == null) {
      this.counterProductConfirmation = new ArrayList<ProductConfirmation>();
    }
    this.counterProductConfirmation.add(counterProductConfirmationItem);
    return this;
  }

   /**
   * Get counterProductConfirmation
   * @return counterProductConfirmation
  **/
  @Schema(description = "")
  public List<ProductConfirmation> getCounterProductConfirmation() {
    return counterProductConfirmation;
  }

  public void setCounterProductConfirmation(List<ProductConfirmation> counterProductConfirmation) {
    this.counterProductConfirmation = counterProductConfirmation;
  }

  public OfferAcceptanceRequest requestedProductConfirmation(List<ProductConfirmation> requestedProductConfirmation) {
    this.requestedProductConfirmation = requestedProductConfirmation;
    return this;
  }

  public OfferAcceptanceRequest addRequestedProductConfirmationItem(ProductConfirmation requestedProductConfirmationItem) {
    this.requestedProductConfirmation.add(requestedProductConfirmationItem);
    return this;
  }

   /**
   * Get requestedProductConfirmation
   * @return requestedProductConfirmation
  **/
  @Schema(required = true, description = "")
  public List<ProductConfirmation> getRequestedProductConfirmation() {
    return requestedProductConfirmation;
  }

  public void setRequestedProductConfirmation(List<ProductConfirmation> requestedProductConfirmation) {
    this.requestedProductConfirmation = requestedProductConfirmation;
  }

  public OfferAcceptanceRequest controlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
    return this;
  }

   /**
   * Control Flow Id
   * @return controlFlowId
  **/
  @Schema(example = "6e3774334f724a2b7947663653712f52456f524c41797038516a59347a437549564a77755676376e616a733d", required = true, description = "Control Flow Id")
  public String getControlFlowId() {
    return controlFlowId;
  }

  public void setControlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OfferAcceptanceRequest offerAcceptanceRequest = (OfferAcceptanceRequest) o;
    return Objects.equals(this.counterProductAcceptedFlag, offerAcceptanceRequest.counterProductAcceptedFlag) &&
        Objects.equals(this.counterProductConfirmation, offerAcceptanceRequest.counterProductConfirmation) &&
        Objects.equals(this.requestedProductConfirmation, offerAcceptanceRequest.requestedProductConfirmation) &&
        Objects.equals(this.controlFlowId, offerAcceptanceRequest.controlFlowId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(counterProductAcceptedFlag, counterProductConfirmation, requestedProductConfirmation, controlFlowId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OfferAcceptanceRequest {\n");
    
    sb.append("    counterProductAcceptedFlag: ").append(toIndentedString(counterProductAcceptedFlag)).append("\n");
    sb.append("    counterProductConfirmation: ").append(toIndentedString(counterProductConfirmation)).append("\n");
    sb.append("    requestedProductConfirmation: ").append(toIndentedString(requestedProductConfirmation)).append("\n");
    sb.append("    controlFlowId: ").append(toIndentedString(controlFlowId)).append("\n");
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