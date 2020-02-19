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

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.SaasPro);
  }
}(this, function(expect, SaasPro) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new SaasPro.TrafficStudyOverride();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('TrafficStudyOverride', function() {
    it('should create an instance of TrafficStudyOverride', function() {
      // uncomment below and update the code to test TrafficStudyOverride
      //var instane = new SaasPro.TrafficStudyOverride();
      //expect(instance).to.be.a(SaasPro.TrafficStudyOverride);
    });

    it('should have the property trafficStudyType (base name: "TrafficStudyType")', function() {
      // uncomment below and update the code to test the property trafficStudyType
      //var instane = new SaasPro.TrafficStudyOverride();
      //expect(instance).to.be();
    });

    it('should have the property safeHarborFedPcnt (base name: "SafeHarborFedPcnt")', function() {
      // uncomment below and update the code to test the property safeHarborFedPcnt
      //var instane = new SaasPro.TrafficStudyOverride();
      //expect(instance).to.be();
    });

    it('should have the property trafficStudyFedPcnt (base name: "TrafficStudyFedPcnt")', function() {
      // uncomment below and update the code to test the property trafficStudyFedPcnt
      //var instane = new SaasPro.TrafficStudyOverride();
      //expect(instance).to.be();
    });

  });

}));
