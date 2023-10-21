<?php
/**
 * ApplicationUpdateAdditionalData
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
 * ApplicationUpdateAdditionalData Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationUpdateAdditionalData implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationUpdateAdditionalData';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'number_of_dependents' => 'float',
'staff_indicator' => 'bool',
'business_nature' => 'string',
'emergency_contact_name' => 'string',
'emergency_contact_phone_number' => 'string',
'over_limit_consent_flag' => 'bool',
'country_specific_group' => '\Swagger\Client\Model\ApplicationUpdateCountrySpecificGroup',
'primary_bank_details' => '\Swagger\Client\Model\ApplicationUpdatePrimaryBankDetails',
'referral_given_name' => 'string',
'referral_surname' => 'string',
'related_to_citi_employee_flag' => 'bool',
'related_citi_employee_name' => 'string',
'related_citi_employee_department' => 'string',
'credit_card_usage_purpose' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'number_of_dependents' => null,
'staff_indicator' => null,
'business_nature' => null,
'emergency_contact_name' => null,
'emergency_contact_phone_number' => null,
'over_limit_consent_flag' => null,
'country_specific_group' => null,
'primary_bank_details' => null,
'referral_given_name' => null,
'referral_surname' => null,
'related_to_citi_employee_flag' => null,
'related_citi_employee_name' => null,
'related_citi_employee_department' => null,
'credit_card_usage_purpose' => null    ];

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
        'number_of_dependents' => 'numberOfDependents',
'staff_indicator' => 'staffIndicator',
'business_nature' => 'businessNature',
'emergency_contact_name' => 'emergencyContactName',
'emergency_contact_phone_number' => 'emergencyContactPhoneNumber',
'over_limit_consent_flag' => 'overLimitConsentFlag',
'country_specific_group' => 'countrySpecificGroup',
'primary_bank_details' => 'primaryBankDetails',
'referral_given_name' => 'referralGivenName',
'referral_surname' => 'referralSurname',
'related_to_citi_employee_flag' => 'relatedToCitiEmployeeFlag',
'related_citi_employee_name' => 'relatedCitiEmployeeName',
'related_citi_employee_department' => 'relatedCitiEmployeeDepartment',
'credit_card_usage_purpose' => 'creditCardUsagePurpose'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'number_of_dependents' => 'setNumberOfDependents',
'staff_indicator' => 'setStaffIndicator',
'business_nature' => 'setBusinessNature',
'emergency_contact_name' => 'setEmergencyContactName',
'emergency_contact_phone_number' => 'setEmergencyContactPhoneNumber',
'over_limit_consent_flag' => 'setOverLimitConsentFlag',
'country_specific_group' => 'setCountrySpecificGroup',
'primary_bank_details' => 'setPrimaryBankDetails',
'referral_given_name' => 'setReferralGivenName',
'referral_surname' => 'setReferralSurname',
'related_to_citi_employee_flag' => 'setRelatedToCitiEmployeeFlag',
'related_citi_employee_name' => 'setRelatedCitiEmployeeName',
'related_citi_employee_department' => 'setRelatedCitiEmployeeDepartment',
'credit_card_usage_purpose' => 'setCreditCardUsagePurpose'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'number_of_dependents' => 'getNumberOfDependents',
'staff_indicator' => 'getStaffIndicator',
'business_nature' => 'getBusinessNature',
'emergency_contact_name' => 'getEmergencyContactName',
'emergency_contact_phone_number' => 'getEmergencyContactPhoneNumber',
'over_limit_consent_flag' => 'getOverLimitConsentFlag',
'country_specific_group' => 'getCountrySpecificGroup',
'primary_bank_details' => 'getPrimaryBankDetails',
'referral_given_name' => 'getReferralGivenName',
'referral_surname' => 'getReferralSurname',
'related_to_citi_employee_flag' => 'getRelatedToCitiEmployeeFlag',
'related_citi_employee_name' => 'getRelatedCitiEmployeeName',
'related_citi_employee_department' => 'getRelatedCitiEmployeeDepartment',
'credit_card_usage_purpose' => 'getCreditCardUsagePurpose'    ];

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
        $this->container['number_of_dependents'] = isset($data['number_of_dependents']) ? $data['number_of_dependents'] : null;
        $this->container['staff_indicator'] = isset($data['staff_indicator']) ? $data['staff_indicator'] : null;
        $this->container['business_nature'] = isset($data['business_nature']) ? $data['business_nature'] : null;
        $this->container['emergency_contact_name'] = isset($data['emergency_contact_name']) ? $data['emergency_contact_name'] : null;
        $this->container['emergency_contact_phone_number'] = isset($data['emergency_contact_phone_number']) ? $data['emergency_contact_phone_number'] : null;
        $this->container['over_limit_consent_flag'] = isset($data['over_limit_consent_flag']) ? $data['over_limit_consent_flag'] : null;
        $this->container['country_specific_group'] = isset($data['country_specific_group']) ? $data['country_specific_group'] : null;
        $this->container['primary_bank_details'] = isset($data['primary_bank_details']) ? $data['primary_bank_details'] : null;
        $this->container['referral_given_name'] = isset($data['referral_given_name']) ? $data['referral_given_name'] : null;
        $this->container['referral_surname'] = isset($data['referral_surname']) ? $data['referral_surname'] : null;
        $this->container['related_to_citi_employee_flag'] = isset($data['related_to_citi_employee_flag']) ? $data['related_to_citi_employee_flag'] : null;
        $this->container['related_citi_employee_name'] = isset($data['related_citi_employee_name']) ? $data['related_citi_employee_name'] : null;
        $this->container['related_citi_employee_department'] = isset($data['related_citi_employee_department']) ? $data['related_citi_employee_department'] : null;
        $this->container['credit_card_usage_purpose'] = isset($data['credit_card_usage_purpose']) ? $data['credit_card_usage_purpose'] : null;
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
     * Gets number_of_dependents
     *
     * @return float
     */
    public function getNumberOfDependents()
    {
        return $this->container['number_of_dependents'];
    }

    /**
     * Sets number_of_dependents
     *
     * @param float $number_of_dependents Number of dependants
     *
     * @return $this
     */
    public function setNumberOfDependents($number_of_dependents)
    {
        $this->container['number_of_dependents'] = $number_of_dependents;

        return $this;
    }

    /**
     * Gets staff_indicator
     *
     * @return bool
     */
    public function getStaffIndicator()
    {
        return $this->container['staff_indicator'];
    }

    /**
     * Sets staff_indicator
     *
     * @param bool $staff_indicator Flag to indicates if applicant is a Citi Staff. Valid values: true and false
     *
     * @return $this
     */
    public function setStaffIndicator($staff_indicator)
    {
        $this->container['staff_indicator'] = $staff_indicator;

        return $this;
    }

    /**
     * Gets business_nature
     *
     * @return string
     */
    public function getBusinessNature()
    {
        return $this->container['business_nature'];
    }

    /**
     * Sets business_nature
     *
     * @param string $business_nature Business nature of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setBusinessNature($business_nature)
    {
        $this->container['business_nature'] = $business_nature;

        return $this;
    }

    /**
     * Gets emergency_contact_name
     *
     * @return string
     */
    public function getEmergencyContactName()
    {
        return $this->container['emergency_contact_name'];
    }

    /**
     * Sets emergency_contact_name
     *
     * @param string $emergency_contact_name Emergency Contact Name
     *
     * @return $this
     */
    public function setEmergencyContactName($emergency_contact_name)
    {
        $this->container['emergency_contact_name'] = $emergency_contact_name;

        return $this;
    }

    /**
     * Gets emergency_contact_phone_number
     *
     * @return string
     */
    public function getEmergencyContactPhoneNumber()
    {
        return $this->container['emergency_contact_phone_number'];
    }

    /**
     * Sets emergency_contact_phone_number
     *
     * @param string $emergency_contact_phone_number Emergency Contact Number.
     *
     * @return $this
     */
    public function setEmergencyContactPhoneNumber($emergency_contact_phone_number)
    {
        $this->container['emergency_contact_phone_number'] = $emergency_contact_phone_number;

        return $this;
    }

    /**
     * Gets over_limit_consent_flag
     *
     * @return bool
     */
    public function getOverLimitConsentFlag()
    {
        return $this->container['over_limit_consent_flag'];
    }

    /**
     * Sets over_limit_consent_flag
     *
     * @param bool $over_limit_consent_flag Customer Consent on spending more than the limit assigned to him. Valid values: true and false
     *
     * @return $this
     */
    public function setOverLimitConsentFlag($over_limit_consent_flag)
    {
        $this->container['over_limit_consent_flag'] = $over_limit_consent_flag;

        return $this;
    }

    /**
     * Gets country_specific_group
     *
     * @return \Swagger\Client\Model\ApplicationUpdateCountrySpecificGroup
     */
    public function getCountrySpecificGroup()
    {
        return $this->container['country_specific_group'];
    }

    /**
     * Sets country_specific_group
     *
     * @param \Swagger\Client\Model\ApplicationUpdateCountrySpecificGroup $country_specific_group country_specific_group
     *
     * @return $this
     */
    public function setCountrySpecificGroup($country_specific_group)
    {
        $this->container['country_specific_group'] = $country_specific_group;

        return $this;
    }

    /**
     * Gets primary_bank_details
     *
     * @return \Swagger\Client\Model\ApplicationUpdatePrimaryBankDetails
     */
    public function getPrimaryBankDetails()
    {
        return $this->container['primary_bank_details'];
    }

    /**
     * Sets primary_bank_details
     *
     * @param \Swagger\Client\Model\ApplicationUpdatePrimaryBankDetails $primary_bank_details primary_bank_details
     *
     * @return $this
     */
    public function setPrimaryBankDetails($primary_bank_details)
    {
        $this->container['primary_bank_details'] = $primary_bank_details;

        return $this;
    }

    /**
     * Gets referral_given_name
     *
     * @return string
     */
    public function getReferralGivenName()
    {
        return $this->container['referral_given_name'];
    }

    /**
     * Sets referral_given_name
     *
     * @param string $referral_given_name Referral First Name.
     *
     * @return $this
     */
    public function setReferralGivenName($referral_given_name)
    {
        $this->container['referral_given_name'] = $referral_given_name;

        return $this;
    }

    /**
     * Gets referral_surname
     *
     * @return string
     */
    public function getReferralSurname()
    {
        return $this->container['referral_surname'];
    }

    /**
     * Sets referral_surname
     *
     * @param string $referral_surname Referral Surname/Last Name.
     *
     * @return $this
     */
    public function setReferralSurname($referral_surname)
    {
        $this->container['referral_surname'] = $referral_surname;

        return $this;
    }

    /**
     * Gets related_to_citi_employee_flag
     *
     * @return bool
     */
    public function getRelatedToCitiEmployeeFlag()
    {
        return $this->container['related_to_citi_employee_flag'];
    }

    /**
     * Sets related_to_citi_employee_flag
     *
     * @param bool $related_to_citi_employee_flag Self declaration if applicant has any relation with citi bank employee. Valid values: true and false
     *
     * @return $this
     */
    public function setRelatedToCitiEmployeeFlag($related_to_citi_employee_flag)
    {
        $this->container['related_to_citi_employee_flag'] = $related_to_citi_employee_flag;

        return $this;
    }

    /**
     * Gets related_citi_employee_name
     *
     * @return string
     */
    public function getRelatedCitiEmployeeName()
    {
        return $this->container['related_citi_employee_name'];
    }

    /**
     * Sets related_citi_employee_name
     *
     * @param string $related_citi_employee_name Name of the citi employee if applicant has any relation with citi bank employee.
     *
     * @return $this
     */
    public function setRelatedCitiEmployeeName($related_citi_employee_name)
    {
        $this->container['related_citi_employee_name'] = $related_citi_employee_name;

        return $this;
    }

    /**
     * Gets related_citi_employee_department
     *
     * @return string
     */
    public function getRelatedCitiEmployeeDepartment()
    {
        return $this->container['related_citi_employee_department'];
    }

    /**
     * Sets related_citi_employee_department
     *
     * @param string $related_citi_employee_department Department of citi employee if applicant has any relation with citi bank employee.
     *
     * @return $this
     */
    public function setRelatedCitiEmployeeDepartment($related_citi_employee_department)
    {
        $this->container['related_citi_employee_department'] = $related_citi_employee_department;

        return $this;
    }

    /**
     * Gets credit_card_usage_purpose
     *
     * @return string
     */
    public function getCreditCardUsagePurpose()
    {
        return $this->container['credit_card_usage_purpose'];
    }

    /**
     * Sets credit_card_usage_purpose
     *
     * @param string $credit_card_usage_purpose Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setCreditCardUsagePurpose($credit_card_usage_purpose)
    {
        $this->container['credit_card_usage_purpose'] = $credit_card_usage_purpose;

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