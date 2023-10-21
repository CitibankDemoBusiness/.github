=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class ApplicationUpdateApplicant
    attr_accessor :name

    attr_accessor :phone

    attr_accessor :email

    attr_accessor :ocr

    attr_accessor :demographics

    attr_accessor :address

    attr_accessor :contact_preference

    attr_accessor :contact_consent

    attr_accessor :financial_information

    # Mother's maiden name
    attr_accessor :mother_maiden_name

    attr_accessor :education

    attr_accessor :employment_details

    attr_accessor :identification_document_details

    attr_accessor :additional_data

    attr_accessor :partner_customer_details

    attr_accessor :consent_details

    attr_accessor :marketing_consent

    attr_accessor :self_declaration

    attr_accessor :kyc_information

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'name' => :'name',
        :'phone' => :'phone',
        :'email' => :'email',
        :'ocr' => :'ocr',
        :'demographics' => :'demographics',
        :'address' => :'address',
        :'contact_preference' => :'contactPreference',
        :'contact_consent' => :'contactConsent',
        :'financial_information' => :'financialInformation',
        :'mother_maiden_name' => :'motherMaidenName',
        :'education' => :'education',
        :'employment_details' => :'employmentDetails',
        :'identification_document_details' => :'identificationDocumentDetails',
        :'additional_data' => :'additionalData',
        :'partner_customer_details' => :'partnerCustomerDetails',
        :'consent_details' => :'consentDetails',
        :'marketing_consent' => :'marketingConsent',
        :'self_declaration' => :'selfDeclaration',
        :'kyc_information' => :'kycInformation'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'name' => :'Object',
        :'phone' => :'Object',
        :'email' => :'Object',
        :'ocr' => :'Object',
        :'demographics' => :'Object',
        :'address' => :'Object',
        :'contact_preference' => :'Object',
        :'contact_consent' => :'Object',
        :'financial_information' => :'Object',
        :'mother_maiden_name' => :'Object',
        :'education' => :'Object',
        :'employment_details' => :'Object',
        :'identification_document_details' => :'Object',
        :'additional_data' => :'Object',
        :'partner_customer_details' => :'Object',
        :'consent_details' => :'Object',
        :'marketing_consent' => :'Object',
        :'self_declaration' => :'Object',
        :'kyc_information' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ApplicationUpdateApplicant` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ApplicationUpdateApplicant`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'phone')
        if (value = attributes[:'phone']).is_a?(Array)
          self.phone = value
        end
      end

      if attributes.key?(:'email')
        if (value = attributes[:'email']).is_a?(Array)
          self.email = value
        end
      end

      if attributes.key?(:'ocr')
        self.ocr = attributes[:'ocr']
      end

      if attributes.key?(:'demographics')
        self.demographics = attributes[:'demographics']
      end

      if attributes.key?(:'address')
        if (value = attributes[:'address']).is_a?(Array)
          self.address = value
        end
      end

      if attributes.key?(:'contact_preference')
        self.contact_preference = attributes[:'contact_preference']
      end

      if attributes.key?(:'contact_consent')
        self.contact_consent = attributes[:'contact_consent']
      end

      if attributes.key?(:'financial_information')
        self.financial_information = attributes[:'financial_information']
      end

      if attributes.key?(:'mother_maiden_name')
        self.mother_maiden_name = attributes[:'mother_maiden_name']
      end

      if attributes.key?(:'education')
        self.education = attributes[:'education']
      end

      if attributes.key?(:'employment_details')
        if (value = attributes[:'employment_details']).is_a?(Array)
          self.employment_details = value
        end
      end

      if attributes.key?(:'identification_document_details')
        if (value = attributes[:'identification_document_details']).is_a?(Array)
          self.identification_document_details = value
        end
      end

      if attributes.key?(:'additional_data')
        self.additional_data = attributes[:'additional_data']
      end

      if attributes.key?(:'partner_customer_details')
        self.partner_customer_details = attributes[:'partner_customer_details']
      end

      if attributes.key?(:'consent_details')
        if (value = attributes[:'consent_details']).is_a?(Array)
          self.consent_details = value
        end
      end

      if attributes.key?(:'marketing_consent')
        self.marketing_consent = attributes[:'marketing_consent']
      end

      if attributes.key?(:'self_declaration')
        self.self_declaration = attributes[:'self_declaration']
      end

      if attributes.key?(:'kyc_information')
        self.kyc_information = attributes[:'kyc_information']
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
          name == o.name &&
          phone == o.phone &&
          email == o.email &&
          ocr == o.ocr &&
          demographics == o.demographics &&
          address == o.address &&
          contact_preference == o.contact_preference &&
          contact_consent == o.contact_consent &&
          financial_information == o.financial_information &&
          mother_maiden_name == o.mother_maiden_name &&
          education == o.education &&
          employment_details == o.employment_details &&
          identification_document_details == o.identification_document_details &&
          additional_data == o.additional_data &&
          partner_customer_details == o.partner_customer_details &&
          consent_details == o.consent_details &&
          marketing_consent == o.marketing_consent &&
          self_declaration == o.self_declaration &&
          kyc_information == o.kyc_information
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [name, phone, email, ocr, demographics, address, contact_preference, contact_consent, financial_information, mother_maiden_name, education, employment_details, identification_document_details, additional_data, partner_customer_details, consent_details, marketing_consent, self_declaration, kyc_information].hash
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
