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
    ///  Class for testing BillPaymentPayeeSourceAccountCombinations
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BillPaymentPayeeSourceAccountCombinationsTests
    {
        // TODO uncomment below to declare an instance variable for BillPaymentPayeeSourceAccountCombinations
        //private BillPaymentPayeeSourceAccountCombinations instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BillPaymentPayeeSourceAccountCombinations
            //instance = new BillPaymentPayeeSourceAccountCombinations();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillPaymentPayeeSourceAccountCombinations
        /// </summary>
        [Test]
        public void BillPaymentPayeeSourceAccountCombinationsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BillPaymentPayeeSourceAccountCombinations
            //Assert.IsInstanceOfType<BillPaymentPayeeSourceAccountCombinations> (instance, "variable 'instance' is a BillPaymentPayeeSourceAccountCombinations");
        }


        /// <summary>
        /// Test the property 'PayeeId'
        /// </summary>
        [Test]
        public void PayeeIdTest()
        {
            // TODO unit test for the property 'PayeeId'
        }
        /// <summary>
        /// Test the property 'DisplayPayeeAccountNumber'
        /// </summary>
        [Test]
        public void DisplayPayeeAccountNumberTest()
        {
            // TODO unit test for the property 'DisplayPayeeAccountNumber'
        }
        /// <summary>
        /// Test the property 'PayeeAccountCurrencyCode'
        /// </summary>
        [Test]
        public void PayeeAccountCurrencyCodeTest()
        {
            // TODO unit test for the property 'PayeeAccountCurrencyCode'
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
        /// Test the property 'PayeeNickName'
        /// </summary>
        [Test]
        public void PayeeNickNameTest()
        {
            // TODO unit test for the property 'PayeeNickName'
        }
        /// <summary>
        /// Test the property 'MerchantNumber'
        /// </summary>
        [Test]
        public void MerchantNumberTest()
        {
            // TODO unit test for the property 'MerchantNumber'
        }
        /// <summary>
        /// Test the property 'BillTypeCode'
        /// </summary>
        [Test]
        public void BillTypeCodeTest()
        {
            // TODO unit test for the property 'BillTypeCode'
        }
        /// <summary>
        /// Test the property 'SourceAccountIds'
        /// </summary>
        [Test]
        public void SourceAccountIdsTest()
        {
            // TODO unit test for the property 'SourceAccountIds'
        }

    }

}
