/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing LoanBookingConfirmationRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanBookingConfirmationRequestTests
    {
        // TODO uncomment below to declare an instance variable for LoanBookingConfirmationRequest
        //private LoanBookingConfirmationRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanBookingConfirmationRequest
            //instance = new LoanBookingConfirmationRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanBookingConfirmationRequest
        /// </summary>
        [Test]
        public void LoanBookingConfirmationRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanBookingConfirmationRequest
            //Assert.IsInstanceOfType<LoanBookingConfirmationRequest> (instance, "variable 'instance' is a LoanBookingConfirmationRequest");
        }


        /// <summary>
        /// Test the property 'ControlFlowId'
        /// </summary>
        [Test]
        public void ControlFlowIdTest()
        {
            // TODO unit test for the property 'ControlFlowId'
        }

    }

}
