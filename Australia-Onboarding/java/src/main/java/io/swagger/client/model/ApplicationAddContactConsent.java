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
 * ApplicationAddContactConsent
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddContactConsent {
  @SerializedName("okToCall")
  private Boolean okToCall = null;

  @SerializedName("okToMail")
  private Boolean okToMail = null;

  @SerializedName("okToSms")
  private Boolean okToSms = null;

  public ApplicationAddContactConsent okToCall(Boolean okToCall) {
    this.okToCall = okToCall;
    return this;
  }

   /**
   * Applicant&#x27;s consent for receiving phone calls. Valid values: true and false
   * @return okToCall
  **/
  @Schema(example = "true", description = "Applicant's consent for receiving phone calls. Valid values: true and false")
  public Boolean isOkToCall() {
    return okToCall;
  }

  public void setOkToCall(Boolean okToCall) {
    this.okToCall = okToCall;
  }

  public ApplicationAddContactConsent okToMail(Boolean okToMail) {
    this.okToMail = okToMail;
    return this;
  }

   /**
   * Applicant&#x27;s consent for receiving mails. Valid values: true and false
   * @return okToMail
  **/
  @Schema(example = "true", description = "Applicant's consent for receiving mails. Valid values: true and false")
  public Boolean isOkToMail() {
    return okToMail;
  }

  public void setOkToMail(Boolean okToMail) {
    this.okToMail = okToMail;
  }

  public ApplicationAddContactConsent okToSms(Boolean okToSms) {
    this.okToSms = okToSms;
    return this;
  }

   /**
   * Applicant&#x27;s consent for receiving sms. Valid values: true and false
   * @return okToSms
  **/
  @Schema(example = "true", description = "Applicant's consent for receiving sms. Valid values: true and false")
  public Boolean isOkToSms() {
    return okToSms;
  }

  public void setOkToSms(Boolean okToSms) {
    this.okToSms = okToSms;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddContactConsent applicationAddContactConsent = (ApplicationAddContactConsent) o;
    return Objects.equals(this.okToCall, applicationAddContactConsent.okToCall) &&
        Objects.equals(this.okToMail, applicationAddContactConsent.okToMail) &&
        Objects.equals(this.okToSms, applicationAddContactConsent.okToSms);
  }

  @Override
  public int hashCode() {
    return Objects.hash(okToCall, okToMail, okToSms);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddContactConsent {\n");
    
    sb.append("    okToCall: ").append(toIndentedString(okToCall)).append("\n");
    sb.append("    okToMail: ").append(toIndentedString(okToMail)).append("\n");
    sb.append("    okToSms: ").append(toIndentedString(okToSms)).append("\n");
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
