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
import org.threeten.bp.LocalDate;
/**
 * SupplementaryCardApplicationStatusInquiryResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class SupplementaryCardApplicationStatusInquiryResponse {
  @SerializedName("applicationStatus")
  private String applicationStatus = null;

  @SerializedName("applicationCreationDate")
  private LocalDate applicationCreationDate = null;

  public SupplementaryCardApplicationStatusInquiryResponse applicationStatus(String applicationStatus) {
    this.applicationStatus = applicationStatus;
    return this;
  }

   /**
   * Application Status of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStatus} resource to get possible value of this field with description.
   * @return applicationStatus
  **/
  @Schema(example = "AML_EXCEPTION", required = true, description = "Application Status of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStatus} resource to get possible value of this field with description.")
  public String getApplicationStatus() {
    return applicationStatus;
  }

  public void setApplicationStatus(String applicationStatus) {
    this.applicationStatus = applicationStatus;
  }

  public SupplementaryCardApplicationStatusInquiryResponse applicationCreationDate(LocalDate applicationCreationDate) {
    this.applicationCreationDate = applicationCreationDate;
    return this;
  }

   /**
   * Date on which the application was created in ISO 8601 date format YYYY - MM - DD.
   * @return applicationCreationDate
  **/
  @Schema(required = true, description = "Date on which the application was created in ISO 8601 date format YYYY - MM - DD.")
  public LocalDate getApplicationCreationDate() {
    return applicationCreationDate;
  }

  public void setApplicationCreationDate(LocalDate applicationCreationDate) {
    this.applicationCreationDate = applicationCreationDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SupplementaryCardApplicationStatusInquiryResponse supplementaryCardApplicationStatusInquiryResponse = (SupplementaryCardApplicationStatusInquiryResponse) o;
    return Objects.equals(this.applicationStatus, supplementaryCardApplicationStatusInquiryResponse.applicationStatus) &&
        Objects.equals(this.applicationCreationDate, supplementaryCardApplicationStatusInquiryResponse.applicationCreationDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(applicationStatus, applicationCreationDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SupplementaryCardApplicationStatusInquiryResponse {\n");
    
    sb.append("    applicationStatus: ").append(toIndentedString(applicationStatus)).append("\n");
    sb.append("    applicationCreationDate: ").append(toIndentedString(applicationCreationDate)).append("\n");
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