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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * PendingAuthorizationTransactionRecords
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class PendingAuthorizationTransactionRecords {
  @SerializedName("transactionDate")
  private LocalDate transactionDate = null;

  @SerializedName("transactionTime")
  private String transactionTime = null;

  @SerializedName("transactionCurrencyCode")
  private String transactionCurrencyCode = null;

  @SerializedName("transactionAmount")
  private Double transactionAmount = null;

  @SerializedName("transactionStatus")
  private String transactionStatus = null;

  @SerializedName("billedCurrencyCode")
  private String billedCurrencyCode = null;

  @SerializedName("billedAmount")
  private Double billedAmount = null;

  @SerializedName("merchantName")
  private String merchantName = null;

  public PendingAuthorizationTransactionRecords transactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
    return this;
  }

   /**
   * EffectiveDate should be in ISO 8601 format YYYY-MM-DD
   * @return transactionDate
  **/
  @Schema(example = "Mon Feb 20 00:00:00 UTC 2012", description = "EffectiveDate should be in ISO 8601 format YYYY-MM-DD")
  public LocalDate getTransactionDate() {
    return transactionDate;
  }

  public void setTransactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
  }

  public PendingAuthorizationTransactionRecords transactionTime(String transactionTime) {
    this.transactionTime = transactionTime;
    return this;
  }

   /**
   * EffectiveTime  should follow ISO 8601 format hh:mm:ss
   * @return transactionTime
  **/
  @Schema(example = "11:53:20", description = "EffectiveTime  should follow ISO 8601 format hh:mm:ss")
  public String getTransactionTime() {
    return transactionTime;
  }

  public void setTransactionTime(String transactionTime) {
    this.transactionTime = transactionTime;
  }

  public PendingAuthorizationTransactionRecords transactionCurrencyCode(String transactionCurrencyCode) {
    this.transactionCurrencyCode = transactionCurrencyCode;
    return this;
  }

   /**
   * transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions
   * @return transactionCurrencyCode
  **/
  @Schema(example = "USD", description = "transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions")
  public String getTransactionCurrencyCode() {
    return transactionCurrencyCode;
  }

  public void setTransactionCurrencyCode(String transactionCurrencyCode) {
    this.transactionCurrencyCode = transactionCurrencyCode;
  }

  public PendingAuthorizationTransactionRecords transactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
    return this;
  }

   /**
   * TransactionAmount
   * @return transactionAmount
  **/
  @Schema(example = "200.25", description = "TransactionAmount")
  public Double getTransactionAmount() {
    return transactionAmount;
  }

  public void setTransactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
  }

  public PendingAuthorizationTransactionRecords transactionStatus(String transactionStatus) {
    this.transactionStatus = transactionStatus;
    return this;
  }

   /**
   * AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions
   * @return transactionStatus
  **/
  @Schema(example = "APPROVED", description = "AuthorizationResponseCode of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions")
  public String getTransactionStatus() {
    return transactionStatus;
  }

  public void setTransactionStatus(String transactionStatus) {
    this.transactionStatus = transactionStatus;
  }

  public PendingAuthorizationTransactionRecords billedCurrencyCode(String billedCurrencyCode) {
    this.billedCurrencyCode = billedCurrencyCode;
    return this;
  }

   /**
   * billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions
   * @return billedCurrencyCode
  **/
  @Schema(example = "USD", description = "billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions")
  public String getBilledCurrencyCode() {
    return billedCurrencyCode;
  }

  public void setBilledCurrencyCode(String billedCurrencyCode) {
    this.billedCurrencyCode = billedCurrencyCode;
  }

  public PendingAuthorizationTransactionRecords billedAmount(Double billedAmount) {
    this.billedAmount = billedAmount;
    return this;
  }

   /**
   * billedAmount
   * @return billedAmount
  **/
  @Schema(example = "200.25", description = "billedAmount")
  public Double getBilledAmount() {
    return billedAmount;
  }

  public void setBilledAmount(Double billedAmount) {
    this.billedAmount = billedAmount;
  }

  public PendingAuthorizationTransactionRecords merchantName(String merchantName) {
    this.merchantName = merchantName;
    return this;
  }

   /**
   * Merchant Name
   * @return merchantName
  **/
  @Schema(example = "XYZ123", description = "Merchant Name")
  public String getMerchantName() {
    return merchantName;
  }

  public void setMerchantName(String merchantName) {
    this.merchantName = merchantName;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PendingAuthorizationTransactionRecords pendingAuthorizationTransactionRecords = (PendingAuthorizationTransactionRecords) o;
    return Objects.equals(this.transactionDate, pendingAuthorizationTransactionRecords.transactionDate) &&
        Objects.equals(this.transactionTime, pendingAuthorizationTransactionRecords.transactionTime) &&
        Objects.equals(this.transactionCurrencyCode, pendingAuthorizationTransactionRecords.transactionCurrencyCode) &&
        Objects.equals(this.transactionAmount, pendingAuthorizationTransactionRecords.transactionAmount) &&
        Objects.equals(this.transactionStatus, pendingAuthorizationTransactionRecords.transactionStatus) &&
        Objects.equals(this.billedCurrencyCode, pendingAuthorizationTransactionRecords.billedCurrencyCode) &&
        Objects.equals(this.billedAmount, pendingAuthorizationTransactionRecords.billedAmount) &&
        Objects.equals(this.merchantName, pendingAuthorizationTransactionRecords.merchantName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(transactionDate, transactionTime, transactionCurrencyCode, transactionAmount, transactionStatus, billedCurrencyCode, billedAmount, merchantName);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PendingAuthorizationTransactionRecords {\n");
    
    sb.append("    transactionDate: ").append(toIndentedString(transactionDate)).append("\n");
    sb.append("    transactionTime: ").append(toIndentedString(transactionTime)).append("\n");
    sb.append("    transactionCurrencyCode: ").append(toIndentedString(transactionCurrencyCode)).append("\n");
    sb.append("    transactionAmount: ").append(toIndentedString(transactionAmount)).append("\n");
    sb.append("    transactionStatus: ").append(toIndentedString(transactionStatus)).append("\n");
    sb.append("    billedCurrencyCode: ").append(toIndentedString(billedCurrencyCode)).append("\n");
    sb.append("    billedAmount: ").append(toIndentedString(billedAmount)).append("\n");
    sb.append("    merchantName: ").append(toIndentedString(merchantName)).append("\n");
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
