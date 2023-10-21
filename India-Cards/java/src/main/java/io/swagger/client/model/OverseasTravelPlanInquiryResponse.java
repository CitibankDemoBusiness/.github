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
import io.swagger.client.model.TravelPlan;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * OverseasTravelPlanInquiryResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class OverseasTravelPlanInquiryResponse {
  @SerializedName("travelPlan")
  private List<TravelPlan> travelPlan = null;

  public OverseasTravelPlanInquiryResponse travelPlan(List<TravelPlan> travelPlan) {
    this.travelPlan = travelPlan;
    return this;
  }

  public OverseasTravelPlanInquiryResponse addTravelPlanItem(TravelPlan travelPlanItem) {
    if (this.travelPlan == null) {
      this.travelPlan = new ArrayList<TravelPlan>();
    }
    this.travelPlan.add(travelPlanItem);
    return this;
  }

   /**
   * Get travelPlan
   * @return travelPlan
  **/
  @Schema(description = "")
  public List<TravelPlan> getTravelPlan() {
    return travelPlan;
  }

  public void setTravelPlan(List<TravelPlan> travelPlan) {
    this.travelPlan = travelPlan;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OverseasTravelPlanInquiryResponse overseasTravelPlanInquiryResponse = (OverseasTravelPlanInquiryResponse) o;
    return Objects.equals(this.travelPlan, overseasTravelPlanInquiryResponse.travelPlan);
  }

  @Override
  public int hashCode() {
    return Objects.hash(travelPlan);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OverseasTravelPlanInquiryResponse {\n");
    
    sb.append("    travelPlan: ").append(toIndentedString(travelPlan)).append("\n");
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
