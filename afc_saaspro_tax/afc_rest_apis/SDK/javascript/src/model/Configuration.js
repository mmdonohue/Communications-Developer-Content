/**
 * SaasPro
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
import TrafficStudyOverride from './TrafficStudyOverride';

/**
 * The Configuration model module.
 * @module model/Configuration
 * @version v2
 */
class Configuration {
    /**
     * Constructs a new <code>Configuration</code>.
     * Settings associated with a client profile configuration  Maybe associated with 0 to many profiles
     * @alias module:model/Configuration
     */
    constructor() { 
        
        Configuration.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>Configuration</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/Configuration} obj Optional instance to populate.
     * @return {module:model/Configuration} The populated <code>Configuration</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new Configuration();

            if (data.hasOwnProperty('TrafficStudyOverrides')) {
                obj['TrafficStudyOverrides'] = ApiClient.convertToType(data['TrafficStudyOverrides'], [TrafficStudyOverride]);
            }
            if (data.hasOwnProperty('ReturnNonBillable')) {
                obj['ReturnNonBillable'] = ApiClient.convertToType(data['ReturnNonBillable'], 'Boolean');
            }
            if (data.hasOwnProperty('TaxOnTaxAlgorithm')) {
                obj['TaxOnTaxAlgorithm'] = ApiClient.convertToType(data['TaxOnTaxAlgorithm'], 'Number');
            }
            if (data.hasOwnProperty('SelfTaxAlgorithm')) {
                obj['SelfTaxAlgorithm'] = ApiClient.convertToType(data['SelfTaxAlgorithm'], 'Number');
            }
        }
        return obj;
    }


}

/**
 * List of Traffic Study Overrides
 * @member {Array.<module:model/TrafficStudyOverride>} TrafficStudyOverrides
 */
Configuration.prototype['TrafficStudyOverrides'] = undefined;

/**
 * true : Return both non-billable and billable taxes in taxation response  false (default) : Return billable taxes only in taxation response  Default: false
 * @member {Boolean} ReturnNonBillable
 */
Configuration.prototype['ReturnNonBillable'] = undefined;

/**
 * Tax-on-tax algorithm to be used in tax calculations  0 : Single pass  1 (default) : IterateOnTaxAmount  2 : IterateOnTaxableMeasure
 * @member {Number} TaxOnTaxAlgorithm
 */
Configuration.prototype['TaxOnTaxAlgorithm'] = undefined;

/**
 * Self-tax algorithm to be used in tax calculations  0 (default) : Calculate tax on individual self-taxing taxes  1 : Calculate tax on aggregate of self-taxing taxes
 * @member {Number} SelfTaxAlgorithm
 */
Configuration.prototype['SelfTaxAlgorithm'] = undefined;






export default Configuration;

