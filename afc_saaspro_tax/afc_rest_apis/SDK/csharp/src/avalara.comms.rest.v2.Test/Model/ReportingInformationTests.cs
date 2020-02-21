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
    ///  Class for testing ReportingInformation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReportingInformationTests
    {
        // TODO uncomment below to declare an instance variable for ReportingInformation
        //private ReportingInformation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ReportingInformation
            //instance = new ReportingInformation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportingInformation
        /// </summary>
        [Test]
        public void ReportingInformationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" ReportingInformation
            //Assert.IsInstanceOf(typeof(ReportingInformation), instance);
        }


        /// <summary>
        /// Test the property 'Acct'
        /// </summary>
        [Test]
        public void AcctTest()
        {
            // TODO unit test for the property 'Acct'
        }
        /// <summary>
        /// Test the property 'Custref'
        /// </summary>
        [Test]
        public void CustrefTest()
        {
            // TODO unit test for the property 'Custref'
        }
        /// <summary>
        /// Test the property 'Invn'
        /// </summary>
        [Test]
        public void InvnTest()
        {
            // TODO unit test for the property 'Invn'
        }
        /// <summary>
        /// Test the property 'Bcyc'
        /// </summary>
        [Test]
        public void BcycTest()
        {
            // TODO unit test for the property 'Bcyc'
        }
        /// <summary>
        /// Test the property 'Ccycd'
        /// </summary>
        [Test]
        public void CcycdTest()
        {
            // TODO unit test for the property 'Ccycd'
        }
        /// <summary>
        /// Test the property 'Ccydesc'
        /// </summary>
        [Test]
        public void CcydescTest()
        {
            // TODO unit test for the property 'Ccydesc'
        }

    }

}