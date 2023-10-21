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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * PersonalAccountDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class PersonalAccountDetails {
  @SerializedName("accountNickName")
  private String accountNickName = null;

  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("iban")
  private String iban = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  public PersonalAccountDetails accountNickName(String accountNickName) {
    this.accountNickName = accountNickName;
    return this;
  }

   /**
   * The nickname of the account assigned by the customer
   * @return accountNickName
  **/
  @Schema(example = "Brokerage Account for my trading", required = true, description = "The nickname of the account assigned by the customer")
  public String getAccountNickName() {
    return accountNickName;
  }

  public void setAccountNickName(String accountNickName) {
    this.accountNickName = accountNickName;
  }

  public PersonalAccountDetails accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The account number in encrypted format.
   * @return accountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "The account number in encrypted format.")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public PersonalAccountDetails displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2364", required = true, description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public PersonalAccountDetails iban(String iban) {
    this.iban = iban;
    return this;
  }

   /**
   * IBAN stands for International Bank Account Number and is a number attached to all accounts in the EU countries plus Norway, Switzerland, Liechtenstein and Hungary. The IBAN is made up of a code that identifies the country the account belongs to, the account holders bank and the account number itself
   * @return iban
  **/
  @Schema(example = "CY17002001280000001200527600", description = "IBAN stands for International Bank Account Number and is a number attached to all accounts in the EU countries plus Norway, Switzerland, Liechtenstein and Hungary. The IBAN is made up of a code that identifies the country the account belongs to, the account holders bank and the account number itself")
  public String getIban() {
    return iban;
  }

  public void setIban(String iban) {
    this.iban = iban;
  }

  public PersonalAccountDetails currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code of the account in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "SGD", description = "The currency code of the account in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PersonalAccountDetails personalAccountDetails = (PersonalAccountDetails) o;
    return Objects.equals(this.accountNickName, personalAccountDetails.accountNickName) &&
        Objects.equals(this.accountId, personalAccountDetails.accountId) &&
        Objects.equals(this.displayAccountNumber, personalAccountDetails.displayAccountNumber) &&
        Objects.equals(this.iban, personalAccountDetails.iban) &&
        Objects.equals(this.currencyCode, personalAccountDetails.currencyCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accountNickName, accountId, displayAccountNumber, iban, currencyCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PersonalAccountDetails {\n");
    
    sb.append("    accountNickName: ").append(toIndentedString(accountNickName)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    iban: ").append(toIndentedString(iban)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
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