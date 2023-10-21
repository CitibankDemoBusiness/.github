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
    ///  Class for testing StatementsResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StatementsResponseTests
    {
        // TODO uncomment below to declare an instance variable for StatementsResponse
        //private StatementsResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of StatementsResponse
            //instance = new StatementsResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatementsResponse
        /// </summary>
        [Test]
        public void StatementsResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StatementsResponse
            //Assert.IsInstanceOfType<StatementsResponse> (instance, "variable 'instance' is a StatementsResponse");
        }


        /// <summary>
        /// Test the property 'CreditCardStatement'
        /// </summary>
        [Test]
        public void CreditCardStatementTest()
        {
            // TODO unit test for the property 'CreditCardStatement'
        }

    }

}
