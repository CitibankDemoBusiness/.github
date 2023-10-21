/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    ///  Class for testing AdhocSepaTransfersPreprocessResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AdhocSepaTransfersPreprocessResponseTests
    {
        // TODO uncomment below to declare an instance variable for AdhocSepaTransfersPreprocessResponse
        //private AdhocSepaTransfersPreprocessResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AdhocSepaTransfersPreprocessResponse
            //instance = new AdhocSepaTransfersPreprocessResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AdhocSepaTransfersPreprocessResponse
        /// </summary>
        [Test]
        public void AdhocSepaTransfersPreprocessResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AdhocSepaTransfersPreprocessResponse
            //Assert.IsInstanceOfType<AdhocSepaTransfersPreprocessResponse> (instance, "variable 'instance' is a AdhocSepaTransfersPreprocessResponse");
        }


        /// <summary>
        /// Test the property 'ControlFlowId'
        /// </summary>
        [Test]
        public void ControlFlowIdTest()
        {
            // TODO unit test for the property 'ControlFlowId'
        }
        /// <summary>
        /// Test the property 'DebitDetails'
        /// </summary>
        [Test]
        public void DebitDetailsTest()
        {
            // TODO unit test for the property 'DebitDetails'
        }
        /// <summary>
        /// Test the property 'CreditDetails'
        /// </summary>
        [Test]
        public void CreditDetailsTest()
        {
            // TODO unit test for the property 'CreditDetails'
        }
        /// <summary>
        /// Test the property 'ForeignExchangeRate'
        /// </summary>
        [Test]
        public void ForeignExchangeRateTest()
        {
            // TODO unit test for the property 'ForeignExchangeRate'
        }
        /// <summary>
        /// Test the property 'TransactionFee'
        /// </summary>
        [Test]
        public void TransactionFeeTest()
        {
            // TODO unit test for the property 'TransactionFee'
        }
        /// <summary>
        /// Test the property 'FeeCurrencyCode'
        /// </summary>
        [Test]
        public void FeeCurrencyCodeTest()
        {
            // TODO unit test for the property 'FeeCurrencyCode'
        }

    }

}
