<?php
/**
 * GeoBatchDownloadResponse
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
 * GeoBatchDownloadResponse Class Doc Comment
 *
 * @category Class
 * @description Response body for Geo Batch Submit File API.
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */
class GeoBatchDownloadResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'GeoBatchDownloadResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'input_file' => 'string',
        'input_file_download' => 'string',
        'output_file' => 'string',
        'output_file_download' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPIFormats = [
        'input_file' => null,
        'input_file_download' => null,
        'output_file' => null,
        'output_file_download' => null
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
        'input_file' => 'InputFile',
        'input_file_download' => 'InputFileDownload',
        'output_file' => 'OutputFile',
        'output_file_download' => 'OutputFileDownload'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'input_file' => 'setInputFile',
        'input_file_download' => 'setInputFileDownload',
        'output_file' => 'setOutputFile',
        'output_file_download' => 'setOutputFileDownload'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'input_file' => 'getInputFile',
        'input_file_download' => 'getInputFileDownload',
        'output_file' => 'getOutputFile',
        'output_file_download' => 'getOutputFileDownload'
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
        $this->container['input_file'] = isset($data['input_file']) ? $data['input_file'] : null;
        $this->container['input_file_download'] = isset($data['input_file_download']) ? $data['input_file_download'] : null;
        $this->container['output_file'] = isset($data['output_file']) ? $data['output_file'] : null;
        $this->container['output_file_download'] = isset($data['output_file_download']) ? $data['output_file_download'] : null;
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
     * Gets input_file
     *
     * @return string|null
     */
    public function getInputFile()
    {
        return $this->container['input_file'];
    }

    /**
     * Sets input_file
     *
     * @param string|null $input_file input_file
     *
     * @return $this
     */
    public function setInputFile($input_file)
    {
        $this->container['input_file'] = $input_file;

        return $this;
    }

    /**
     * Gets input_file_download
     *
     * @return string|null
     */
    public function getInputFileDownload()
    {
        return $this->container['input_file_download'];
    }

    /**
     * Sets input_file_download
     *
     * @param string|null $input_file_download Input File Download.
     *
     * @return $this
     */
    public function setInputFileDownload($input_file_download)
    {
        $this->container['input_file_download'] = $input_file_download;

        return $this;
    }

    /**
     * Gets output_file
     *
     * @return string|null
     */
    public function getOutputFile()
    {
        return $this->container['output_file'];
    }

    /**
     * Sets output_file
     *
     * @param string|null $output_file output_file
     *
     * @return $this
     */
    public function setOutputFile($output_file)
    {
        $this->container['output_file'] = $output_file;

        return $this;
    }

    /**
     * Gets output_file_download
     *
     * @return string|null
     */
    public function getOutputFileDownload()
    {
        return $this->container['output_file_download'];
    }

    /**
     * Sets output_file_download
     *
     * @param string|null $output_file_download Output File Name.
     *
     * @return $this
     */
    public function setOutputFileDownload($output_file_download)
    {
        $this->container['output_file_download'] = $output_file_download;

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


