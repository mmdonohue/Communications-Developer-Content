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
    instance = new SaasPro.GeoBatchDownloadResponse();
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

  describe('GeoBatchDownloadResponse', function() {
    it('should create an instance of GeoBatchDownloadResponse', function() {
      // uncomment below and update the code to test GeoBatchDownloadResponse
      //var instane = new SaasPro.GeoBatchDownloadResponse();
      //expect(instance).to.be.a(SaasPro.GeoBatchDownloadResponse);
    });

    it('should have the property inputFile (base name: "InputFile")', function() {
      // uncomment below and update the code to test the property inputFile
      //var instane = new SaasPro.GeoBatchDownloadResponse();
      //expect(instance).to.be();
    });

    it('should have the property inputFileDownload (base name: "InputFileDownload")', function() {
      // uncomment below and update the code to test the property inputFileDownload
      //var instane = new SaasPro.GeoBatchDownloadResponse();
      //expect(instance).to.be();
    });

    it('should have the property outputFile (base name: "OutputFile")', function() {
      // uncomment below and update the code to test the property outputFile
      //var instane = new SaasPro.GeoBatchDownloadResponse();
      //expect(instance).to.be();
    });

    it('should have the property outputFileDownload (base name: "OutputFileDownload")', function() {
      // uncomment below and update the code to test the property outputFileDownload
      //var instane = new SaasPro.GeoBatchDownloadResponse();
      //expect(instance).to.be();
    });

  });

}));
