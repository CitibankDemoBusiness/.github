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
import io.swagger.client.model.CreditSpecificRecommendations;
import io.swagger.client.model.LoanSpecificRecommendations;
import io.swagger.client.model.RequiredDocuments;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationStatusInqRequestedProductDecision
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationStatusInqRequestedProductDecision {
  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("organisationName")
  private String organisationName = null;

  @SerializedName("sourceCode")
  private String sourceCode = null;

  @SerializedName("creditDecision")
  private String creditDecision = null;

  @SerializedName("creditSpecificRecommendations")
  private List<CreditSpecificRecommendations> creditSpecificRecommendations = null;

  @SerializedName("loanSpecificRecommendations")
  private List<LoanSpecificRecommendations> loanSpecificRecommendations = null;

  @SerializedName("requiredDocuments")
  private List<RequiredDocuments> requiredDocuments = null;

  public ApplicationStatusInqRequestedProductDecision productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "VC830", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ApplicationStatusInqRequestedProductDecision organisationName(String organisationName) {
    this.organisationName = organisationName;
    return this;
  }

   /**
   * Card issuing Organisation
   * @return organisationName
  **/
  @Schema(example = "111", description = "Card issuing Organisation")
  public String getOrganisationName() {
    return organisationName;
  }

  public void setOrganisationName(String organisationName) {
    this.organisationName = organisationName;
  }

  public ApplicationStatusInqRequestedProductDecision sourceCode(String sourceCode) {
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

  public ApplicationStatusInqRequestedProductDecision creditDecision(String creditDecision) {
    this.creditDecision = creditDecision;
    return this;
  }

   /**
   * Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description.
   * @return creditDecision
  **/
  @Schema(example = "IN_PRINCIPAL_APPROVED_PARTIAL", description = "Evaluated Applicant Credit Decision. This is a reference data field. Please use /v1/apac/utilities/referenceData/{creditDecision} resource to get valid value of this field with description.")
  public String getCreditDecision() {
    return creditDecision;
  }

  public void setCreditDecision(String creditDecision) {
    this.creditDecision = creditDecision;
  }

  public ApplicationStatusInqRequestedProductDecision creditSpecificRecommendations(List<CreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
    return this;
  }

  public ApplicationStatusInqRequestedProductDecision addCreditSpecificRecommendationsItem(CreditSpecificRecommendations creditSpecificRecommendationsItem) {
    if (this.creditSpecificRecommendations == null) {
      this.creditSpecificRecommendations = new ArrayList<CreditSpecificRecommendations>();
    }
    this.creditSpecificRecommendations.add(creditSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get creditSpecificRecommendations
   * @return creditSpecificRecommendations
  **/
  @Schema(description = "")
  public List<CreditSpecificRecommendations> getCreditSpecificRecommendations() {
    return creditSpecificRecommendations;
  }

  public void setCreditSpecificRecommendations(List<CreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
  }

  public ApplicationStatusInqRequestedProductDecision loanSpecificRecommendations(List<LoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
    return this;
  }

  public ApplicationStatusInqRequestedProductDecision addLoanSpecificRecommendationsItem(LoanSpecificRecommendations loanSpecificRecommendationsItem) {
    if (this.loanSpecificRecommendations == null) {
      this.loanSpecificRecommendations = new ArrayList<LoanSpecificRecommendations>();
    }
    this.loanSpecificRecommendations.add(loanSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get loanSpecificRecommendations
   * @return loanSpecificRecommendations
  **/
  @Schema(description = "")
  public List<LoanSpecificRecommendations> getLoanSpecificRecommendations() {
    return loanSpecificRecommendations;
  }

  public void setLoanSpecificRecommendations(List<LoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
  }

  public ApplicationStatusInqRequestedProductDecision requiredDocuments(List<RequiredDocuments> requiredDocuments) {
    this.requiredDocuments = requiredDocuments;
    return this;
  }

  public ApplicationStatusInqRequestedProductDecision addRequiredDocumentsItem(RequiredDocuments requiredDocumentsItem) {
    if (this.requiredDocuments == null) {
      this.requiredDocuments = new ArrayList<RequiredDocuments>();
    }
    this.requiredDocuments.add(requiredDocumentsItem);
    return this;
  }

   /**
   * Get requiredDocuments
   * @return requiredDocuments
  **/
  @Schema(description = "")
  public List<RequiredDocuments> getRequiredDocuments() {
    return requiredDocuments;
  }

  public void setRequiredDocuments(List<RequiredDocuments> requiredDocuments) {
    this.requiredDocuments = requiredDocuments;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationStatusInqRequestedProductDecision applicationStatusInqRequestedProductDecision = (ApplicationStatusInqRequestedProductDecision) o;
    return Objects.equals(this.productCode, applicationStatusInqRequestedProductDecision.productCode) &&
        Objects.equals(this.organisationName, applicationStatusInqRequestedProductDecision.organisationName) &&
        Objects.equals(this.sourceCode, applicationStatusInqRequestedProductDecision.sourceCode) &&
        Objects.equals(this.creditDecision, applicationStatusInqRequestedProductDecision.creditDecision) &&
        Objects.equals(this.creditSpecificRecommendations, applicationStatusInqRequestedProductDecision.creditSpecificRecommendations) &&
        Objects.equals(this.loanSpecificRecommendations, applicationStatusInqRequestedProductDecision.loanSpecificRecommendations) &&
        Objects.equals(this.requiredDocuments, applicationStatusInqRequestedProductDecision.requiredDocuments);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, organisationName, sourceCode, creditDecision, creditSpecificRecommendations, loanSpecificRecommendations, requiredDocuments);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationStatusInqRequestedProductDecision {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    organisationName: ").append(toIndentedString(organisationName)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    creditDecision: ").append(toIndentedString(creditDecision)).append("\n");
    sb.append("    creditSpecificRecommendations: ").append(toIndentedString(creditSpecificRecommendations)).append("\n");
    sb.append("    loanSpecificRecommendations: ").append(toIndentedString(loanSpecificRecommendations)).append("\n");
    sb.append("    requiredDocuments: ").append(toIndentedString(requiredDocuments)).append("\n");
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
