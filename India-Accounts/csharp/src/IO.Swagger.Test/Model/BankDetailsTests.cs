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
    ///  Class for testing BankDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BankDetailsTests
    {
        // TODO uncomment below to declare an instance variable for BankDetails
        //private BankDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BankDetails
            //instance = new BankDetails();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BankDetails
        /// </summary>
        [Test]
        public void BankDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BankDetails
            //Assert.IsInstanceOfType<BankDetails> (instance, "variable 'instance' is a BankDetails");
        }


        /// <summary>
        /// Test the property 'BankCode'
        /// </summary>
        [Test]
        public void BankCodeTest()
        {
            // TODO unit test for the property 'BankCode'
        }
        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [Test]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }
        /// <summary>
        /// Test the property 'BranchCode'
        /// </summary>
        [Test]
        public void BranchCodeTest()
        {
            // TODO unit test for the property 'BranchCode'
        }
        /// <summary>
        /// Test the property 'BankName'
        /// </summary>
        [Test]
        public void BankNameTest()
        {
            // TODO unit test for the property 'BankName'
        }
        /// <summary>
        /// Test the property 'PayeeName'
        /// </summary>
        [Test]
        public void PayeeNameTest()
        {
            // TODO unit test for the property 'PayeeName'
        }
        /// <summary>
        /// Test the property 'Remarks'
        /// </summary>
        [Test]
        public void RemarksTest()
        {
            // TODO unit test for the property 'Remarks'
        }

    }

}
