<?php
/**
 * Security
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * Security Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class Security implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'Security';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'security_name' => 'string',
'stock_code' => 'string',
'stock_market_code' => 'string',
'market_value_amount' => 'double',
'investment_amount' => 'double',
'currency_code' => 'string',
'average_unit_cost' => 'double',
'maturity_date' => '\DateTime',
'available_units' => 'double',
'settled_units' => 'double',
'assigned_units' => 'double',
'confirmed_units' => 'double',
'pending_units' => 'double',
'block_units' => 'double',
'unrealized_gains' => 'double',
'unrealized_percentage_gain' => 'double',
'latest_price' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'security_name' => null,
'stock_code' => null,
'stock_market_code' => null,
'market_value_amount' => 'double',
'investment_amount' => 'double',
'currency_code' => null,
'average_unit_cost' => 'double',
'maturity_date' => 'date',
'available_units' => 'double',
'settled_units' => 'double',
'assigned_units' => 'double',
'confirmed_units' => 'double',
'pending_units' => 'double',
'block_units' => 'double',
'unrealized_gains' => 'double',
'unrealized_percentage_gain' => 'double',
'latest_price' => 'double'    ];

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
        'security_name' => 'securityName',
'stock_code' => 'stockCode',
'stock_market_code' => 'stockMarketCode',
'market_value_amount' => 'marketValueAmount',
'investment_amount' => 'investmentAmount',
'currency_code' => 'currencyCode',
'average_unit_cost' => 'averageUnitCost',
'maturity_date' => 'maturityDate',
'available_units' => 'availableUnits',
'settled_units' => 'settledUnits',
'assigned_units' => 'assignedUnits',
'confirmed_units' => 'confirmedUnits',
'pending_units' => 'pendingUnits',
'block_units' => 'blockUnits',
'unrealized_gains' => 'unrealizedGains',
'unrealized_percentage_gain' => 'unrealizedPercentageGain',
'latest_price' => 'latestPrice'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'security_name' => 'setSecurityName',
'stock_code' => 'setStockCode',
'stock_market_code' => 'setStockMarketCode',
'market_value_amount' => 'setMarketValueAmount',
'investment_amount' => 'setInvestmentAmount',
'currency_code' => 'setCurrencyCode',
'average_unit_cost' => 'setAverageUnitCost',
'maturity_date' => 'setMaturityDate',
'available_units' => 'setAvailableUnits',
'settled_units' => 'setSettledUnits',
'assigned_units' => 'setAssignedUnits',
'confirmed_units' => 'setConfirmedUnits',
'pending_units' => 'setPendingUnits',
'block_units' => 'setBlockUnits',
'unrealized_gains' => 'setUnrealizedGains',
'unrealized_percentage_gain' => 'setUnrealizedPercentageGain',
'latest_price' => 'setLatestPrice'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'security_name' => 'getSecurityName',
'stock_code' => 'getStockCode',
'stock_market_code' => 'getStockMarketCode',
'market_value_amount' => 'getMarketValueAmount',
'investment_amount' => 'getInvestmentAmount',
'currency_code' => 'getCurrencyCode',
'average_unit_cost' => 'getAverageUnitCost',
'maturity_date' => 'getMaturityDate',
'available_units' => 'getAvailableUnits',
'settled_units' => 'getSettledUnits',
'assigned_units' => 'getAssignedUnits',
'confirmed_units' => 'getConfirmedUnits',
'pending_units' => 'getPendingUnits',
'block_units' => 'getBlockUnits',
'unrealized_gains' => 'getUnrealizedGains',
'unrealized_percentage_gain' => 'getUnrealizedPercentageGain',
'latest_price' => 'getLatestPrice'    ];

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
        $this->container['security_name'] = isset($data['security_name']) ? $data['security_name'] : null;
        $this->container['stock_code'] = isset($data['stock_code']) ? $data['stock_code'] : null;
        $this->container['stock_market_code'] = isset($data['stock_market_code']) ? $data['stock_market_code'] : null;
        $this->container['market_value_amount'] = isset($data['market_value_amount']) ? $data['market_value_amount'] : null;
        $this->container['investment_amount'] = isset($data['investment_amount']) ? $data['investment_amount'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['average_unit_cost'] = isset($data['average_unit_cost']) ? $data['average_unit_cost'] : null;
        $this->container['maturity_date'] = isset($data['maturity_date']) ? $data['maturity_date'] : null;
        $this->container['available_units'] = isset($data['available_units']) ? $data['available_units'] : null;
        $this->container['settled_units'] = isset($data['settled_units']) ? $data['settled_units'] : null;
        $this->container['assigned_units'] = isset($data['assigned_units']) ? $data['assigned_units'] : null;
        $this->container['confirmed_units'] = isset($data['confirmed_units']) ? $data['confirmed_units'] : null;
        $this->container['pending_units'] = isset($data['pending_units']) ? $data['pending_units'] : null;
        $this->container['block_units'] = isset($data['block_units']) ? $data['block_units'] : null;
        $this->container['unrealized_gains'] = isset($data['unrealized_gains']) ? $data['unrealized_gains'] : null;
        $this->container['unrealized_percentage_gain'] = isset($data['unrealized_percentage_gain']) ? $data['unrealized_percentage_gain'] : null;
        $this->container['latest_price'] = isset($data['latest_price']) ? $data['latest_price'] : null;
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
     * Gets security_name
     *
     * @return string
     */
    public function getSecurityName()
    {
        return $this->container['security_name'];
    }

    /**
     * Sets security_name
     *
     * @param string $security_name The security name
     *
     * @return $this
     */
    public function setSecurityName($security_name)
    {
        $this->container['security_name'] = $security_name;

        return $this;
    }

    /**
     * Gets stock_code
     *
     * @return string
     */
    public function getStockCode()
    {
        return $this->container['stock_code'];
    }

    /**
     * Sets stock_code
     *
     * @param string $stock_code Unique code associated with security.
     *
     * @return $this
     */
    public function setStockCode($stock_code)
    {
        $this->container['stock_code'] = $stock_code;

        return $this;
    }

    /**
     * Gets stock_market_code
     *
     * @return string
     */
    public function getStockMarketCode()
    {
        return $this->container['stock_market_code'];
    }

    /**
     * Sets stock_market_code
     *
     * @param string $stock_market_code Trading market code for securities.
     *
     * @return $this
     */
    public function setStockMarketCode($stock_market_code)
    {
        $this->container['stock_market_code'] = $stock_market_code;

        return $this;
    }

    /**
     * Gets market_value_amount
     *
     * @return double
     */
    public function getMarketValueAmount()
    {
        return $this->container['market_value_amount'];
    }

    /**
     * Sets market_value_amount
     *
     * @param double $market_value_amount The current market worth of investment
     *
     * @return $this
     */
    public function setMarketValueAmount($market_value_amount)
    {
        $this->container['market_value_amount'] = $market_value_amount;

        return $this;
    }

    /**
     * Gets investment_amount
     *
     * @return double
     */
    public function getInvestmentAmount()
    {
        return $this->container['investment_amount'];
    }

    /**
     * Sets investment_amount
     *
     * @param double $investment_amount The investment amount
     *
     * @return $this
     */
    public function setInvestmentAmount($investment_amount)
    {
        $this->container['investment_amount'] = $investment_amount;

        return $this;
    }

    /**
     * Gets currency_code
     *
     * @return string
     */
    public function getCurrencyCode()
    {
        return $this->container['currency_code'];
    }

    /**
     * Sets currency_code
     *
     * @param string $currency_code The currency code of the account in ISO 4217 format
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

        return $this;
    }

    /**
     * Gets average_unit_cost
     *
     * @return double
     */
    public function getAverageUnitCost()
    {
        return $this->container['average_unit_cost'];
    }

    /**
     * Sets average_unit_cost
     *
     * @param double $average_unit_cost Average unit cost
     *
     * @return $this
     */
    public function setAverageUnitCost($average_unit_cost)
    {
        $this->container['average_unit_cost'] = $average_unit_cost;

        return $this;
    }

    /**
     * Gets maturity_date
     *
     * @return \DateTime
     */
    public function getMaturityDate()
    {
        return $this->container['maturity_date'];
    }

    /**
     * Sets maturity_date
     *
     * @param \DateTime $maturity_date The maturity date in ISO 8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setMaturityDate($maturity_date)
    {
        $this->container['maturity_date'] = $maturity_date;

        return $this;
    }

    /**
     * Gets available_units
     *
     * @return double
     */
    public function getAvailableUnits()
    {
        return $this->container['available_units'];
    }

    /**
     * Sets available_units
     *
     * @param double $available_units The available units
     *
     * @return $this
     */
    public function setAvailableUnits($available_units)
    {
        $this->container['available_units'] = $available_units;

        return $this;
    }

    /**
     * Gets settled_units
     *
     * @return double
     */
    public function getSettledUnits()
    {
        return $this->container['settled_units'];
    }

    /**
     * Sets settled_units
     *
     * @param double $settled_units The settled units
     *
     * @return $this
     */
    public function setSettledUnits($settled_units)
    {
        $this->container['settled_units'] = $settled_units;

        return $this;
    }

    /**
     * Gets assigned_units
     *
     * @return double
     */
    public function getAssignedUnits()
    {
        return $this->container['assigned_units'];
    }

    /**
     * Sets assigned_units
     *
     * @param double $assigned_units The assigned units
     *
     * @return $this
     */
    public function setAssignedUnits($assigned_units)
    {
        $this->container['assigned_units'] = $assigned_units;

        return $this;
    }

    /**
     * Gets confirmed_units
     *
     * @return double
     */
    public function getConfirmedUnits()
    {
        return $this->container['confirmed_units'];
    }

    /**
     * Sets confirmed_units
     *
     * @param double $confirmed_units The confirmed units
     *
     * @return $this
     */
    public function setConfirmedUnits($confirmed_units)
    {
        $this->container['confirmed_units'] = $confirmed_units;

        return $this;
    }

    /**
     * Gets pending_units
     *
     * @return double
     */
    public function getPendingUnits()
    {
        return $this->container['pending_units'];
    }

    /**
     * Sets pending_units
     *
     * @param double $pending_units The pending units
     *
     * @return $this
     */
    public function setPendingUnits($pending_units)
    {
        $this->container['pending_units'] = $pending_units;

        return $this;
    }

    /**
     * Gets block_units
     *
     * @return double
     */
    public function getBlockUnits()
    {
        return $this->container['block_units'];
    }

    /**
     * Sets block_units
     *
     * @param double $block_units The blocked units
     *
     * @return $this
     */
    public function setBlockUnits($block_units)
    {
        $this->container['block_units'] = $block_units;

        return $this;
    }

    /**
     * Gets unrealized_gains
     *
     * @return double
     */
    public function getUnrealizedGains()
    {
        return $this->container['unrealized_gains'];
    }

    /**
     * Sets unrealized_gains
     *
     * @param double $unrealized_gains The unrealized gain
     *
     * @return $this
     */
    public function setUnrealizedGains($unrealized_gains)
    {
        $this->container['unrealized_gains'] = $unrealized_gains;

        return $this;
    }

    /**
     * Gets unrealized_percentage_gain
     *
     * @return double
     */
    public function getUnrealizedPercentageGain()
    {
        return $this->container['unrealized_percentage_gain'];
    }

    /**
     * Sets unrealized_percentage_gain
     *
     * @param double $unrealized_percentage_gain The unrealized gain in percentage
     *
     * @return $this
     */
    public function setUnrealizedPercentageGain($unrealized_percentage_gain)
    {
        $this->container['unrealized_percentage_gain'] = $unrealized_percentage_gain;

        return $this;
    }

    /**
     * Gets latest_price
     *
     * @return double
     */
    public function getLatestPrice()
    {
        return $this->container['latest_price'];
    }

    /**
     * Sets latest_price
     *
     * @param double $latest_price The latest price
     *
     * @return $this
     */
    public function setLatestPrice($latest_price)
    {
        $this->container['latest_price'] = $latest_price;

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