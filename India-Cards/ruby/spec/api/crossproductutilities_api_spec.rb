=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::CROSSPRODUCTUTILITIESApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CROSSPRODUCTUTILITIESApi' do
  before do
    # run before each test
    @instance = SwaggerClient::CROSSPRODUCTUTILITIESApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CROSSPRODUCTUTILITIESApi' do
    it 'should create an instance of CROSSPRODUCTUTILITIESApi' do
      expect(@instance).to be_instance_of(SwaggerClient::CROSSPRODUCTUTILITIESApi)
    end
  end

  # unit tests for update_issued_device_allocation_device_pfid
  # This API is used to receive the PFID from partner and maintain across the respective card.
  # This API is used to receive the PFID from partner and maintain across the respective card.
  # @param body UpdateIssuedDeviceAllocationDevicePfidRequest
  # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param accept Content-Type that are acceptable for the response.
  # @param client_id Client ID generated during application registration.
  # @param content_type application/json
  # @param [Hash] opts the optional parameters
  # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  # @return [UpdateIssuedDeviceAllocationDevicePfidResponse]
  describe 'update_issued_device_allocation_device_pfid test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end