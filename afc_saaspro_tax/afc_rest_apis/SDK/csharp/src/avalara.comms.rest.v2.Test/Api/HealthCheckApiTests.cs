/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using avalara.comms.rest.v2.Client;
using avalara.comms.rest.v2.Api;

namespace avalara.comms.rest.v2.Test
{
    /// <summary>
    ///  Class for testing HealthCheckApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class HealthCheckApiTests
    {
        private HealthCheckApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HealthCheckApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HealthCheckApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' HealthCheckApi
            //Assert.IsInstanceOf(typeof(HealthCheckApi), instance);
        }

        
        /// <summary>
        /// Test ApiV2HealthCheckGet
        /// </summary>
        [Test]
        public void ApiV2HealthCheckGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ApiV2HealthCheckGet();
            
        }
        
    }

}
