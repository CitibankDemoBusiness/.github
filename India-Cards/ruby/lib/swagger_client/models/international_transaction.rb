=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class InternationalTransaction
    # InternationalSingleATMTransactionLimitToggleFlag
    attr_accessor :atm_transaction_limit_toggle_indicator

    # InternationalSingleATMTransactionLimit
    attr_accessor :atm_transaction_limit_amount

    # InternationalSingleContactlessTransactionLimitToggleFlag
    attr_accessor :contactless_txn_limit_toggle_indicator

    # InternationalSingleContactlessTransactionLimit
    attr_accessor :contactless_transaction_limit_amount

    # InternationalSingleContactPOSTransactionLimitToggleFlag
    attr_accessor :contact_pos_txn_limit_toggle_indicator

    # InternationalSingleContactPOSTransactionLimit
    attr_accessor :contact_pos_transaction_limit_amount

    # InternationalSingleNonPOSTransactionLimitToggleFlag
    attr_accessor :non_pos_txn_limit_toggle_indicator

    # InternationalSingleNonPOSTransactionLimit
    attr_accessor :non_pos_transaction_limit_amount

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'atm_transaction_limit_toggle_indicator' => :'atmTransactionLimitToggleIndicator',
        :'atm_transaction_limit_amount' => :'atmTransactionLimitAmount',
        :'contactless_txn_limit_toggle_indicator' => :'contactlessTxnLimitToggleIndicator',
        :'contactless_transaction_limit_amount' => :'contactlessTransactionLimitAmount',
        :'contact_pos_txn_limit_toggle_indicator' => :'contactPosTxnLimitToggleIndicator',
        :'contact_pos_transaction_limit_amount' => :'contactPosTransactionLimitAmount',
        :'non_pos_txn_limit_toggle_indicator' => :'nonPosTxnLimitToggleIndicator',
        :'non_pos_transaction_limit_amount' => :'nonPosTransactionLimitAmount'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'atm_transaction_limit_toggle_indicator' => :'Object',
        :'atm_transaction_limit_amount' => :'Object',
        :'contactless_txn_limit_toggle_indicator' => :'Object',
        :'contactless_transaction_limit_amount' => :'Object',
        :'contact_pos_txn_limit_toggle_indicator' => :'Object',
        :'contact_pos_transaction_limit_amount' => :'Object',
        :'non_pos_txn_limit_toggle_indicator' => :'Object',
        :'non_pos_transaction_limit_amount' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::InternationalTransaction` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::InternationalTransaction`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'atm_transaction_limit_toggle_indicator')
        self.atm_transaction_limit_toggle_indicator = attributes[:'atm_transaction_limit_toggle_indicator']
      end

      if attributes.key?(:'atm_transaction_limit_amount')
        self.atm_transaction_limit_amount = attributes[:'atm_transaction_limit_amount']
      end

      if attributes.key?(:'contactless_txn_limit_toggle_indicator')
        self.contactless_txn_limit_toggle_indicator = attributes[:'contactless_txn_limit_toggle_indicator']
      end

      if attributes.key?(:'contactless_transaction_limit_amount')
        self.contactless_transaction_limit_amount = attributes[:'contactless_transaction_limit_amount']
      end

      if attributes.key?(:'contact_pos_txn_limit_toggle_indicator')
        self.contact_pos_txn_limit_toggle_indicator = attributes[:'contact_pos_txn_limit_toggle_indicator']
      end

      if attributes.key?(:'contact_pos_transaction_limit_amount')
        self.contact_pos_transaction_limit_amount = attributes[:'contact_pos_transaction_limit_amount']
      end

      if attributes.key?(:'non_pos_txn_limit_toggle_indicator')
        self.non_pos_txn_limit_toggle_indicator = attributes[:'non_pos_txn_limit_toggle_indicator']
      end

      if attributes.key?(:'non_pos_transaction_limit_amount')
        self.non_pos_transaction_limit_amount = attributes[:'non_pos_transaction_limit_amount']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          atm_transaction_limit_toggle_indicator == o.atm_transaction_limit_toggle_indicator &&
          atm_transaction_limit_amount == o.atm_transaction_limit_amount &&
          contactless_txn_limit_toggle_indicator == o.contactless_txn_limit_toggle_indicator &&
          contactless_transaction_limit_amount == o.contactless_transaction_limit_amount &&
          contact_pos_txn_limit_toggle_indicator == o.contact_pos_txn_limit_toggle_indicator &&
          contact_pos_transaction_limit_amount == o.contact_pos_transaction_limit_amount &&
          non_pos_txn_limit_toggle_indicator == o.non_pos_txn_limit_toggle_indicator &&
          non_pos_transaction_limit_amount == o.non_pos_transaction_limit_amount
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [atm_transaction_limit_toggle_indicator, atm_transaction_limit_amount, contactless_txn_limit_toggle_indicator, contactless_transaction_limit_amount, contact_pos_txn_limit_toggle_indicator, contact_pos_transaction_limit_amount, non_pos_txn_limit_toggle_indicator, non_pos_transaction_limit_amount].hash
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
