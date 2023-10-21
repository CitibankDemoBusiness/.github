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
import io.swagger.client.model.ApplicationInquiryCreditSpecificRecommendations;
import io.swagger.client.model.ApplicationInquiryLoanSpecificRecommendations;
import io.swagger.client.model.ApplicationInquiryRequiredDocuments;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationInquiryCrossSellOffer
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryCrossSellOffer {
  @SerializedName("offerProductCode")
  private String offerProductCode = null;

  @SerializedName("offerProductOrganisation")
  private String offerProductOrganisation = null;

  @SerializedName("offerSourceCode")
  private String offerSourceCode = null;

  @SerializedName("creditSpecificRecommendations")
  private List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations = null;

  @SerializedName("loanSpecificRecommendations")
  private List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations = null;

  @SerializedName("requiredDocuments")
  private List<ApplicationInquiryRequiredDocuments> requiredDocuments = null;

  public ApplicationInquiryCrossSellOffer offerProductCode(String offerProductCode) {
    this.offerProductCode = offerProductCode;
    return this;
  }

   /**
   * A unique code that identifies the offered product to applicant
   * @return offerProductCode
  **/
  @Schema(example = "VC311", description = "A unique code that identifies the offered product to applicant")
  public String getOfferProductCode() {
    return offerProductCode;
  }

  public void setOfferProductCode(String offerProductCode) {
    this.offerProductCode = offerProductCode;
  }

  public ApplicationInquiryCrossSellOffer offerProductOrganisation(String offerProductOrganisation) {
    this.offerProductOrganisation = offerProductOrganisation;
    return this;
  }

   /**
   * Offered card issuing organization name
   * @return offerProductOrganisation
  **/
  @Schema(example = "888", description = "Offered card issuing organization name")
  public String getOfferProductOrganisation() {
    return offerProductOrganisation;
  }

  public void setOfferProductOrganisation(String offerProductOrganisation) {
    this.offerProductOrganisation = offerProductOrganisation;
  }

  public ApplicationInquiryCrossSellOffer offerSourceCode(String offerSourceCode) {
    this.offerSourceCode = offerSourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return offerSourceCode
  **/
  @Schema(example = "WW5ARDE1", description = "A source code to identify the product")
  public String getOfferSourceCode() {
    return offerSourceCode;
  }

  public void setOfferSourceCode(String offerSourceCode) {
    this.offerSourceCode = offerSourceCode;
  }

  public ApplicationInquiryCrossSellOffer creditSpecificRecommendations(List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
    return this;
  }

  public ApplicationInquiryCrossSellOffer addCreditSpecificRecommendationsItem(ApplicationInquiryCreditSpecificRecommendations creditSpecificRecommendationsItem) {
    if (this.creditSpecificRecommendations == null) {
      this.creditSpecificRecommendations = new ArrayList<ApplicationInquiryCreditSpecificRecommendations>();
    }
    this.creditSpecificRecommendations.add(creditSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get creditSpecificRecommendations
   * @return creditSpecificRecommendations
  **/
  @Schema(description = "")
  public List<ApplicationInquiryCreditSpecificRecommendations> getCreditSpecificRecommendations() {
    return creditSpecificRecommendations;
  }

  public void setCreditSpecificRecommendations(List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
  }

  public ApplicationInquiryCrossSellOffer loanSpecificRecommendations(List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
    return this;
  }

  public ApplicationInquiryCrossSellOffer addLoanSpecificRecommendationsItem(ApplicationInquiryLoanSpecificRecommendations loanSpecificRecommendationsItem) {
    if (this.loanSpecificRecommendations == null) {
      this.loanSpecificRecommendations = new ArrayList<ApplicationInquiryLoanSpecificRecommendations>();
    }
    this.loanSpecificRecommendations.add(loanSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get loanSpecificRecommendations
   * @return loanSpecificRecommendations
  **/
  @Schema(description = "")
  public List<ApplicationInquiryLoanSpecificRecommendations> getLoanSpecificRecommendations() {
    return loanSpecificRecommendations;
  }

  public void setLoanSpecificRecommendations(List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
  }

  public ApplicationInquiryCrossSellOffer requiredDocuments(List<ApplicationInquiryRequiredDocuments> requiredDocuments) {
    this.requiredDocuments = requiredDocuments;
    return this;
  }

  public ApplicationInquiryCrossSellOffer addRequiredDocumentsItem(ApplicationInquiryRequiredDocuments requiredDocumentsItem) {
    if (this.requiredDocuments == null) {
      this.requiredDocuments = new ArrayList<ApplicationInquiryRequiredDocuments>();
    }
    this.requiredDocuments.add(requiredDocumentsItem);
    return this;
  }

   /**
   * Get requiredDocuments
   * @return requiredDocuments
  **/
  @Schema(description = "")
  public List<ApplicationInquiryRequiredDocuments> getRequiredDocuments() {
    return requiredDocuments;
  }

  public void setRequiredDocuments(List<ApplicationInquiryRequiredDocuments> requiredDocuments) {
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
    ApplicationInquiryCrossSellOffer applicationInquiryCrossSellOffer = (ApplicationInquiryCrossSellOffer) o;
    return Objects.equals(this.offerProductCode, applicationInquiryCrossSellOffer.offerProductCode) &&
        Objects.equals(this.offerProductOrganisation, applicationInquiryCrossSellOffer.offerProductOrganisation) &&
        Objects.equals(this.offerSourceCode, applicationInquiryCrossSellOffer.offerSourceCode) &&
        Objects.equals(this.creditSpecificRecommendations, applicationInquiryCrossSellOffer.creditSpecificRecommendations) &&
        Objects.equals(this.loanSpecificRecommendations, applicationInquiryCrossSellOffer.loanSpecificRecommendations) &&
        Objects.equals(this.requiredDocuments, applicationInquiryCrossSellOffer.requiredDocuments);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerProductCode, offerProductOrganisation, offerSourceCode, creditSpecificRecommendations, loanSpecificRecommendations, requiredDocuments);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryCrossSellOffer {\n");
    
    sb.append("    offerProductCode: ").append(toIndentedString(offerProductCode)).append("\n");
    sb.append("    offerProductOrganisation: ").append(toIndentedString(offerProductOrganisation)).append("\n");
    sb.append("    offerSourceCode: ").append(toIndentedString(offerSourceCode)).append("\n");
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