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
import io.swagger.client.model.MutualFund;
import io.swagger.client.model.Relationship;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * MutualFundAccount
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class MutualFundAccount {
  @SerializedName("productName")
  private String productName = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("totalNetAssetValueAmount")
  private Double totalNetAssetValueAmount = null;

  @SerializedName("totalTransactionAmount")
  private Double totalTransactionAmount = null;

  @SerializedName("totalUnrealizedGains")
  private Double totalUnrealizedGains = null;

  @SerializedName("relationship")
  private Relationship relationship = null;

  @SerializedName("mutualFund")
  private List<MutualFund> mutualFund = null;

  public MutualFundAccount productName(String productName) {
    this.productName = productName;
    return this;
  }

   /**
   * The name of the product
   * @return productName
  **/
  @Schema(example = "Mutual Fund Account", description = "The name of the product")
  public String getProductName() {
    return productName;
  }

  public void setProductName(String productName) {
    this.productName = productName;
  }

  public MutualFundAccount productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "0201_VC890", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public MutualFundAccount displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2391", required = true, description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public MutualFundAccount currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code of the account in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "EUR", description = "The currency code of the account in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public MutualFundAccount totalNetAssetValueAmount(Double totalNetAssetValueAmount) {
    this.totalNetAssetValueAmount = totalNetAssetValueAmount;
    return this;
  }

   /**
   * Total of net asset value of mutual funds
   * @return totalNetAssetValueAmount
  **/
  @Schema(example = "5000.25", description = "Total of net asset value of mutual funds")
  public Double getTotalNetAssetValueAmount() {
    return totalNetAssetValueAmount;
  }

  public void setTotalNetAssetValueAmount(Double totalNetAssetValueAmount) {
    this.totalNetAssetValueAmount = totalNetAssetValueAmount;
  }

  public MutualFundAccount totalTransactionAmount(Double totalTransactionAmount) {
    this.totalTransactionAmount = totalTransactionAmount;
    return this;
  }

   /**
   * Total transaction amount in local currency
   * @return totalTransactionAmount
  **/
  @Schema(example = "4500.25", description = "Total transaction amount in local currency")
  public Double getTotalTransactionAmount() {
    return totalTransactionAmount;
  }

  public void setTotalTransactionAmount(Double totalTransactionAmount) {
    this.totalTransactionAmount = totalTransactionAmount;
  }

  public MutualFundAccount totalUnrealizedGains(Double totalUnrealizedGains) {
    this.totalUnrealizedGains = totalUnrealizedGains;
    return this;
  }

   /**
   * Total unrealized gains amount, profitable position that has yet to be cashed in
   * @return totalUnrealizedGains
  **/
  @Schema(example = "500.25", description = "Total unrealized gains amount, profitable position that has yet to be cashed in")
  public Double getTotalUnrealizedGains() {
    return totalUnrealizedGains;
  }

  public void setTotalUnrealizedGains(Double totalUnrealizedGains) {
    this.totalUnrealizedGains = totalUnrealizedGains;
  }

  public MutualFundAccount relationship(Relationship relationship) {
    this.relationship = relationship;
    return this;
  }

   /**
   * Get relationship
   * @return relationship
  **/
  @Schema(description = "")
  public Relationship getRelationship() {
    return relationship;
  }

  public void setRelationship(Relationship relationship) {
    this.relationship = relationship;
  }

  public MutualFundAccount mutualFund(List<MutualFund> mutualFund) {
    this.mutualFund = mutualFund;
    return this;
  }

  public MutualFundAccount addMutualFundItem(MutualFund mutualFundItem) {
    if (this.mutualFund == null) {
      this.mutualFund = new ArrayList<MutualFund>();
    }
    this.mutualFund.add(mutualFundItem);
    return this;
  }

   /**
   * Get mutualFund
   * @return mutualFund
  **/
  @Schema(description = "")
  public List<MutualFund> getMutualFund() {
    return mutualFund;
  }

  public void setMutualFund(List<MutualFund> mutualFund) {
    this.mutualFund = mutualFund;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MutualFundAccount mutualFundAccount = (MutualFundAccount) o;
    return Objects.equals(this.productName, mutualFundAccount.productName) &&
        Objects.equals(this.productCode, mutualFundAccount.productCode) &&
        Objects.equals(this.displayAccountNumber, mutualFundAccount.displayAccountNumber) &&
        Objects.equals(this.currencyCode, mutualFundAccount.currencyCode) &&
        Objects.equals(this.totalNetAssetValueAmount, mutualFundAccount.totalNetAssetValueAmount) &&
        Objects.equals(this.totalTransactionAmount, mutualFundAccount.totalTransactionAmount) &&
        Objects.equals(this.totalUnrealizedGains, mutualFundAccount.totalUnrealizedGains) &&
        Objects.equals(this.relationship, mutualFundAccount.relationship) &&
        Objects.equals(this.mutualFund, mutualFundAccount.mutualFund);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productName, productCode, displayAccountNumber, currencyCode, totalNetAssetValueAmount, totalTransactionAmount, totalUnrealizedGains, relationship, mutualFund);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MutualFundAccount {\n");
    
    sb.append("    productName: ").append(toIndentedString(productName)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    totalNetAssetValueAmount: ").append(toIndentedString(totalNetAssetValueAmount)).append("\n");
    sb.append("    totalTransactionAmount: ").append(toIndentedString(totalTransactionAmount)).append("\n");
    sb.append("    totalUnrealizedGains: ").append(toIndentedString(totalUnrealizedGains)).append("\n");
    sb.append("    relationship: ").append(toIndentedString(relationship)).append("\n");
    sb.append("    mutualFund: ").append(toIndentedString(mutualFund)).append("\n");
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