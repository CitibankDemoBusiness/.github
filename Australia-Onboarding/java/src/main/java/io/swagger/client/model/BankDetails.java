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
 * BankDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class BankDetails {
  @SerializedName("bankName")
  private String bankName = null;

  @SerializedName("bankCode")
  private String bankCode = null;

  @SerializedName("branchCode")
  private String branchCode = null;

  public BankDetails bankName(String bankName) {
    this.bankName = bankName;
    return this;
  }

   /**
   * Indicates the bank name of the customers account to which the loan amount will be transferred. Also, indicates the bank name of the customers account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description.
   * @return bankName
  **/
  @Schema(example = "Westpac Banking Corporation", description = "Indicates the bank name of the customers account to which the loan amount will be transferred. Also, indicates the bank name of the customers account from which the repayment of the loan will be debited. Please use /v1/utilities/referenceData/{bankName} resource to get valid value of this field with description.")
  public String getBankName() {
    return bankName;
  }

  public void setBankName(String bankName) {
    this.bankName = bankName;
  }

  public BankDetails bankCode(String bankCode) {
    this.bankCode = bankCode;
    return this;
  }

   /**
   * This field is to indicate the bank code.
   * @return bankCode
  **/
  @Schema(example = "101", description = "This field is to indicate the bank code.")
  public String getBankCode() {
    return bankCode;
  }

  public void setBankCode(String bankCode) {
    this.bankCode = bankCode;
  }

  public BankDetails branchCode(String branchCode) {
    this.branchCode = branchCode;
    return this;
  }

   /**
   * This field is to indicate the branch code.
   * @return branchCode
  **/
  @Schema(example = "242200", description = "This field is to indicate the branch code.")
  public String getBranchCode() {
    return branchCode;
  }

  public void setBranchCode(String branchCode) {
    this.branchCode = branchCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BankDetails bankDetails = (BankDetails) o;
    return Objects.equals(this.bankName, bankDetails.bankName) &&
        Objects.equals(this.bankCode, bankDetails.bankCode) &&
        Objects.equals(this.branchCode, bankDetails.branchCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bankName, bankCode, branchCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BankDetails {\n");
    
    sb.append("    bankName: ").append(toIndentedString(bankName)).append("\n");
    sb.append("    bankCode: ").append(toIndentedString(bankCode)).append("\n");
    sb.append("    branchCode: ").append(toIndentedString(branchCode)).append("\n");
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
