=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse' do
  before do
    # run before each test
    @instance = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse' do
    it 'should create an instance of RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse' do
      expect(@instance).to be_instance_of(SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse)
    end
  end
  describe 'test attribute "new_loan_reference_id"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "next_installment_amount"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "next_installment_principal_amount"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "interest_rate"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "total_interest_amount"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "initial_fee_amount"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "closure_interest_amount"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "loan_booking_fee"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
