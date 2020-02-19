/* 
 * SaasPro
 *
 * APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.
 *
 * The version of the OpenAPI document: v2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

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
    ///  Class for testing KeyValuePair
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KeyValuePairTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KeyValuePair
        //private KeyValuePair instance;

        public KeyValuePairTests()
        {
            // TODO uncomment below to create an instance of KeyValuePair
            //instance = new KeyValuePair();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KeyValuePair
        /// </summary>
        [Fact]
        public void KeyValuePairInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" KeyValuePair
            //Assert.IsInstanceOfType<KeyValuePair> (instance, "variable 'instance' is a KeyValuePair");
        }


        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }
        /// <summary>
        /// Test the property 'Val'
        /// </summary>
        [Fact]
        public void ValTest()
        {
            // TODO unit test for the property 'Val'
        }

    }

}
