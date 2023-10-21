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
/**
 * ApplicationAddEmail
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddEmail {
  @SerializedName("emailAddress")
  private String emailAddress = null;

  @SerializedName("okToEmail")
  private Boolean okToEmail = null;

  @SerializedName("isPreferredEmailAddress")
  private Boolean isPreferredEmailAddress = null;

  public ApplicationAddEmail emailAddress(String emailAddress) {
    this.emailAddress = emailAddress;
    return this;
  }

   /**
   * Applicant&#x27;s email address
   * @return emailAddress
  **/
  @Schema(example = "matt.hayden@gmail.com", required = true, description = "Applicant's email address")
  public String getEmailAddress() {
    return emailAddress;
  }

  public void setEmailAddress(String emailAddress) {
    this.emailAddress = emailAddress;
  }

  public ApplicationAddEmail okToEmail(Boolean okToEmail) {
    this.okToEmail = okToEmail;
    return this;
  }

   /**
   * Applicant&#x27;s consent for receiving email. Valid values: true and false
   * @return okToEmail
  **/
  @Schema(example = "true", description = "Applicant's consent for receiving email. Valid values: true and false")
  public Boolean isOkToEmail() {
    return okToEmail;
  }

  public void setOkToEmail(Boolean okToEmail) {
    this.okToEmail = okToEmail;
  }

  public ApplicationAddEmail isPreferredEmailAddress(Boolean isPreferredEmailAddress) {
    this.isPreferredEmailAddress = isPreferredEmailAddress;
    return this;
  }

   /**
   * Flag to mark preferred email. Valid values: true and false
   * @return isPreferredEmailAddress
  **/
  @Schema(example = "true", description = "Flag to mark preferred email. Valid values: true and false")
  public Boolean isIsPreferredEmailAddress() {
    return isPreferredEmailAddress;
  }

  public void setIsPreferredEmailAddress(Boolean isPreferredEmailAddress) {
    this.isPreferredEmailAddress = isPreferredEmailAddress;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddEmail applicationAddEmail = (ApplicationAddEmail) o;
    return Objects.equals(this.emailAddress, applicationAddEmail.emailAddress) &&
        Objects.equals(this.okToEmail, applicationAddEmail.okToEmail) &&
        Objects.equals(this.isPreferredEmailAddress, applicationAddEmail.isPreferredEmailAddress);
  }

  @Override
  public int hashCode() {
    return Objects.hash(emailAddress, okToEmail, isPreferredEmailAddress);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddEmail {\n");
    
    sb.append("    emailAddress: ").append(toIndentedString(emailAddress)).append("\n");
    sb.append("    okToEmail: ").append(toIndentedString(okToEmail)).append("\n");
    sb.append("    isPreferredEmailAddress: ").append(toIndentedString(isPreferredEmailAddress)).append("\n");
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