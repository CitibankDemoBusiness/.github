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
import io.swagger.client.model.CounterOffer;
import io.swagger.client.model.CrossSellOffer;
import io.swagger.client.model.RequestedProductDecision;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.threeten.bp.LocalDate;
/**
 * InPrincipleApprovalResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class InPrincipleApprovalResponse {
  @SerializedName("applicationStage")
  private String applicationStage = null;

  @SerializedName("ipaExpiryDate")
  private LocalDate ipaExpiryDate = null;

  @SerializedName("requestedProductDecision")
  private List<RequestedProductDecision> requestedProductDecision = null;

  @SerializedName("counterOffers")
  private List<CounterOffer> counterOffers = null;

  @SerializedName("crossSellOffers")
  private List<CrossSellOffer> crossSellOffers = null;

  public InPrincipleApprovalResponse applicationStage(String applicationStage) {
    this.applicationStage = applicationStage;
    return this;
  }

   /**
   * Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.
   * @return applicationStage
  **/
  @Schema(example = "PRESCREENING", required = true, description = "Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.")
  public String getApplicationStage() {
    return applicationStage;
  }

  public void setApplicationStage(String applicationStage) {
    this.applicationStage = applicationStage;
  }

  public InPrincipleApprovalResponse ipaExpiryDate(LocalDate ipaExpiryDate) {
    this.ipaExpiryDate = ipaExpiryDate;
    return this;
  }

   /**
   * In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD
   * @return ipaExpiryDate
  **/
  @Schema(example = "Sat Sep 15 00:00:00 UTC 2018", description = "In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD")
  public LocalDate getIpaExpiryDate() {
    return ipaExpiryDate;
  }

  public void setIpaExpiryDate(LocalDate ipaExpiryDate) {
    this.ipaExpiryDate = ipaExpiryDate;
  }

  public InPrincipleApprovalResponse requestedProductDecision(List<RequestedProductDecision> requestedProductDecision) {
    this.requestedProductDecision = requestedProductDecision;
    return this;
  }

  public InPrincipleApprovalResponse addRequestedProductDecisionItem(RequestedProductDecision requestedProductDecisionItem) {
    if (this.requestedProductDecision == null) {
      this.requestedProductDecision = new ArrayList<RequestedProductDecision>();
    }
    this.requestedProductDecision.add(requestedProductDecisionItem);
    return this;
  }

   /**
   * Get requestedProductDecision
   * @return requestedProductDecision
  **/
  @Schema(description = "")
  public List<RequestedProductDecision> getRequestedProductDecision() {
    return requestedProductDecision;
  }

  public void setRequestedProductDecision(List<RequestedProductDecision> requestedProductDecision) {
    this.requestedProductDecision = requestedProductDecision;
  }

  public InPrincipleApprovalResponse counterOffers(List<CounterOffer> counterOffers) {
    this.counterOffers = counterOffers;
    return this;
  }

  public InPrincipleApprovalResponse addCounterOffersItem(CounterOffer counterOffersItem) {
    if (this.counterOffers == null) {
      this.counterOffers = new ArrayList<CounterOffer>();
    }
    this.counterOffers.add(counterOffersItem);
    return this;
  }

   /**
   * Get counterOffers
   * @return counterOffers
  **/
  @Schema(description = "")
  public List<CounterOffer> getCounterOffers() {
    return counterOffers;
  }

  public void setCounterOffers(List<CounterOffer> counterOffers) {
    this.counterOffers = counterOffers;
  }

  public InPrincipleApprovalResponse crossSellOffers(List<CrossSellOffer> crossSellOffers) {
    this.crossSellOffers = crossSellOffers;
    return this;
  }

  public InPrincipleApprovalResponse addCrossSellOffersItem(CrossSellOffer crossSellOffersItem) {
    if (this.crossSellOffers == null) {
      this.crossSellOffers = new ArrayList<CrossSellOffer>();
    }
    this.crossSellOffers.add(crossSellOffersItem);
    return this;
  }

   /**
   * Get crossSellOffers
   * @return crossSellOffers
  **/
  @Schema(description = "")
  public List<CrossSellOffer> getCrossSellOffers() {
    return crossSellOffers;
  }

  public void setCrossSellOffers(List<CrossSellOffer> crossSellOffers) {
    this.crossSellOffers = crossSellOffers;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InPrincipleApprovalResponse inPrincipleApprovalResponse = (InPrincipleApprovalResponse) o;
    return Objects.equals(this.applicationStage, inPrincipleApprovalResponse.applicationStage) &&
        Objects.equals(this.ipaExpiryDate, inPrincipleApprovalResponse.ipaExpiryDate) &&
        Objects.equals(this.requestedProductDecision, inPrincipleApprovalResponse.requestedProductDecision) &&
        Objects.equals(this.counterOffers, inPrincipleApprovalResponse.counterOffers) &&
        Objects.equals(this.crossSellOffers, inPrincipleApprovalResponse.crossSellOffers);
  }

  @Override
  public int hashCode() {
    return Objects.hash(applicationStage, ipaExpiryDate, requestedProductDecision, counterOffers, crossSellOffers);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InPrincipleApprovalResponse {\n");
    
    sb.append("    applicationStage: ").append(toIndentedString(applicationStage)).append("\n");
    sb.append("    ipaExpiryDate: ").append(toIndentedString(ipaExpiryDate)).append("\n");
    sb.append("    requestedProductDecision: ").append(toIndentedString(requestedProductDecision)).append("\n");
    sb.append("    counterOffers: ").append(toIndentedString(counterOffers)).append("\n");
    sb.append("    crossSellOffers: ").append(toIndentedString(crossSellOffers)).append("\n");
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
