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
    ///  Class for testing LoanSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LoanSummaryTests
    {
        // TODO uncomment below to declare an instance variable for LoanSummary
        //private LoanSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LoanSummary
            //instance = new LoanSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LoanSummary
        /// </summary>
        [Test]
        public void LoanSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LoanSummary
            //Assert.IsInstanceOfType<LoanSummary> (instance, "variable 'instance' is a LoanSummary");
        }


        /// <summary>
        /// Test the property 'LoanAmount'
        /// </summary>
        [Test]
        public void LoanAmountTest()
        {
            // TODO unit test for the property 'LoanAmount'
        }
        /// <summary>
        /// Test the property 'LoanTenure'
        /// </summary>
        [Test]
        public void LoanTenureTest()
        {
            // TODO unit test for the property 'LoanTenure'
        }
        /// <summary>
        /// Test the property 'PromotionId'
        /// </summary>
        [Test]
        public void PromotionIdTest()
        {
            // TODO unit test for the property 'PromotionId'
        }
        /// <summary>
        /// Test the property 'InterestRate'
        /// </summary>
        [Test]
        public void InterestRateTest()
        {
            // TODO unit test for the property 'InterestRate'
        }
        /// <summary>
        /// Test the property 'InterestRateEffectivityDate'
        /// </summary>
        [Test]
        public void InterestRateEffectivityDateTest()
        {
            // TODO unit test for the property 'InterestRateEffectivityDate'
        }
        /// <summary>
        /// Test the property 'TotalInterestAmount'
        /// </summary>
        [Test]
        public void TotalInterestAmountTest()
        {
            // TODO unit test for the property 'TotalInterestAmount'
        }
        /// <summary>
        /// Test the property 'TotalLoanAmount'
        /// </summary>
        [Test]
        public void TotalLoanAmountTest()
        {
            // TODO unit test for the property 'TotalLoanAmount'
        }
        /// <summary>
        /// Test the property 'LoanRemainingTermNumber'
        /// </summary>
        [Test]
        public void LoanRemainingTermNumberTest()
        {
            // TODO unit test for the property 'LoanRemainingTermNumber'
        }

    }

}