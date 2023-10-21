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
  class BankingProductDetail
    # A data holder specific unique identifier for this product. This identifier must be unique to a  product but does not otherwise need to adhere to ID permanence guidelines.
    attr_accessor :product_id

    # The date and time from which this product is effective (ie. is available for origination).  Used  to enable the articulation of products to the regime before they are available for customers to originate
    attr_accessor :effective_from

    # The date and time at which this product will be retired and will no longer be offered.  Used to  enable the managed deprecation of products
    attr_accessor :effective_to

    # The last date and time that the information for this product was changed (or the creation date  for the product if it has never been altered)
    attr_accessor :last_updated

    attr_accessor :product_category

    # The display name of the product
    attr_accessor :name

    # A description of the product
    attr_accessor :description

    # A label of the brand for the product. Able to be used for filtering. For data holders with  single brands this value is still required
    attr_accessor :brand

    # An optional display name of the brand
    attr_accessor :brand_name

    # A link to an application web page where this product can be applied for.
    attr_accessor :application_uri

    # Indicates whether the product is specifically tailored to a circumstance.  In this case fees and  prices are significantly negotiated depending on context. While all products are open to a degree of tailoring this flag  indicates that tailoring is expected and thus that the provision of specific fees and rates is not applicable
    attr_accessor :is_tailored

    attr_accessor :additional_information

    # An array of card art images
    attr_accessor :card_art

    # An array of bundles that this product participates in.  Each bundle is described by free form  information but also by a list of product IDs of the other products that are included in the bundle.  It is assumed that  the current product is included in the bundle also
    attr_accessor :bundles

    # Array of features available for the product
    attr_accessor :features

    # Constraints on the application for or operation of the product such as minimum balances or  limit thresholds
    attr_accessor :constraints

    # Eligibility criteria for the product
    attr_accessor :eligibility

    # Fees applicable for the product
    attr_accessor :fees

    # Interest rates available for deposits
    attr_accessor :deposit_rates

    # Interest rates charged against lending balances
    attr_accessor :lending_rates

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'product_id' => :'productId',
        :'effective_from' => :'effectiveFrom',
        :'effective_to' => :'effectiveTo',
        :'last_updated' => :'lastUpdated',
        :'product_category' => :'productCategory',
        :'name' => :'name',
        :'description' => :'description',
        :'brand' => :'brand',
        :'brand_name' => :'brandName',
        :'application_uri' => :'applicationUri',
        :'is_tailored' => :'isTailored',
        :'additional_information' => :'additionalInformation',
        :'card_art' => :'cardArt',
        :'bundles' => :'bundles',
        :'features' => :'features',
        :'constraints' => :'constraints',
        :'eligibility' => :'eligibility',
        :'fees' => :'fees',
        :'deposit_rates' => :'depositRates',
        :'lending_rates' => :'lendingRates'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'product_id' => :'',
        :'effective_from' => :'',
        :'effective_to' => :'',
        :'last_updated' => :'',
        :'product_category' => :'',
        :'name' => :'',
        :'description' => :'',
        :'brand' => :'',
        :'brand_name' => :'',
        :'application_uri' => :'',
        :'is_tailored' => :'',
        :'additional_information' => :'',
        :'card_art' => :'',
        :'bundles' => :'',
        :'features' => :'',
        :'constraints' => :'',
        :'eligibility' => :'',
        :'fees' => :'',
        :'deposit_rates' => :'',
        :'lending_rates' => :''
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::BankingProductDetail` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::BankingProductDetail`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      # call parent's initialize
      super(attributes)

      if attributes.key?(:'product_id')
        self.product_id = attributes[:'product_id']
      end

      if attributes.key?(:'effective_from')
        self.effective_from = attributes[:'effective_from']
      end

      if attributes.key?(:'effective_to')
        self.effective_to = attributes[:'effective_to']
      end

      if attributes.key?(:'last_updated')
        self.last_updated = attributes[:'last_updated']
      end

      if attributes.key?(:'product_category')
        self.product_category = attributes[:'product_category']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'description')
        self.description = attributes[:'description']
      end

      if attributes.key?(:'brand')
        self.brand = attributes[:'brand']
      end

      if attributes.key?(:'brand_name')
        self.brand_name = attributes[:'brand_name']
      end

      if attributes.key?(:'application_uri')
        self.application_uri = attributes[:'application_uri']
      end

      if attributes.key?(:'is_tailored')
        self.is_tailored = attributes[:'is_tailored']
      end

      if attributes.key?(:'additional_information')
        self.additional_information = attributes[:'additional_information']
      end

      if attributes.key?(:'card_art')
        if (value = attributes[:'card_art']).is_a?(Array)
          self.card_art = value
        end
      end

      if attributes.key?(:'bundles')
        if (value = attributes[:'bundles']).is_a?(Array)
          self.bundles = value
        end
      end

      if attributes.key?(:'features')
        if (value = attributes[:'features']).is_a?(Array)
          self.features = value
        end
      end

      if attributes.key?(:'constraints')
        if (value = attributes[:'constraints']).is_a?(Array)
          self.constraints = value
        end
      end

      if attributes.key?(:'eligibility')
        if (value = attributes[:'eligibility']).is_a?(Array)
          self.eligibility = value
        end
      end

      if attributes.key?(:'fees')
        if (value = attributes[:'fees']).is_a?(Array)
          self.fees = value
        end
      end

      if attributes.key?(:'deposit_rates')
        if (value = attributes[:'deposit_rates']).is_a?(Array)
          self.deposit_rates = value
        end
      end

      if attributes.key?(:'lending_rates')
        if (value = attributes[:'lending_rates']).is_a?(Array)
          self.lending_rates = value
        end
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = super
      if @product_id.nil?
        invalid_properties.push('invalid value for "product_id", product_id cannot be nil.')
      end

      if @last_updated.nil?
        invalid_properties.push('invalid value for "last_updated", last_updated cannot be nil.')
      end

      if @product_category.nil?
        invalid_properties.push('invalid value for "product_category", product_category cannot be nil.')
      end

      if @name.nil?
        invalid_properties.push('invalid value for "name", name cannot be nil.')
      end

      if @description.nil?
        invalid_properties.push('invalid value for "description", description cannot be nil.')
      end

      if @brand.nil?
        invalid_properties.push('invalid value for "brand", brand cannot be nil.')
      end

      if @is_tailored.nil?
        invalid_properties.push('invalid value for "is_tailored", is_tailored cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @product_id.nil?
      return false if @last_updated.nil?
      return false if @product_category.nil?
      return false if @name.nil?
      return false if @description.nil?
      return false if @brand.nil?
      return false if @is_tailored.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          product_id == o.product_id &&
          effective_from == o.effective_from &&
          effective_to == o.effective_to &&
          last_updated == o.last_updated &&
          product_category == o.product_category &&
          name == o.name &&
          description == o.description &&
          brand == o.brand &&
          brand_name == o.brand_name &&
          application_uri == o.application_uri &&
          is_tailored == o.is_tailored &&
          additional_information == o.additional_information &&
          card_art == o.card_art &&
          bundles == o.bundles &&
          features == o.features &&
          constraints == o.constraints &&
          eligibility == o.eligibility &&
          fees == o.fees &&
          deposit_rates == o.deposit_rates &&
          lending_rates == o.lending_rates && super(o)
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [product_id, effective_from, effective_to, last_updated, product_category, name, description, brand, brand_name, application_uri, is_tailored, additional_information, card_art, bundles, features, constraints, eligibility, fees, deposit_rates, lending_rates].hash
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
      super(attributes)
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
      hash = super
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
