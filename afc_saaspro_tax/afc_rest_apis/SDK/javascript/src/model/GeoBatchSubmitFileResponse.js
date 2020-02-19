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
import Error from './Error';

/**
 * The GeoBatchSubmitFileResponse model module.
 * @module model/GeoBatchSubmitFileResponse
 * @version v2
 */
class GeoBatchSubmitFileResponse {
    /**
     * Constructs a new <code>GeoBatchSubmitFileResponse</code>.
     * Response body for Geo Batch Submit File API.
     * @alias module:model/GeoBatchSubmitFileResponse
     */
    constructor() { 
        
        GeoBatchSubmitFileResponse.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>GeoBatchSubmitFileResponse</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/GeoBatchSubmitFileResponse} obj Optional instance to populate.
     * @return {module:model/GeoBatchSubmitFileResponse} The populated <code>GeoBatchSubmitFileResponse</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new GeoBatchSubmitFileResponse();

            if (data.hasOwnProperty('ProcessId')) {
                obj['ProcessId'] = ApiClient.convertToType(data['ProcessId'], 'Number');
            }
            if (data.hasOwnProperty('err')) {
                obj['err'] = ApiClient.convertToType(data['err'], [Error]);
            }
        }
        return obj;
    }


}

/**
 * Process Id for File uploaded
 * @member {Number} ProcessId
 */
GeoBatchSubmitFileResponse.prototype['ProcessId'] = undefined;

/**
 * @member {Array.<module:model/Error>} err
 */
GeoBatchSubmitFileResponse.prototype['err'] = undefined;






export default GeoBatchSubmitFileResponse;

