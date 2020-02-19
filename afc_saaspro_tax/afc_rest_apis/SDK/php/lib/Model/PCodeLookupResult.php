<?php
/**
 * PCodeLookupResult
 *
 * PHP version 5
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 4.3.0-SNAPSHOT
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * PCodeLookupResult Class Doc Comment
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class PCodeLookupResult implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'PCodeLookupResult';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'location_data' => '\OpenAPI\Client\Model\LocationItem[]',
        'match_count' => 'int',
        'input_match_type' => 'string',
        'match_type_applied' => 'string',
        'results_limit' => 'int'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPIFormats = [
        'location_data' => null,
        'match_count' => 'int32',
        'input_match_type' => null,
        'match_type_applied' => null,
        'results_limit' => 'int32'
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'location_data' => 'LocationData',
        'match_count' => 'MatchCount',
        'input_match_type' => 'InputMatchType',
        'match_type_applied' => 'MatchTypeApplied',
        'results_limit' => 'ResultsLimit'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'location_data' => 'setLocationData',
        'match_count' => 'setMatchCount',
        'input_match_type' => 'setInputMatchType',
        'match_type_applied' => 'setMatchTypeApplied',
        'results_limit' => 'setResultsLimit'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'location_data' => 'getLocationData',
        'match_count' => 'getMatchCount',
        'input_match_type' => 'getInputMatchType',
        'match_type_applied' => 'getMatchTypeApplied',
        'results_limit' => 'getResultsLimit'
    ];

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
        return self::$openAPIModelName;
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
        $this->container['location_data'] = isset($data['location_data']) ? $data['location_data'] : null;
        $this->container['match_count'] = isset($data['match_count']) ? $data['match_count'] : null;
        $this->container['input_match_type'] = isset($data['input_match_type']) ? $data['input_match_type'] : null;
        $this->container['match_type_applied'] = isset($data['match_type_applied']) ? $data['match_type_applied'] : null;
        $this->container['results_limit'] = isset($data['results_limit']) ? $data['results_limit'] : null;
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
     * Gets location_data
     *
     * @return \OpenAPI\Client\Model\LocationItem[]|null
     */
    public function getLocationData()
    {
        return $this->container['location_data'];
    }

    /**
     * Sets location_data
     *
     * @param \OpenAPI\Client\Model\LocationItem[]|null $location_data location_data
     *
     * @return $this
     */
    public function setLocationData($location_data)
    {
        $this->container['location_data'] = $location_data;

        return $this;
    }

    /**
     * Gets match_count
     *
     * @return int|null
     */
    public function getMatchCount()
    {
        return $this->container['match_count'];
    }

    /**
     * Sets match_count
     *
     * @param int|null $match_count match_count
     *
     * @return $this
     */
    public function setMatchCount($match_count)
    {
        $this->container['match_count'] = $match_count;

        return $this;
    }

    /**
     * Gets input_match_type
     *
     * @return string|null
     */
    public function getInputMatchType()
    {
        return $this->container['input_match_type'];
    }

    /**
     * Sets input_match_type
     *
     * @param string|null $input_match_type input_match_type
     *
     * @return $this
     */
    public function setInputMatchType($input_match_type)
    {
        $this->container['input_match_type'] = $input_match_type;

        return $this;
    }

    /**
     * Gets match_type_applied
     *
     * @return string|null
     */
    public function getMatchTypeApplied()
    {
        return $this->container['match_type_applied'];
    }

    /**
     * Sets match_type_applied
     *
     * @param string|null $match_type_applied match_type_applied
     *
     * @return $this
     */
    public function setMatchTypeApplied($match_type_applied)
    {
        $this->container['match_type_applied'] = $match_type_applied;

        return $this;
    }

    /**
     * Gets results_limit
     *
     * @return int|null
     */
    public function getResultsLimit()
    {
        return $this->container['results_limit'];
    }

    /**
     * Sets results_limit
     *
     * @param int|null $results_limit results_limit
     *
     * @return $this
     */
    public function setResultsLimit($results_limit)
    {
        $this->container['results_limit'] = $results_limit;

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
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


