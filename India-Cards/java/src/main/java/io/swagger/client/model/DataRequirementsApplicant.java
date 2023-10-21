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
import io.swagger.client.model.DataRequirementsDocument;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * DataRequirementsApplicant
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class DataRequirementsApplicant {
  /**
   * Type of the card application
   */
  @JsonAdapter(ApplicationTypeEnum.Adapter.class)
  public enum ApplicationTypeEnum {
    PRINCIPAL("principal"),
    SUPPLEMENTARY("supplementary"),
    ANY("any");

    private String value;

    ApplicationTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static ApplicationTypeEnum fromValue(String text) {
      for (ApplicationTypeEnum b : ApplicationTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<ApplicationTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ApplicationTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ApplicationTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return ApplicationTypeEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("application_type")
  private ApplicationTypeEnum applicationType = null;

  /**
   * Employment status of the applicant
   */
  @JsonAdapter(EmploymentStatusEnum.Adapter.class)
  public enum EmploymentStatusEnum {
    EMPLOYED("employed"),
    SELF_EMPLOYED("self_employed"),
    GRADUATE("graduate"),
    OTHERS("others"),
    ANY("any");

    private String value;

    EmploymentStatusEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static EmploymentStatusEnum fromValue(String text) {
      for (EmploymentStatusEnum b : EmploymentStatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<EmploymentStatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final EmploymentStatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public EmploymentStatusEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return EmploymentStatusEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("employment_status")
  private EmploymentStatusEnum employmentStatus = null;

  @SerializedName("min_age")
  private Integer minAge = null;

  @SerializedName("max_age")
  private Integer maxAge = null;

  @SerializedName("min_annual_income")
  private Integer minAnnualIncome = null;

  @SerializedName("min_annual_income_currency_code")
  private String minAnnualIncomeCurrencyCode = "MYR";

  @SerializedName("document")
  private List<DataRequirementsDocument> document = null;

  public DataRequirementsApplicant applicationType(ApplicationTypeEnum applicationType) {
    this.applicationType = applicationType;
    return this;
  }

   /**
   * Type of the card application
   * @return applicationType
  **/
  @Schema(example = "principal", required = true, description = "Type of the card application")
  public ApplicationTypeEnum getApplicationType() {
    return applicationType;
  }

  public void setApplicationType(ApplicationTypeEnum applicationType) {
    this.applicationType = applicationType;
  }

  public DataRequirementsApplicant employmentStatus(EmploymentStatusEnum employmentStatus) {
    this.employmentStatus = employmentStatus;
    return this;
  }

   /**
   * Employment status of the applicant
   * @return employmentStatus
  **/
  @Schema(description = "Employment status of the applicant")
  public EmploymentStatusEnum getEmploymentStatus() {
    return employmentStatus;
  }

  public void setEmploymentStatus(EmploymentStatusEnum employmentStatus) {
    this.employmentStatus = employmentStatus;
  }

  public DataRequirementsApplicant minAge(Integer minAge) {
    this.minAge = minAge;
    return this;
  }

   /**
   * Minimum age of applicant
   * minimum: 1
   * maximum: 110
   * @return minAge
  **/
  @Schema(example = "21", description = "Minimum age of applicant")
  public Integer getMinAge() {
    return minAge;
  }

  public void setMinAge(Integer minAge) {
    this.minAge = minAge;
  }

  public DataRequirementsApplicant maxAge(Integer maxAge) {
    this.maxAge = maxAge;
    return this;
  }

   /**
   * Maximum age of applicant
   * minimum: 1
   * maximum: 110
   * @return maxAge
  **/
  @Schema(example = "65", description = "Maximum age of applicant")
  public Integer getMaxAge() {
    return maxAge;
  }

  public void setMaxAge(Integer maxAge) {
    this.maxAge = maxAge;
  }

  public DataRequirementsApplicant minAnnualIncome(Integer minAnnualIncome) {
    this.minAnnualIncome = minAnnualIncome;
    return this;
  }

   /**
   * Minimum annual income
   * @return minAnnualIncome
  **/
  @Schema(example = "70000", description = "Minimum annual income")
  public Integer getMinAnnualIncome() {
    return minAnnualIncome;
  }

  public void setMinAnnualIncome(Integer minAnnualIncome) {
    this.minAnnualIncome = minAnnualIncome;
  }

  public DataRequirementsApplicant minAnnualIncomeCurrencyCode(String minAnnualIncomeCurrencyCode) {
    this.minAnnualIncomeCurrencyCode = minAnnualIncomeCurrencyCode;
    return this;
  }

   /**
   * ISO-4217 3 characters currency code for minimum annual income
   * @return minAnnualIncomeCurrencyCode
  **/
  @Schema(description = "ISO-4217 3 characters currency code for minimum annual income")
  public String getMinAnnualIncomeCurrencyCode() {
    return minAnnualIncomeCurrencyCode;
  }

  public void setMinAnnualIncomeCurrencyCode(String minAnnualIncomeCurrencyCode) {
    this.minAnnualIncomeCurrencyCode = minAnnualIncomeCurrencyCode;
  }

  public DataRequirementsApplicant document(List<DataRequirementsDocument> document) {
    this.document = document;
    return this;
  }

  public DataRequirementsApplicant addDocumentItem(DataRequirementsDocument documentItem) {
    if (this.document == null) {
      this.document = new ArrayList<DataRequirementsDocument>();
    }
    this.document.add(documentItem);
    return this;
  }

   /**
   * Get document
   * @return document
  **/
  @Schema(description = "")
  public List<DataRequirementsDocument> getDocument() {
    return document;
  }

  public void setDocument(List<DataRequirementsDocument> document) {
    this.document = document;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DataRequirementsApplicant dataRequirementsApplicant = (DataRequirementsApplicant) o;
    return Objects.equals(this.applicationType, dataRequirementsApplicant.applicationType) &&
        Objects.equals(this.employmentStatus, dataRequirementsApplicant.employmentStatus) &&
        Objects.equals(this.minAge, dataRequirementsApplicant.minAge) &&
        Objects.equals(this.maxAge, dataRequirementsApplicant.maxAge) &&
        Objects.equals(this.minAnnualIncome, dataRequirementsApplicant.minAnnualIncome) &&
        Objects.equals(this.minAnnualIncomeCurrencyCode, dataRequirementsApplicant.minAnnualIncomeCurrencyCode) &&
        Objects.equals(this.document, dataRequirementsApplicant.document);
  }

  @Override
  public int hashCode() {
    return Objects.hash(applicationType, employmentStatus, minAge, maxAge, minAnnualIncome, minAnnualIncomeCurrencyCode, document);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DataRequirementsApplicant {\n");
    
    sb.append("    applicationType: ").append(toIndentedString(applicationType)).append("\n");
    sb.append("    employmentStatus: ").append(toIndentedString(employmentStatus)).append("\n");
    sb.append("    minAge: ").append(toIndentedString(minAge)).append("\n");
    sb.append("    maxAge: ").append(toIndentedString(maxAge)).append("\n");
    sb.append("    minAnnualIncome: ").append(toIndentedString(minAnnualIncome)).append("\n");
    sb.append("    minAnnualIncomeCurrencyCode: ").append(toIndentedString(minAnnualIncomeCurrencyCode)).append("\n");
    sb.append("    document: ").append(toIndentedString(document)).append("\n");
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
