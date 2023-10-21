# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ApplicationInquiryRequestedProductDecision(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'product_code': 'str',
        'organisation_name': 'str',
        'source_code': 'str',
        'logo': 'str',
        'credit_decision': 'str',
        'credit_specific_recommendations': 'list[ApplicationInquiryCreditSpecificRecommendations]',
        'loan_specific_recommendations': 'list[ApplicationInquiryLoanSpecificRecommendations]',
        'required_documents': 'list[ApplicationInquiryRequiredDocuments]'
    }

    attribute_map = {
        'product_code': 'productCode',
        'organisation_name': 'organisationName',
        'source_code': 'sourceCode',
        'logo': 'logo',
        'credit_decision': 'creditDecision',
        'credit_specific_recommendations': 'creditSpecificRecommendations',
        'loan_specific_recommendations': 'loanSpecificRecommendations',
        'required_documents': 'requiredDocuments'
    }

    def __init__(self, product_code=None, organisation_name=None, source_code=None, logo=None, credit_decision=None, credit_specific_recommendations=None, loan_specific_recommendations=None, required_documents=None):  # noqa: E501
        """ApplicationInquiryRequestedProductDecision - a model defined in Swagger"""  # noqa: E501
        self._product_code = None
        self._organisation_name = None
        self._source_code = None
        self._logo = None
        self._credit_decision = None
        self._credit_specific_recommendations = None
        self._loan_specific_recommendations = None
        self._required_documents = None
        self.discriminator = None
        self.product_code = product_code
        self.organisation_name = organisation_name
        self.source_code = source_code
        if logo is not None:
            self.logo = logo
        if credit_decision is not None:
            self.credit_decision = credit_decision
        if credit_specific_recommendations is not None:
            self.credit_specific_recommendations = credit_specific_recommendations
        if loan_specific_recommendations is not None:
            self.loan_specific_recommendations = loan_specific_recommendations
        if required_documents is not None:
            self.required_documents = required_documents

    @property
    def product_code(self):
        """Gets the product_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501

        A unique code that identifies the product  # noqa: E501

        :return: The product_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: str
        """
        return self._product_code

    @product_code.setter
    def product_code(self, product_code):
        """Sets the product_code of this ApplicationInquiryRequestedProductDecision.

        A unique code that identifies the product  # noqa: E501

        :param product_code: The product_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: str
        """
        if product_code is None:
            raise ValueError("Invalid value for `product_code`, must not be `None`")  # noqa: E501

        self._product_code = product_code

    @property
    def organisation_name(self):
        """Gets the organisation_name of this ApplicationInquiryRequestedProductDecision.  # noqa: E501

        Card issuing Organisation code  # noqa: E501

        :return: The organisation_name of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: str
        """
        return self._organisation_name

    @organisation_name.setter
    def organisation_name(self, organisation_name):
        """Sets the organisation_name of this ApplicationInquiryRequestedProductDecision.

        Card issuing Organisation code  # noqa: E501

        :param organisation_name: The organisation_name of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: str
        """
        if organisation_name is None:
            raise ValueError("Invalid value for `organisation_name`, must not be `None`")  # noqa: E501

        self._organisation_name = organisation_name

    @property
    def source_code(self):
        """Gets the source_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501

        A source code to identify the product  # noqa: E501

        :return: The source_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: str
        """
        return self._source_code

    @source_code.setter
    def source_code(self, source_code):
        """Sets the source_code of this ApplicationInquiryRequestedProductDecision.

        A source code to identify the product  # noqa: E501

        :param source_code: The source_code of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: str
        """
        if source_code is None:
            raise ValueError("Invalid value for `source_code`, must not be `None`")  # noqa: E501

        self._source_code = source_code

    @property
    def logo(self):
        """Gets the logo of this ApplicationInquiryRequestedProductDecision.  # noqa: E501

        Product logo to identify the product  # noqa: E501

        :return: The logo of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: str
        """
        return self._logo

    @logo.setter
    def logo(self, logo):
        """Sets the logo of this ApplicationInquiryRequestedProductDecision.

        Product logo to identify the product  # noqa: E501

        :param logo: The logo of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: str
        """

        self._logo = logo

    @property
    def credit_decision(self):
        """Gets the credit_decision of this ApplicationInquiryRequestedProductDecision.  # noqa: E501

        Evaluated Applicant Credit Decision  # noqa: E501

        :return: The credit_decision of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: str
        """
        return self._credit_decision

    @credit_decision.setter
    def credit_decision(self, credit_decision):
        """Sets the credit_decision of this ApplicationInquiryRequestedProductDecision.

        Evaluated Applicant Credit Decision  # noqa: E501

        :param credit_decision: The credit_decision of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: str
        """

        self._credit_decision = credit_decision

    @property
    def credit_specific_recommendations(self):
        """Gets the credit_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501


        :return: The credit_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: list[ApplicationInquiryCreditSpecificRecommendations]
        """
        return self._credit_specific_recommendations

    @credit_specific_recommendations.setter
    def credit_specific_recommendations(self, credit_specific_recommendations):
        """Sets the credit_specific_recommendations of this ApplicationInquiryRequestedProductDecision.


        :param credit_specific_recommendations: The credit_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: list[ApplicationInquiryCreditSpecificRecommendations]
        """

        self._credit_specific_recommendations = credit_specific_recommendations

    @property
    def loan_specific_recommendations(self):
        """Gets the loan_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501


        :return: The loan_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: list[ApplicationInquiryLoanSpecificRecommendations]
        """
        return self._loan_specific_recommendations

    @loan_specific_recommendations.setter
    def loan_specific_recommendations(self, loan_specific_recommendations):
        """Sets the loan_specific_recommendations of this ApplicationInquiryRequestedProductDecision.


        :param loan_specific_recommendations: The loan_specific_recommendations of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: list[ApplicationInquiryLoanSpecificRecommendations]
        """

        self._loan_specific_recommendations = loan_specific_recommendations

    @property
    def required_documents(self):
        """Gets the required_documents of this ApplicationInquiryRequestedProductDecision.  # noqa: E501


        :return: The required_documents of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :rtype: list[ApplicationInquiryRequiredDocuments]
        """
        return self._required_documents

    @required_documents.setter
    def required_documents(self, required_documents):
        """Sets the required_documents of this ApplicationInquiryRequestedProductDecision.


        :param required_documents: The required_documents of this ApplicationInquiryRequestedProductDecision.  # noqa: E501
        :type: list[ApplicationInquiryRequiredDocuments]
        """

        self._required_documents = required_documents

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(ApplicationInquiryRequestedProductDecision, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, ApplicationInquiryRequestedProductDecision):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
