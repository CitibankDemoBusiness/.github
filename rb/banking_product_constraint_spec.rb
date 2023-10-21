=begin
#ConsumerDataStandards_Digital_Regulatory

#The product \\amp Product Details APIs allow third-parties to retrieve a list of Product categories \\amp details for Citi and our White-label Partners.

OpenAPI spec version: 1.2.0
Contact: cdr-data61@csiro.au
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::BankingProductConstraint
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'BankingProductConstraint' do
  before do
    # run before each test
    @instance = SwaggerClient::BankingProductConstraint.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of BankingProductConstraint' do
    it 'should create an instance of BankingProductConstraint' do
      expect(@instance).to be_instance_of(SwaggerClient::BankingProductConstraint)
    end
  end
  describe 'test attribute "constraint_type"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["MIN_BALANCE", "MAX_BALANCE", "OPENING_BALANCE", "MAX_LIMIT", "MIN_LIMIT"])
      # validator.allowable_values.each do |value|
      #   expect { @instance.constraint_type = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "additional_value"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "additional_info"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "additional_info_uri"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
