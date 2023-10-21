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
 * ECMName
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ECMName {
  @SerializedName("salutation")
  private String salutation = null;

  @SerializedName("givenName")
  private String givenName = null;

  @SerializedName("middleName")
  private String middleName = null;

  @SerializedName("surname")
  private String surname = null;

  public ECMName salutation(String salutation) {
    this.salutation = salutation;
    return this;
  }

   /**
   * Salutation. This is a reference data field. Please use /v1/utilities/referenceData/{salutation} resource to get valid value of this field with description.
   * @return salutation
  **/
  @Schema(example = "Mr", description = "Salutation. This is a reference data field. Please use /v1/utilities/referenceData/{salutation} resource to get valid value of this field with description.")
  public String getSalutation() {
    return salutation;
  }

  public void setSalutation(String salutation) {
    this.salutation = salutation;
  }

  public ECMName givenName(String givenName) {
    this.givenName = givenName;
    return this;
  }

   /**
   * Given/first name of the applicant
   * @return givenName
  **/
  @Schema(example = "Matthew", required = true, description = "Given/first name of the applicant")
  public String getGivenName() {
    return givenName;
  }

  public void setGivenName(String givenName) {
    this.givenName = givenName;
  }

  public ECMName middleName(String middleName) {
    this.middleName = middleName;
    return this;
  }

   /**
   * Middle name of the applicant
   * @return middleName
  **/
  @Schema(example = "Du", description = "Middle name of the applicant")
  public String getMiddleName() {
    return middleName;
  }

  public void setMiddleName(String middleName) {
    this.middleName = middleName;
  }

  public ECMName surname(String surname) {
    this.surname = surname;
    return this;
  }

   /**
   * Surname/last name of the applicant
   * @return surname
  **/
  @Schema(example = "Hayden", description = "Surname/last name of the applicant")
  public String getSurname() {
    return surname;
  }

  public void setSurname(String surname) {
    this.surname = surname;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ECMName ecMName = (ECMName) o;
    return Objects.equals(this.salutation, ecMName.salutation) &&
        Objects.equals(this.givenName, ecMName.givenName) &&
        Objects.equals(this.middleName, ecMName.middleName) &&
        Objects.equals(this.surname, ecMName.surname);
  }

  @Override
  public int hashCode() {
    return Objects.hash(salutation, givenName, middleName, surname);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ECMName {\n");
    
    sb.append("    salutation: ").append(toIndentedString(salutation)).append("\n");
    sb.append("    givenName: ").append(toIndentedString(givenName)).append("\n");
    sb.append("    middleName: ").append(toIndentedString(middleName)).append("\n");
    sb.append("    surname: ").append(toIndentedString(surname)).append("\n");
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