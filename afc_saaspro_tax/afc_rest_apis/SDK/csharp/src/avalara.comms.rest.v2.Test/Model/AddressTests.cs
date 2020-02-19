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
    ///  Class for testing Address
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AddressTests
    {
        // TODO uncomment below to declare an instance variable for Address
        //private Address instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Address
            //instance = new Address();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Address
        /// </summary>
        [Test]
        public void AddressInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Address
            //Assert.IsInstanceOf(typeof(Address), instance);
        }


        /// <summary>
        /// Test the property 'Addr'
        /// </summary>
        [Test]
        public void AddrTest()
        {
            // TODO unit test for the property 'Addr'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'St'
        /// </summary>
        [Test]
        public void StTest()
        {
            // TODO unit test for the property 'St'
        }
        /// <summary>
        /// Test the property 'Zip'
        /// </summary>
        [Test]
        public void ZipTest()
        {
            // TODO unit test for the property 'Zip'
        }

    }

}
