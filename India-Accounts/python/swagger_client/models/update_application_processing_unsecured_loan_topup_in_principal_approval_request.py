# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest(object):
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
        'applicant': 'Applicant',
        'requested_loan_topup_decision': 'RequestedLoanTopupDecision'
    }

    attribute_map = {
        'applicant': 'applicant',
        'requested_loan_topup_decision': 'requestedLoanTopupDecision'
    }

    def __init__(self, applicant=None, requested_loan_topup_decision=None):  # noqa: E501
        """UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest - a model defined in Swagger"""  # noqa: E501
        self._applicant = None
        self._requested_loan_topup_decision = None
        self.discriminator = None
        if applicant is not None:
            self.applicant = applicant
        if requested_loan_topup_decision is not None:
            self.requested_loan_topup_decision = requested_loan_topup_decision

    @property
    def applicant(self):
        """Gets the applicant of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501


        :return: The applicant of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501
        :rtype: Applicant
        """
        return self._applicant

    @applicant.setter
    def applicant(self, applicant):
        """Sets the applicant of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.


        :param applicant: The applicant of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501
        :type: Applicant
        """

        self._applicant = applicant

    @property
    def requested_loan_topup_decision(self):
        """Gets the requested_loan_topup_decision of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501


        :return: The requested_loan_topup_decision of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501
        :rtype: RequestedLoanTopupDecision
        """
        return self._requested_loan_topup_decision

    @requested_loan_topup_decision.setter
    def requested_loan_topup_decision(self, requested_loan_topup_decision):
        """Sets the requested_loan_topup_decision of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.


        :param requested_loan_topup_decision: The requested_loan_topup_decision of this UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.  # noqa: E501
        :type: RequestedLoanTopupDecision
        """

        self._requested_loan_topup_decision = requested_loan_topup_decision

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
        if issubclass(UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest, dict):
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
        if not isinstance(other, UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other