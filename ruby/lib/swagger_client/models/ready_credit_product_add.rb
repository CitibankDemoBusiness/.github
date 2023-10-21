=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class ReadyCreditProductAdd
    # A unique code that identifies the product
    attr_accessor :product_code

    # A source code to identify the product
    attr_accessor :source_code

    # Card issuing organization name
    attr_accessor :organization

    # Product logo to identify the product
    attr_accessor :logo

    # Insurance enrolment for outstanding balance on the card. Valid values: true and false
    attr_accessor :request_credit_shield

    # Name to be embossed on card
    attr_accessor :emboss_name

    # Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
    attr_accessor :billing_address

    # Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
    attr_accessor :card_delivery_address

    # Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
    attr_accessor :pin_delivery_address

    # A  unique code that identifies the gift offered along with the product
    attr_accessor :gift_code

    # Option for to review the credit limit in the future.Valid values: true and false
    attr_accessor :credit_limit_increase_indicator

    # Option to get ATM card along with product. Valid values: true and false
    attr_accessor :atm_required_flag

    # Option to get cheque book along with product. Valid values: true and false
    attr_accessor :cheque_book_required_flag

    # Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
    attr_accessor :loan_purpose

    # Credit limit requested by applicant for the product.
    attr_accessor :requested_credit_limit

    attr_accessor :equal_payment_plan

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'product_code' => :'productCode',
        :'source_code' => :'sourceCode',
        :'organization' => :'organization',
        :'logo' => :'logo',
        :'request_credit_shield' => :'requestCreditShield',
        :'emboss_name' => :'embossName',
        :'billing_address' => :'billingAddress',
        :'card_delivery_address' => :'cardDeliveryAddress',
        :'pin_delivery_address' => :'pinDeliveryAddress',
        :'gift_code' => :'giftCode',
        :'credit_limit_increase_indicator' => :'creditLimitIncreaseIndicator',
        :'atm_required_flag' => :'atmRequiredFlag',
        :'cheque_book_required_flag' => :'chequeBookRequiredFlag',
        :'loan_purpose' => :'loanPurpose',
        :'requested_credit_limit' => :'requestedCreditLimit',
        :'equal_payment_plan' => :'equalPaymentPlan'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'product_code' => :'Object',
        :'source_code' => :'Object',
        :'organization' => :'Object',
        :'logo' => :'Object',
        :'request_credit_shield' => :'Object',
        :'emboss_name' => :'Object',
        :'billing_address' => :'Object',
        :'card_delivery_address' => :'Object',
        :'pin_delivery_address' => :'Object',
        :'gift_code' => :'Object',
        :'credit_limit_increase_indicator' => :'Object',
        :'atm_required_flag' => :'Object',
        :'cheque_book_required_flag' => :'Object',
        :'loan_purpose' => :'Object',
        :'requested_credit_limit' => :'Object',
        :'equal_payment_plan' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ReadyCreditProductAdd` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ReadyCreditProductAdd`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'product_code')
        self.product_code = attributes[:'product_code']
      end

      if attributes.key?(:'source_code')
        self.source_code = attributes[:'source_code']
      end

      if attributes.key?(:'organization')
        self.organization = attributes[:'organization']
      end

      if attributes.key?(:'logo')
        self.logo = attributes[:'logo']
      end

      if attributes.key?(:'request_credit_shield')
        self.request_credit_shield = attributes[:'request_credit_shield']
      end

      if attributes.key?(:'emboss_name')
        self.emboss_name = attributes[:'emboss_name']
      end

      if attributes.key?(:'billing_address')
        self.billing_address = attributes[:'billing_address']
      end

      if attributes.key?(:'card_delivery_address')
        self.card_delivery_address = attributes[:'card_delivery_address']
      end

      if attributes.key?(:'pin_delivery_address')
        self.pin_delivery_address = attributes[:'pin_delivery_address']
      end

      if attributes.key?(:'gift_code')
        self.gift_code = attributes[:'gift_code']
      end

      if attributes.key?(:'credit_limit_increase_indicator')
        self.credit_limit_increase_indicator = attributes[:'credit_limit_increase_indicator']
      end

      if attributes.key?(:'atm_required_flag')
        self.atm_required_flag = attributes[:'atm_required_flag']
      end

      if attributes.key?(:'cheque_book_required_flag')
        self.cheque_book_required_flag = attributes[:'cheque_book_required_flag']
      end

      if attributes.key?(:'loan_purpose')
        self.loan_purpose = attributes[:'loan_purpose']
      end

      if attributes.key?(:'requested_credit_limit')
        self.requested_credit_limit = attributes[:'requested_credit_limit']
      end

      if attributes.key?(:'equal_payment_plan')
        if (value = attributes[:'equal_payment_plan']).is_a?(Array)
          self.equal_payment_plan = value
        end
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @product_code.nil?
        invalid_properties.push('invalid value for "product_code", product_code cannot be nil.')
      end

      if @source_code.nil?
        invalid_properties.push('invalid value for "source_code", source_code cannot be nil.')
      end

      if @organization.nil?
        invalid_properties.push('invalid value for "organization", organization cannot be nil.')
      end

      if @logo.nil?
        invalid_properties.push('invalid value for "logo", logo cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @product_code.nil?
      return false if @source_code.nil?
      return false if @organization.nil?
      return false if @logo.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          product_code == o.product_code &&
          source_code == o.source_code &&
          organization == o.organization &&
          logo == o.logo &&
          request_credit_shield == o.request_credit_shield &&
          emboss_name == o.emboss_name &&
          billing_address == o.billing_address &&
          card_delivery_address == o.card_delivery_address &&
          pin_delivery_address == o.pin_delivery_address &&
          gift_code == o.gift_code &&
          credit_limit_increase_indicator == o.credit_limit_increase_indicator &&
          atm_required_flag == o.atm_required_flag &&
          cheque_book_required_flag == o.cheque_book_required_flag &&
          loan_purpose == o.loan_purpose &&
          requested_credit_limit == o.requested_credit_limit &&
          equal_payment_plan == o.equal_payment_plan
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [product_code, source_code, organization, logo, request_credit_shield, emboss_name, billing_address, card_delivery_address, pin_delivery_address, gift_code, credit_limit_increase_indicator, atm_required_flag, cheque_book_required_flag, loan_purpose, requested_credit_limit, equal_payment_plan].hash
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
