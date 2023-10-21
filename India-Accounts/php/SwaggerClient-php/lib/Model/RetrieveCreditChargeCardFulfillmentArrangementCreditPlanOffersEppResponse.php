<?php
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse
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
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'customer_name' => 'string',
'product_code' => 'string',
'service_charge_amount' => 'string',
'card_id' => 'string',
'product_name' => 'string',
'display_card_number' => 'string',
'pending_transaction' => '\Swagger\Client\Model\PendingTransaction',
'statement' => '\Swagger\Client\Model\Statement',
'epp_offers' => '\Swagger\Client\Model\EppOffers[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'customer_name' => null,
'product_code' => null,
'service_charge_amount' => 'double',
'card_id' => null,
'product_name' => null,
'display_card_number' => null,
'pending_transaction' => null,
'statement' => null,
'epp_offers' => null    ];

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
        'customer_name' => 'customerName',
'product_code' => 'productCode',
'service_charge_amount' => 'serviceChargeAmount',
'card_id' => 'cardId',
'product_name' => 'productName',
'display_card_number' => 'displayCardNumber',
'pending_transaction' => 'pendingTransaction',
'statement' => 'statement',
'epp_offers' => 'eppOffers'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'customer_name' => 'setCustomerName',
'product_code' => 'setProductCode',
'service_charge_amount' => 'setServiceChargeAmount',
'card_id' => 'setCardId',
'product_name' => 'setProductName',
'display_card_number' => 'setDisplayCardNumber',
'pending_transaction' => 'setPendingTransaction',
'statement' => 'setStatement',
'epp_offers' => 'setEppOffers'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'customer_name' => 'getCustomerName',
'product_code' => 'getProductCode',
'service_charge_amount' => 'getServiceChargeAmount',
'card_id' => 'getCardId',
'product_name' => 'getProductName',
'display_card_number' => 'getDisplayCardNumber',
'pending_transaction' => 'getPendingTransaction',
'statement' => 'getStatement',
'epp_offers' => 'getEppOffers'    ];

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
        $this->container['customer_name'] = isset($data['customer_name']) ? $data['customer_name'] : null;
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['service_charge_amount'] = isset($data['service_charge_amount']) ? $data['service_charge_amount'] : null;
        $this->container['card_id'] = isset($data['card_id']) ? $data['card_id'] : null;
        $this->container['product_name'] = isset($data['product_name']) ? $data['product_name'] : null;
        $this->container['display_card_number'] = isset($data['display_card_number']) ? $data['display_card_number'] : null;
        $this->container['pending_transaction'] = isset($data['pending_transaction']) ? $data['pending_transaction'] : null;
        $this->container['statement'] = isset($data['statement']) ? $data['statement'] : null;
        $this->container['epp_offers'] = isset($data['epp_offers']) ? $data['epp_offers'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['customer_name'] === null) {
            $invalidProperties[] = "'customer_name' can't be null";
        }
        if ($this->container['product_code'] === null) {
            $invalidProperties[] = "'product_code' can't be null";
        }
        if ($this->container['product_name'] === null) {
            $invalidProperties[] = "'product_name' can't be null";
        }
        if ($this->container['display_card_number'] === null) {
            $invalidProperties[] = "'display_card_number' can't be null";
        }
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
     * Gets customer_name
     *
     * @return string
     */
    public function getCustomerName()
    {
        return $this->container['customer_name'];
    }

    /**
     * Sets customer_name
     *
     * @param string $customer_name his refers to the name of the customer
     *
     * @return $this
     */
    public function setCustomerName($customer_name)
    {
        $this->container['customer_name'] = $customer_name;

        return $this;
    }

    /**
     * Gets product_code
     *
     * @return string
     */
    public function getProductCode()
    {
        return $this->container['product_code'];
    }

    /**
     * Sets product_code
     *
     * @param string $product_code A unique code that identifies the product
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
    }

    /**
     * Gets service_charge_amount
     *
     * @return string
     */
    public function getServiceChargeAmount()
    {
        return $this->container['service_charge_amount'];
    }

    /**
     * Sets service_charge_amount
     *
     * @param string $service_charge_amount Booking Fees Amount
     *
     * @return $this
     */
    public function setServiceChargeAmount($service_charge_amount)
    {
        $this->container['service_charge_amount'] = $service_charge_amount;

        return $this;
    }

    /**
     * Gets card_id
     *
     * @return string
     */
    public function getCardId()
    {
        return $this->container['card_id'];
    }

    /**
     * Sets card_id
     *
     * @param string $card_id The customer card identifier in encrypted format
     *
     * @return $this
     */
    public function setCardId($card_id)
    {
        $this->container['card_id'] = $card_id;

        return $this;
    }

    /**
     * Gets product_name
     *
     * @return string
     */
    public function getProductName()
    {
        return $this->container['product_name'];
    }

    /**
     * Sets product_name
     *
     * @param string $product_name The name of the product
     *
     * @return $this
     */
    public function setProductName($product_name)
    {
        $this->container['product_name'] = $product_name;

        return $this;
    }

    /**
     * Gets display_card_number
     *
     * @return string
     */
    public function getDisplayCardNumber()
    {
        return $this->container['display_card_number'];
    }

    /**
     * Sets display_card_number
     *
     * @param string $display_card_number A masked Card number that can be displayed to the customer
     *
     * @return $this
     */
    public function setDisplayCardNumber($display_card_number)
    {
        $this->container['display_card_number'] = $display_card_number;

        return $this;
    }

    /**
     * Gets pending_transaction
     *
     * @return \Swagger\Client\Model\PendingTransaction
     */
    public function getPendingTransaction()
    {
        return $this->container['pending_transaction'];
    }

    /**
     * Sets pending_transaction
     *
     * @param \Swagger\Client\Model\PendingTransaction $pending_transaction pending_transaction
     *
     * @return $this
     */
    public function setPendingTransaction($pending_transaction)
    {
        $this->container['pending_transaction'] = $pending_transaction;

        return $this;
    }

    /**
     * Gets statement
     *
     * @return \Swagger\Client\Model\Statement
     */
    public function getStatement()
    {
        return $this->container['statement'];
    }

    /**
     * Sets statement
     *
     * @param \Swagger\Client\Model\Statement $statement statement
     *
     * @return $this
     */
    public function setStatement($statement)
    {
        $this->container['statement'] = $statement;

        return $this;
    }

    /**
     * Gets epp_offers
     *
     * @return \Swagger\Client\Model\EppOffers[]
     */
    public function getEppOffers()
    {
        return $this->container['epp_offers'];
    }

    /**
     * Sets epp_offers
     *
     * @param \Swagger\Client\Model\EppOffers[] $epp_offers epp_offers
     *
     * @return $this
     */
    public function setEppOffers($epp_offers)
    {
        $this->container['epp_offers'] = $epp_offers;

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
