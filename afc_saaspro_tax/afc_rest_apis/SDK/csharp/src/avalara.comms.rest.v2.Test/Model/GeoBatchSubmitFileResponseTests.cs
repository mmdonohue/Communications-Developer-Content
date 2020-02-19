/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using avalara.comms.rest.v2.Api;
using avalara.comms.rest.v2.Model;
using avalara.comms.rest.v2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace avalara.comms.rest.v2.Test
{
    /// <summary>
    ///  Class for testing GeoBatchSubmitFileResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GeoBatchSubmitFileResponseTests
    {
        // TODO uncomment below to declare an instance variable for GeoBatchSubmitFileResponse
        //private GeoBatchSubmitFileResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GeoBatchSubmitFileResponse
            //instance = new GeoBatchSubmitFileResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeoBatchSubmitFileResponse
        /// </summary>
        [Test]
        public void GeoBatchSubmitFileResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" GeoBatchSubmitFileResponse
            //Assert.IsInstanceOf(typeof(GeoBatchSubmitFileResponse), instance);
        }


        /// <summary>
        /// Test the property 'ProcessId'
        /// </summary>
        [Test]
        public void ProcessIdTest()
        {
            // TODO unit test for the property 'ProcessId'
        }
        /// <summary>
        /// Test the property 'Err'
        /// </summary>
        [Test]
        public void ErrTest()
        {
            // TODO unit test for the property 'Err'
        }

    }

}
