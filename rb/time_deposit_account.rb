=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class TimeDepositAccount
    # The name of the product
    attr_accessor :product_name

    # A unique code that identifies the product
    attr_accessor :product_code

    # A masked account number that can be displayed to the customer
    attr_accessor :display_account_number

    # The original principal amount when account opened.
    attr_accessor :original_principal_amount

    # The currency code of the account in ISO 4217 format
    attr_accessor :currency_code

    # The rate of interest applicable for the time deposit
    attr_accessor :interest_rate

    # The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD
    attr_accessor :opening_date

    # The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD
    attr_accessor :maturity_date

    # The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD
    attr_accessor :next_interest_payment_date

    # The accrued interest amount which has not yet been paid by Citibank
    attr_accessor :interest_amount_due

    # The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :renewal_instructions

    # The tenor term for the deposit, expressed as a whole number
    attr_accessor :tenor_term

    # The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :tenor_period

    # The investment amount and accrued interest in base currency
    attr_accessor :base_currency_maturity_amount

    # The accrued interest in base currency.
    attr_accessor :maturity_interest_amount

    # Last interest amount for the time deposit account
    attr_accessor :last_interest_payment_amount

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'product_name' => :'productName',
        :'product_code' => :'productCode',
        :'display_account_number' => :'displayAccountNumber',
        :'original_principal_amount' => :'originalPrincipalAmount',
        :'currency_code' => :'currencyCode',
        :'interest_rate' => :'interestRate',
        :'opening_date' => :'openingDate',
        :'maturity_date' => :'maturityDate',
        :'next_interest_payment_date' => :'nextInterestPaymentDate',
        :'interest_amount_due' => :'interestAmountDue',
        :'renewal_instructions' => :'renewalInstructions',
        :'tenor_term' => :'tenorTerm',
        :'tenor_period' => :'tenorPeriod',
        :'base_currency_maturity_amount' => :'baseCurrencyMaturityAmount',
        :'maturity_interest_amount' => :'maturityInterestAmount',
        :'last_interest_payment_amount' => :'lastInterestPaymentAmount'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'product_name' => :'Object',
        :'product_code' => :'Object',
        :'display_account_number' => :'Object',
        :'original_principal_amount' => :'Object',
        :'currency_code' => :'Object',
        :'interest_rate' => :'Object',
        :'opening_date' => :'Object',
        :'maturity_date' => :'Object',
        :'next_interest_payment_date' => :'Object',
        :'interest_amount_due' => :'Object',
        :'renewal_instructions' => :'Object',
        :'tenor_term' => :'Object',
        :'tenor_period' => :'Object',
        :'base_currency_maturity_amount' => :'Object',
        :'maturity_interest_amount' => :'Object',
        :'last_interest_payment_amount' => :'Object'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end
  
    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::TimeDepositAccount` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::TimeDepositAccount`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'product_name')
        self.product_name = attributes[:'product_name']
      end

      if attributes.key?(:'product_code')
        self.product_code = attributes[:'product_code']
      end

      if attributes.key?(:'display_account_number')
        self.display_account_number = attributes[:'display_account_number']
      end

      if attributes.key?(:'original_principal_amount')
        self.original_principal_amount = attributes[:'original_principal_amount']
      end

      if attributes.key?(:'currency_code')
        self.currency_code = attributes[:'currency_code']
      end

      if attributes.key?(:'interest_rate')
        self.interest_rate = attributes[:'interest_rate']
      end

      if attributes.key?(:'opening_date')
        self.opening_date = attributes[:'opening_date']
      end

      if attributes.key?(:'maturity_date')
        self.maturity_date = attributes[:'maturity_date']
      end

      if attributes.key?(:'next_interest_payment_date')
        self.next_interest_payment_date = attributes[:'next_interest_payment_date']
      end

      if attributes.key?(:'interest_amount_due')
        self.interest_amount_due = attributes[:'interest_amount_due']
      end

      if attributes.key?(:'renewal_instructions')
        self.renewal_instructions = attributes[:'renewal_instructions']
      end

      if attributes.key?(:'tenor_term')
        self.tenor_term = attributes[:'tenor_term']
      end

      if attributes.key?(:'tenor_period')
        self.tenor_period = attributes[:'tenor_period']
      end

      if attributes.key?(:'base_currency_maturity_amount')
        self.base_currency_maturity_amount = attributes[:'base_currency_maturity_amount']
      end

      if attributes.key?(:'maturity_interest_amount')
        self.maturity_interest_amount = attributes[:'maturity_interest_amount']
      end

      if attributes.key?(:'last_interest_payment_amount')
        self.last_interest_payment_amount = attributes[:'last_interest_payment_amount']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @display_account_number.nil?
        invalid_properties.push('invalid value for "display_account_number", display_account_number cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @display_account_number.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          product_name == o.product_name &&
          product_code == o.product_code &&
          display_account_number == o.display_account_number &&
          original_principal_amount == o.original_principal_amount &&
          currency_code == o.currency_code &&
          interest_rate == o.interest_rate &&
          opening_date == o.opening_date &&
          maturity_date == o.maturity_date &&
          next_interest_payment_date == o.next_interest_payment_date &&
          interest_amount_due == o.interest_amount_due &&
          renewal_instructions == o.renewal_instructions &&
          tenor_term == o.tenor_term &&
          tenor_period == o.tenor_period &&
          base_currency_maturity_amount == o.base_currency_maturity_amount &&
          maturity_interest_amount == o.maturity_interest_amount &&
          last_interest_payment_amount == o.last_interest_payment_amount
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [product_name, product_code, display_account_number, original_principal_amount, currency_code, interest_rate, opening_date, maturity_date, next_interest_payment_date, interest_amount_due, renewal_instructions, tenor_term, tenor_period, base_currency_maturity_amount, maturity_interest_amount, last_interest_payment_amount].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        elsif attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        SwaggerClient.const_get(type).build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end  end
end
