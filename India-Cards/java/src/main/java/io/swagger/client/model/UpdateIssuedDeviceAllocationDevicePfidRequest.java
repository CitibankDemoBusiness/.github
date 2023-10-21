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
/**
 * UpdateIssuedDeviceAllocationDevicePfidRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class UpdateIssuedDeviceAllocationDevicePfidRequest {
  @SerializedName("requestTimestamp")
  private Integer requestTimestamp = null;

  @SerializedName("cardReferenceId")
  private String cardReferenceId = null;

  @SerializedName("paymentFinancialInstrumentId")
  private String paymentFinancialInstrumentId = null;

  public UpdateIssuedDeviceAllocationDevicePfidRequest requestTimestamp(Integer requestTimestamp) {
    this.requestTimestamp = requestTimestamp;
    return this;
  }

   /**
   * Date time in MMDDYYYYHHMMSS Format.
   * @return requestTimestamp
  **/
  @Schema(example = "6292020120000", required = true, description = "Date time in MMDDYYYYHHMMSS Format.")
  public Integer getRequestTimestamp() {
    return requestTimestamp;
  }

  public void setRequestTimestamp(Integer requestTimestamp) {
    this.requestTimestamp = requestTimestamp;
  }

  public UpdateIssuedDeviceAllocationDevicePfidRequest cardReferenceId(String cardReferenceId) {
    this.cardReferenceId = cardReferenceId;
    return this;
  }

   /**
   * Card reference Id (RFID). It is generated by ECS against card number.$$M
   * @return cardReferenceId
  **/
  @Schema(required = true, description = "Card reference Id (RFID). It is generated by ECS against card number.$$M")
  public String getCardReferenceId() {
    return cardReferenceId;
  }

  public void setCardReferenceId(String cardReferenceId) {
    this.cardReferenceId = cardReferenceId;
  }

  public UpdateIssuedDeviceAllocationDevicePfidRequest paymentFinancialInstrumentId(String paymentFinancialInstrumentId) {
    this.paymentFinancialInstrumentId = paymentFinancialInstrumentId;
    return this;
  }

   /**
   * Payment financial instrument Id (PFID). It is generated by partner against RFID+CardNumber.$$M
   * @return paymentFinancialInstrumentId
  **/
  @Schema(required = true, description = "Payment financial instrument Id (PFID). It is generated by partner against RFID+CardNumber.$$M")
  public String getPaymentFinancialInstrumentId() {
    return paymentFinancialInstrumentId;
  }

  public void setPaymentFinancialInstrumentId(String paymentFinancialInstrumentId) {
    this.paymentFinancialInstrumentId = paymentFinancialInstrumentId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateIssuedDeviceAllocationDevicePfidRequest updateIssuedDeviceAllocationDevicePfidRequest = (UpdateIssuedDeviceAllocationDevicePfidRequest) o;
    return Objects.equals(this.requestTimestamp, updateIssuedDeviceAllocationDevicePfidRequest.requestTimestamp) &&
        Objects.equals(this.cardReferenceId, updateIssuedDeviceAllocationDevicePfidRequest.cardReferenceId) &&
        Objects.equals(this.paymentFinancialInstrumentId, updateIssuedDeviceAllocationDevicePfidRequest.paymentFinancialInstrumentId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(requestTimestamp, cardReferenceId, paymentFinancialInstrumentId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateIssuedDeviceAllocationDevicePfidRequest {\n");
    
    sb.append("    requestTimestamp: ").append(toIndentedString(requestTimestamp)).append("\n");
    sb.append("    cardReferenceId: ").append(toIndentedString(cardReferenceId)).append("\n");
    sb.append("    paymentFinancialInstrumentId: ").append(toIndentedString(paymentFinancialInstrumentId)).append("\n");
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
