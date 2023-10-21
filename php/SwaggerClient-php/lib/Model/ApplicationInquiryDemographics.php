<?php
/**
 * ApplicationInquiryDemographics
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.29
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * ApplicationInquiryDemographics Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryDemographics implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryDemographics';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'gender' => 'string',
'date_of_birth' => '\DateTime',
'place_of_birth' => 'string',
'country_of_birth' => 'string',
'nationality' => 'string',
'domicile_country_code' => 'string',
'permanent_residency_country_code' => 'string',
'marital_status' => 'string',
'residency_status' => 'string',
'residence_type' => 'string',
'tax_domicile_country_code' => 'string',
'spoken_language_code' => 'string',
'correspondence_language_code' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'gender' => null,
'date_of_birth' => 'date',
'place_of_birth' => null,
'country_of_birth' => null,
'nationality' => null,
'domicile_country_code' => null,
'permanent_residency_country_code' => null,
'marital_status' => null,
'residency_status' => null,
'residence_type' => null,
'tax_domicile_country_code' => null,
'spoken_language_code' => null,
'correspondence_language_code' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'gender' => 'gender',
'date_of_birth' => 'dateOfBirth',
'place_of_birth' => 'placeOfBirth',
'country_of_birth' => 'countryOfBirth',
'nationality' => 'nationality',
'domicile_country_code' => 'domicileCountryCode',
'permanent_residency_country_code' => 'permanentResidencyCountryCode',
'marital_status' => 'maritalStatus',
'residency_status' => 'residencyStatus',
'residence_type' => 'residenceType',
'tax_domicile_country_code' => 'taxDomicileCountryCode',
'spoken_language_code' => 'spokenLanguageCode',
'correspondence_language_code' => 'correspondenceLanguageCode'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'gender' => 'setGender',
'date_of_birth' => 'setDateOfBirth',
'place_of_birth' => 'setPlaceOfBirth',
'country_of_birth' => 'setCountryOfBirth',
'nationality' => 'setNationality',
'domicile_country_code' => 'setDomicileCountryCode',
'permanent_residency_country_code' => 'setPermanentResidencyCountryCode',
'marital_status' => 'setMaritalStatus',
'residency_status' => 'setResidencyStatus',
'residence_type' => 'setResidenceType',
'tax_domicile_country_code' => 'setTaxDomicileCountryCode',
'spoken_language_code' => 'setSpokenLanguageCode',
'correspondence_language_code' => 'setCorrespondenceLanguageCode'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'gender' => 'getGender',
'date_of_birth' => 'getDateOfBirth',
'place_of_birth' => 'getPlaceOfBirth',
'country_of_birth' => 'getCountryOfBirth',
'nationality' => 'getNationality',
'domicile_country_code' => 'getDomicileCountryCode',
'permanent_residency_country_code' => 'getPermanentResidencyCountryCode',
'marital_status' => 'getMaritalStatus',
'residency_status' => 'getResidencyStatus',
'residence_type' => 'getResidenceType',
'tax_domicile_country_code' => 'getTaxDomicileCountryCode',
'spoken_language_code' => 'getSpokenLanguageCode',
'correspondence_language_code' => 'getCorrespondenceLanguageCode'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['gender'] = isset($data['gender']) ? $data['gender'] : null;
        $this->container['date_of_birth'] = isset($data['date_of_birth']) ? $data['date_of_birth'] : null;
        $this->container['place_of_birth'] = isset($data['place_of_birth']) ? $data['place_of_birth'] : null;
        $this->container['country_of_birth'] = isset($data['country_of_birth']) ? $data['country_of_birth'] : null;
        $this->container['nationality'] = isset($data['nationality']) ? $data['nationality'] : null;
        $this->container['domicile_country_code'] = isset($data['domicile_country_code']) ? $data['domicile_country_code'] : null;
        $this->container['permanent_residency_country_code'] = isset($data['permanent_residency_country_code']) ? $data['permanent_residency_country_code'] : null;
        $this->container['marital_status'] = isset($data['marital_status']) ? $data['marital_status'] : null;
        $this->container['residency_status'] = isset($data['residency_status']) ? $data['residency_status'] : null;
        $this->container['residence_type'] = isset($data['residence_type']) ? $data['residence_type'] : null;
        $this->container['tax_domicile_country_code'] = isset($data['tax_domicile_country_code']) ? $data['tax_domicile_country_code'] : null;
        $this->container['spoken_language_code'] = isset($data['spoken_language_code']) ? $data['spoken_language_code'] : null;
        $this->container['correspondence_language_code'] = isset($data['correspondence_language_code']) ? $data['correspondence_language_code'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets gender
     *
     * @return string
     */
    public function getGender()
    {
        return $this->container['gender'];
    }

    /**
     * Sets gender
     *
     * @param string $gender Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setGender($gender)
    {
        $this->container['gender'] = $gender;

        return $this;
    }

    /**
     * Gets date_of_birth
     *
     * @return \DateTime
     */
    public function getDateOfBirth()
    {
        return $this->container['date_of_birth'];
    }

    /**
     * Sets date_of_birth
     *
     * @param \DateTime $date_of_birth Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setDateOfBirth($date_of_birth)
    {
        $this->container['date_of_birth'] = $date_of_birth;

        return $this;
    }

    /**
     * Gets place_of_birth
     *
     * @return string
     */
    public function getPlaceOfBirth()
    {
        return $this->container['place_of_birth'];
    }

    /**
     * Sets place_of_birth
     *
     * @param string $place_of_birth Applicant's place of birth
     *
     * @return $this
     */
    public function setPlaceOfBirth($place_of_birth)
    {
        $this->container['place_of_birth'] = $place_of_birth;

        return $this;
    }

    /**
     * Gets country_of_birth
     *
     * @return string
     */
    public function getCountryOfBirth()
    {
        return $this->container['country_of_birth'];
    }

    /**
     * Sets country_of_birth
     *
     * @param string $country_of_birth Applicant's Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCountryOfBirth($country_of_birth)
    {
        $this->container['country_of_birth'] = $country_of_birth;

        return $this;
    }

    /**
     * Gets nationality
     *
     * @return string
     */
    public function getNationality()
    {
        return $this->container['nationality'];
    }

    /**
     * Sets nationality
     *
     * @param string $nationality Applicant's nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setNationality($nationality)
    {
        $this->container['nationality'] = $nationality;

        return $this;
    }

    /**
     * Gets domicile_country_code
     *
     * @return string
     */
    public function getDomicileCountryCode()
    {
        return $this->container['domicile_country_code'];
    }

    /**
     * Sets domicile_country_code
     *
     * @param string $domicile_country_code Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setDomicileCountryCode($domicile_country_code)
    {
        $this->container['domicile_country_code'] = $domicile_country_code;

        return $this;
    }

    /**
     * Gets permanent_residency_country_code
     *
     * @return string
     */
    public function getPermanentResidencyCountryCode()
    {
        return $this->container['permanent_residency_country_code'];
    }

    /**
     * Sets permanent_residency_country_code
     *
     * @param string $permanent_residency_country_code Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setPermanentResidencyCountryCode($permanent_residency_country_code)
    {
        $this->container['permanent_residency_country_code'] = $permanent_residency_country_code;

        return $this;
    }

    /**
     * Gets marital_status
     *
     * @return string
     */
    public function getMaritalStatus()
    {
        return $this->container['marital_status'];
    }

    /**
     * Sets marital_status
     *
     * @param string $marital_status Applicant's marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setMaritalStatus($marital_status)
    {
        $this->container['marital_status'] = $marital_status;

        return $this;
    }

    /**
     * Gets residency_status
     *
     * @return string
     */
    public function getResidencyStatus()
    {
        return $this->container['residency_status'];
    }

    /**
     * Sets residency_status
     *
     * @param string $residency_status Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setResidencyStatus($residency_status)
    {
        $this->container['residency_status'] = $residency_status;

        return $this;
    }

    /**
     * Gets residence_type
     *
     * @return string
     */
    public function getResidenceType()
    {
        return $this->container['residence_type'];
    }

    /**
     * Sets residence_type
     *
     * @param string $residence_type Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setResidenceType($residence_type)
    {
        $this->container['residence_type'] = $residence_type;

        return $this;
    }

    /**
     * Gets tax_domicile_country_code
     *
     * @return string
     */
    public function getTaxDomicileCountryCode()
    {
        return $this->container['tax_domicile_country_code'];
    }

    /**
     * Sets tax_domicile_country_code
     *
     * @param string $tax_domicile_country_code Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setTaxDomicileCountryCode($tax_domicile_country_code)
    {
        $this->container['tax_domicile_country_code'] = $tax_domicile_country_code;

        return $this;
    }

    /**
     * Gets spoken_language_code
     *
     * @return string
     */
    public function getSpokenLanguageCode()
    {
        return $this->container['spoken_language_code'];
    }

    /**
     * Sets spoken_language_code
     *
     * @param string $spoken_language_code Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setSpokenLanguageCode($spoken_language_code)
    {
        $this->container['spoken_language_code'] = $spoken_language_code;

        return $this;
    }

    /**
     * Gets correspondence_language_code
     *
     * @return string
     */
    public function getCorrespondenceLanguageCode()
    {
        return $this->container['correspondence_language_code'];
    }

    /**
     * Sets correspondence_language_code
     *
     * @param string $correspondence_language_code Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCorrespondenceLanguageCode($correspondence_language_code)
    {
        $this->container['correspondence_language_code'] = $correspondence_language_code;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
