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

# Unit tests for SwaggerClient::BankingApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'BankingApi' do
  before do
    # run before each test
    @instance = SwaggerClient::BankingApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of BankingApi' do
    it 'should create an instance of BankingApi' do
      expect(@instance).to be_instance_of(SwaggerClient::BankingApi)
    end
  end

  # unit tests for get_product_detail
  # Get Product Detail
  # This API is used to get the detailed information on the selected product such as features, eligibility, fees and more. To retrieve the details, simply pass the product id returned from the Get Products API callout.
  # @param product_id ID of the specific product requested
  # @param x_v Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
  # @param [Hash] opts the optional parameters
  # @option opts [String] :x_min_v Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable.
  # @return [ResponseBankingProductById]
  describe 'get_product_detail test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for list_products
  # Get Products
  # This API is used to get the list of product categories that are currently offered to the market.
  # @param x_v Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)
  # @param [Hash] opts the optional parameters
  # @option opts [String] :effective Allows for the filtering of products based on whether the current time is within the period of time defined as effective by the effectiveFrom and effectiveTo fields. Valid values are ‘CURRENT’, ‘FUTURE’ and ‘ALL’. If absent defaults to &#x27;CURRENT&#x27;
  # @option opts [String] :updated_since Only include products that have been updated after the specified date and time. If absent defaults to include all products
  # @option opts [String] :brand Filter results based on a specific brand
  # @option opts [String] :product_category Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.
  # @option opts [Integer] :page Page of results to request (standard pagination)
  # @option opts [Integer] :page_size Page size to request. Default is 25 (standard pagination)
  # @option opts [String] :x_min_v Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder should respond with a 406 Not Acceptable.
  # @return [ResponseBankingProductList]
  describe 'list_products test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end