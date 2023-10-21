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
import io.swagger.client.model.ApplicantDetail;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest {
  @SerializedName("applicantDetail")
  private ApplicantDetail applicantDetail = null;

  @SerializedName("loanPurpose")
  private String loanPurpose = null;

  public UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest applicantDetail(ApplicantDetail applicantDetail) {
    this.applicantDetail = applicantDetail;
    return this;
  }

   /**
   * Get applicantDetail
   * @return applicantDetail
  **/
  @Schema(description = "")
  public ApplicantDetail getApplicantDetail() {
    return applicantDetail;
  }

  public void setApplicantDetail(ApplicantDetail applicantDetail) {
    this.applicantDetail = applicantDetail;
  }

  public UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest loanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
    return this;
  }

   /**
   * This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
   * @return loanPurpose
  **/
  @Schema(example = "PERSONAL", description = "This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.")
  public String getLoanPurpose() {
    return loanPurpose;
  }

  public void setLoanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest updateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest = (UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest) o;
    return Objects.equals(this.applicantDetail, updateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.applicantDetail) &&
        Objects.equals(this.loanPurpose, updateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.loanPurpose);
  }

  @Override
  public int hashCode() {
    return Objects.hash(applicantDetail, loanPurpose);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest {\n");
    
    sb.append("    applicantDetail: ").append(toIndentedString(applicantDetail)).append("\n");
    sb.append("    loanPurpose: ").append(toIndentedString(loanPurpose)).append("\n");
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
