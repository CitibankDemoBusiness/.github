=begin
#ConsumerDataStandards_Digital_Regulatory

#The product \\amp Product Details APIs allow third-parties to retrieve a list of Product categories \\amp details for Citi and our White-label Partners.

OpenAPI spec version: 1.2.0
Contact: cdr-data61@csiro.au
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  # Defines the sub-tier criteria and conditions for which a rate applies
  class BankingProductRateTierSubTier
    # A display name for the tier
    attr_accessor :name

    # The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. a  **DOLLAR** amount. **PERCENT** (in the case of loan-to-value ratio or LVR). Tier term period representing a discrete number  of **MONTH**'s or **DAY**'s (in the case of term deposit tiers)
    attr_accessor :unit_of_measure

    # The number of tierUnitOfMeasure units that form the lower bound of the tier. The tier should be  inclusive of this value
    attr_accessor :minimum_value

    # The number of tierUnitOfMeasure units that form the upper bound of the tier or band. For a tier  with a discrete value (as opposed to a range of values e.g. 1 month) this must be the same as tierValueMinimum. Where this  is the same as the tierValueMinimum value of the next-higher tier the referenced tier should be exclusive of this value.  For example a term deposit of 2 months falls into the upper tier of the following tiers: (1 – 2 months, 2 – 3 months)
    attr_accessor :maximum_value

    # The method used to calculate the amount to be applied using one or more tiers. A single rate may  be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that  tier (referred to as 'bands' or 'steps')
    attr_accessor :rate_application_method

    attr_accessor :applicability_conditions

    class EnumAttributeValidator
      attr_reader :datatype
      attr_reader :allowable_values

      def initialize(datatype, allowable_values)
        @allowable_values = allowable_values.map do |value|
          case datatype.to_s
          when /Integer/i
            value.to_i
          when /Float/i
            value.to_f
          else
            value
          end
        end
      end

      def valid?(value)
        !value || allowable_values.include?(value)
      end
    end

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'name' => :'name',
        :'unit_of_measure' => :'unitOfMeasure',
        :'minimum_value' => :'minimumValue',
        :'maximum_value' => :'maximumValue',
        :'rate_application_method' => :'rateApplicationMethod',
        :'applicability_conditions' => :'applicabilityConditions'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'name' => :'Object',
        :'unit_of_measure' => :'Object',
        :'minimum_value' => :'Object',
        :'maximum_value' => :'Object',
        :'rate_application_method' => :'Object',
        :'applicability_conditions' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::BankingProductRateTierSubTier` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::BankingProductRateTierSubTier`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'unit_of_measure')
        self.unit_of_measure = attributes[:'unit_of_measure']
      end

      if attributes.key?(:'minimum_value')
        self.minimum_value = attributes[:'minimum_value']
      end

      if attributes.key?(:'maximum_value')
        self.maximum_value = attributes[:'maximum_value']
      end

      if attributes.key?(:'rate_application_method')
        self.rate_application_method = attributes[:'rate_application_method']
      end

      if attributes.key?(:'applicability_conditions')
        self.applicability_conditions = attributes[:'applicability_conditions']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @name.nil?
        invalid_properties.push('invalid value for "name", name cannot be nil.')
      end

      if @unit_of_measure.nil?
        invalid_properties.push('invalid value for "unit_of_measure", unit_of_measure cannot be nil.')
      end

      if @minimum_value.nil?
        invalid_properties.push('invalid value for "minimum_value", minimum_value cannot be nil.')
      end

      if @maximum_value.nil?
        invalid_properties.push('invalid value for "maximum_value", maximum_value cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @name.nil?
      return false if @unit_of_measure.nil?
      unit_of_measure_validator = EnumAttributeValidator.new('Object', ['DOLLAR', 'PERCENT', 'MONTH', 'DAY'])
      return false unless unit_of_measure_validator.valid?(@unit_of_measure)
      return false if @minimum_value.nil?
      return false if @maximum_value.nil?
      rate_application_method_validator = EnumAttributeValidator.new('Object', ['WHOLE_BALANCE', 'PER_TIER'])
      return false unless rate_application_method_validator.valid?(@rate_application_method)
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] unit_of_measure Object to be assigned
    def unit_of_measure=(unit_of_measure)
      validator = EnumAttributeValidator.new('Object', ['DOLLAR', 'PERCENT', 'MONTH', 'DAY'])
      unless validator.valid?(unit_of_measure)
        fail ArgumentError, "invalid value for \"unit_of_measure\", must be one of #{validator.allowable_values}."
      end
      @unit_of_measure = unit_of_measure
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] rate_application_method Object to be assigned
    def rate_application_method=(rate_application_method)
      validator = EnumAttributeValidator.new('Object', ['WHOLE_BALANCE', 'PER_TIER'])
      unless validator.valid?(rate_application_method)
        fail ArgumentError, "invalid value for \"rate_application_method\", must be one of #{validator.allowable_values}."
      end
      @rate_application_method = rate_application_method
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          name == o.name &&
          unit_of_measure == o.unit_of_measure &&
          minimum_value == o.minimum_value &&
          maximum_value == o.maximum_value &&
          rate_application_method == o.rate_application_method &&
          applicability_conditions == o.applicability_conditions
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [name, unit_of_measure, minimum_value, maximum_value, rate_application_method, applicability_conditions].hash
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
