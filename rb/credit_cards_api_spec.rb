=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::CreditCardsApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CreditCardsApi' do
  before do
    # run before each test
    @instance = SwaggerClient::CreditCardsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CreditCardsApi' do
    it 'should create an instance of CreditCardsApi' do
      expect(@instance).to be_instance_of(SwaggerClient::CreditCardsApi)
    end
  end

  # unit tests for companion_card_application
  # Issuance of Companion Card
  # This API is used to issue a new companion card for primary credit card.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param content_type The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json.
  # @param client_id Client ID generated during application registration.
  # @param card_id Card Id in encrypted format
  # @param [Hash] opts the optional parameters
  # @option opts [CompanionCardApplicationRequest] :body CompanionCardApplicationRequest
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [CompanionCardApplicationResponse]
  describe 'companion_card_application test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for easy_payment_plans_transaction_eligibility
  # Transaction Eligibility and Easy Payment Plans
  # This API is used to check the Easy Payment Plans eligibility for a card and the available Payment Plans details.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param card_id The card id in encrypted format.
  # @param eligble_loan_amount Elligible loan amount for easy payment plan booking..
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [EasyPaymentPlansTransactionEligibilityResponse]
  describe 'easy_payment_plans_transaction_eligibility test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_card_id_easy_payment_plans_bookings_post
  # Book Easy Payment Plan
  # This API is triggered after the EPP plan selection and completes the EPP booking. On successful booking, it returns transaction reference in the response.
  # @param body 
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param content_type application/json
  # @param card_id The card id  in encrypted format.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [EppLoanBookingResponse]
  describe 'v1_credit_cards_card_id_easy_payment_plans_bookings_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_card_id_easy_payment_plans_eligibility_get
  # Check Easy Payment Plan Eligibility
  # This API is used to validate the transaction eligibility for EPP conversion.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id client_id generated during consumer onboarding
  # @param card_id Card Id in encrypted format.
  # @param epp_loan_booking_type Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @option opts [String] :next_start_index In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
  # @return [EasyPaymentPlansEligibilityInquiryResponse]
  describe 'v1_credit_cards_card_id_easy_payment_plans_eligibility_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get
  # Easy Payment Plan Repayment Schedule
  # This API allows the customer to view the payment breakdown details and the repayment schedule for the Easy Payment Plan selected.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id client id generated during consumer onboarding
  # @param card_id The card id  in encrypted format.
  # @param loan_amount Loan amount for easy payment plan booking.
  # @param tenor Tenure of loan in months.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @option opts [String] :next_start_index In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
  # @return [EppRepaymentScheuleResponse]
  describe 'v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_card_id_easy_payment_plans_search_post
  # Retrieve Easy Payment Plans Options
  # This API retrieves the available Easy Payment Plans to be used by the customer for the repayment of his/her loans.
  # @param body Easy payment plan Request
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id client id generated during consumer onboarding
  # @param card_id The card id  in encrypted format.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [EppResponse]
  describe 'v1_credit_cards_card_id_easy_payment_plans_search_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_card_id_supplementary_cards_get
  # List Supplementary Cards
  # This API retrieves the details of all the supplementary cards associated with the primary card id in the request.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id client id generated during consumer onboarding
  # @param card_id The primary card id  in encrypted format.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [SupplementaryCardListingResponse]
  describe 'v1_credit_cards_card_id_supplementary_cards_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for v1_credit_cards_statements_summary_search_post
  # Retrieve Composite Credit Cards Statement Summary
  # This API is used to retrieve the statement summary for multiple credit cards in a single request.
  # @param body 
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param content_type application/json
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [CardStatementSummaryResponse]
  describe 'v1_credit_cards_statements_summary_search_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end