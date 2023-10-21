=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::CustomerFoundationalApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CustomerFoundationalApi' do
  before do
    # run before each test
    @instance = SwaggerClient::CustomerFoundationalApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CustomerFoundationalApi' do
    it 'should create an instance of CustomerFoundationalApi' do
      expect(@instance).to be_instance_of(SwaggerClient::CustomerFoundationalApi)
    end
  end

  # unit tests for retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact
  # This API is used to inquire the Customer contact details.
  # This API is used to inquire the Customer contact details.
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param content_type application/json
  # @param [Hash] opts the optional parameters
  # @option opts [String] :accept_language List of acceptable human languages for response.
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse]
  describe 'retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for update_customer_reference_data_directory_entry_corporate_card_customer_contact
  # This API is used to update customer contact details
  # This API is used to update customer contact details
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param content_type application/json
  # @param [Hash] opts the optional parameters
  # @option opts [String] :accept_language List of acceptable human languages for response.
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [nil]
  describe 'update_customer_reference_data_directory_entry_corporate_card_customer_contact test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end