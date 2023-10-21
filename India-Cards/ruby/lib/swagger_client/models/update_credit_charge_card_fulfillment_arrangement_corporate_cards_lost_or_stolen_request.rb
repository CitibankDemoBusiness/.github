=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest
    # Tokenized card number
    attr_accessor :tokenized_card_number

    attr_accessor :corporate_officer_details

    # Customer Name embossed on the card
    attr_accessor :embossed_name

    # This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions
    attr_accessor :service_request_type

    # Cards Lost or Stolen date
    attr_accessor :stolen_date

    # Latest date when the card was used
    attr_accessor :last_card_used_date

    # Latest Transaction amount on the card
    attr_accessor :last_transaction_amount

    # Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions
    attr_accessor :card_loss_type

    # Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions
    attr_accessor :lost_country

    # Remarks to be mentioned by customer (120 Bytes max length)
    attr_accessor :customer_remarks

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'tokenized_card_number' => :'tokenizedCardNumber',
        :'corporate_officer_details' => :'corporateOfficerDetails',
        :'embossed_name' => :'embossedName',
        :'service_request_type' => :'serviceRequestType',
        :'stolen_date' => :'stolenDate',
        :'last_card_used_date' => :'lastCardUsedDate',
        :'last_transaction_amount' => :'lastTransactionAmount',
        :'card_loss_type' => :'cardLossType',
        :'lost_country' => :'lostCountry',
        :'customer_remarks' => :'customerRemarks'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'tokenized_card_number' => :'Object',
        :'corporate_officer_details' => :'Object',
        :'embossed_name' => :'Object',
        :'service_request_type' => :'Object',
        :'stolen_date' => :'Object',
        :'last_card_used_date' => :'Object',
        :'last_transaction_amount' => :'Object',
        :'card_loss_type' => :'Object',
        :'lost_country' => :'Object',
        :'customer_remarks' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'tokenized_card_number')
        self.tokenized_card_number = attributes[:'tokenized_card_number']
      end

      if attributes.key?(:'corporate_officer_details')
        self.corporate_officer_details = attributes[:'corporate_officer_details']
      end

      if attributes.key?(:'embossed_name')
        self.embossed_name = attributes[:'embossed_name']
      end

      if attributes.key?(:'service_request_type')
        self.service_request_type = attributes[:'service_request_type']
      end

      if attributes.key?(:'stolen_date')
        self.stolen_date = attributes[:'stolen_date']
      end

      if attributes.key?(:'last_card_used_date')
        self.last_card_used_date = attributes[:'last_card_used_date']
      end

      if attributes.key?(:'last_transaction_amount')
        self.last_transaction_amount = attributes[:'last_transaction_amount']
      end

      if attributes.key?(:'card_loss_type')
        self.card_loss_type = attributes[:'card_loss_type']
      end

      if attributes.key?(:'lost_country')
        self.lost_country = attributes[:'lost_country']
      end

      if attributes.key?(:'customer_remarks')
        self.customer_remarks = attributes[:'customer_remarks']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @tokenized_card_number.nil?
        invalid_properties.push('invalid value for "tokenized_card_number", tokenized_card_number cannot be nil.')
      end

      if @embossed_name.nil?
        invalid_properties.push('invalid value for "embossed_name", embossed_name cannot be nil.')
      end

      if @service_request_type.nil?
        invalid_properties.push('invalid value for "service_request_type", service_request_type cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @tokenized_card_number.nil?
      return false if @embossed_name.nil?
      return false if @service_request_type.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          tokenized_card_number == o.tokenized_card_number &&
          corporate_officer_details == o.corporate_officer_details &&
          embossed_name == o.embossed_name &&
          service_request_type == o.service_request_type &&
          stolen_date == o.stolen_date &&
          last_card_used_date == o.last_card_used_date &&
          last_transaction_amount == o.last_transaction_amount &&
          card_loss_type == o.card_loss_type &&
          lost_country == o.lost_country &&
          customer_remarks == o.customer_remarks
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [tokenized_card_number, corporate_officer_details, embossed_name, service_request_type, stolen_date, last_card_used_date, last_transaction_amount, card_loss_type, lost_country, customer_remarks].hash
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