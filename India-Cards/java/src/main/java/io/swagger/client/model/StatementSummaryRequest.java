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
import io.swagger.client.model.StatementList;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * StatementSummaryRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class StatementSummaryRequest {
  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("statementList")
  private List<StatementList> statementList = null;

  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  public StatementSummaryRequest cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * The card id  in encrypted format
   * @return cardId
  **/
  @Schema(example = "44125873852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The card id  in encrypted format")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public StatementSummaryRequest currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code of the destination account in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "SGD", description = "The currency code of the destination account in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public StatementSummaryRequest statementList(List<StatementList> statementList) {
    this.statementList = statementList;
    return this;
  }

  public StatementSummaryRequest addStatementListItem(StatementList statementListItem) {
    if (this.statementList == null) {
      this.statementList = new ArrayList<StatementList>();
    }
    this.statementList.add(statementListItem);
    return this;
  }

   /**
   * Get statementList
   * @return statementList
  **/
  @Schema(description = "")
  public List<StatementList> getStatementList() {
    return statementList;
  }

  public void setStatementList(List<StatementList> statementList) {
    this.statementList = statementList;
  }

  public StatementSummaryRequest nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.
   * @return nextStartIndex
  **/
  @Schema(example = "11", description = "The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.")
  public String getNextStartIndex() {
    return nextStartIndex;
  }

  public void setNextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StatementSummaryRequest statementSummaryRequest = (StatementSummaryRequest) o;
    return Objects.equals(this.cardId, statementSummaryRequest.cardId) &&
        Objects.equals(this.currencyCode, statementSummaryRequest.currencyCode) &&
        Objects.equals(this.statementList, statementSummaryRequest.statementList) &&
        Objects.equals(this.nextStartIndex, statementSummaryRequest.nextStartIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardId, currencyCode, statementList, nextStartIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StatementSummaryRequest {\n");
    
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    statementList: ").append(toIndentedString(statementList)).append("\n");
    sb.append("    nextStartIndex: ").append(toIndentedString(nextStartIndex)).append("\n");
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
