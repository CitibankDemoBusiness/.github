=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class ECMAdditionalDataUpdate
    # Indicates whether the customer wants a separate cash PIN.
    attr_accessor :cash_pin_flag

    attr_accessor :utility_bill_details

    # Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.
    attr_accessor :billing_cycle_day

    # Unique reference ID associated with the application
    attr_accessor :application_reference_id

    # This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between
    attr_accessor :printing_serial_number

    # Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.
    attr_accessor :account_fund_source

    # The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application
    attr_accessor :media_id

    attr_accessor :referral_tracking

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'cash_pin_flag' => :'cashPinFlag',
        :'utility_bill_details' => :'utilityBillDetails',
        :'billing_cycle_day' => :'billingCycleDay',
        :'application_reference_id' => :'applicationReferenceId',
        :'printing_serial_number' => :'printingSerialNumber',
        :'account_fund_source' => :'accountFundSource',
        :'media_id' => :'mediaId',
        :'referral_tracking' => :'referralTracking'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'cash_pin_flag' => :'Object',
        :'utility_bill_details' => :'Object',
        :'billing_cycle_day' => :'Object',
        :'application_reference_id' => :'Object',
        :'printing_serial_number' => :'Object',
        :'account_fund_source' => :'Object',
        :'media_id' => :'Object',
        :'referral_tracking' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ECMAdditionalDataUpdate` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ECMAdditionalDataUpdate`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'cash_pin_flag')
        self.cash_pin_flag = attributes[:'cash_pin_flag']
      end

      if attributes.key?(:'utility_bill_details')
        self.utility_bill_details = attributes[:'utility_bill_details']
      end

      if attributes.key?(:'billing_cycle_day')
        self.billing_cycle_day = attributes[:'billing_cycle_day']
      end

      if attributes.key?(:'application_reference_id')
        self.application_reference_id = attributes[:'application_reference_id']
      end

      if attributes.key?(:'printing_serial_number')
        self.printing_serial_number = attributes[:'printing_serial_number']
      end

      if attributes.key?(:'account_fund_source')
        self.account_fund_source = attributes[:'account_fund_source']
      end

      if attributes.key?(:'media_id')
        self.media_id = attributes[:'media_id']
      end

      if attributes.key?(:'referral_tracking')
        self.referral_tracking = attributes[:'referral_tracking']
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
          cash_pin_flag == o.cash_pin_flag &&
          utility_bill_details == o.utility_bill_details &&
          billing_cycle_day == o.billing_cycle_day &&
          application_reference_id == o.application_reference_id &&
          printing_serial_number == o.printing_serial_number &&
          account_fund_source == o.account_fund_source &&
          media_id == o.media_id &&
          referral_tracking == o.referral_tracking
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [cash_pin_flag, utility_bill_details, billing_cycle_day, application_reference_id, printing_serial_number, account_fund_source, media_id, referral_tracking].hash
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
