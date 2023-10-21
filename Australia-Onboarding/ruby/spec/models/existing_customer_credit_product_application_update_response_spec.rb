=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::ExistingCustomerCreditProductApplicationUpdateResponse
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'ExistingCustomerCreditProductApplicationUpdateResponse' do
  before do
    # run before each test
    @instance = SwaggerClient::ExistingCustomerCreditProductApplicationUpdateResponse.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ExistingCustomerCreditProductApplicationUpdateResponse' do
    it 'should create an instance of ExistingCustomerCreditProductApplicationUpdateResponse' do
      expect(@instance).to be_instance_of(SwaggerClient::ExistingCustomerCreditProductApplicationUpdateResponse)
    end
  end
  describe 'test attribute "application_stage"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
