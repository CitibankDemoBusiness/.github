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

class ApplicationAddContactPreference(object):
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
        'send_sms_advice_flag': 'bool',
        'send_email_advice_flag': 'bool',
        'preferred_mailing_address': 'str',
        'e_statement_enrollment_flag': 'bool'
    }

    attribute_map = {
        'send_sms_advice_flag': 'sendSmsAdviceFlag',
        'send_email_advice_flag': 'sendEmailAdviceFlag',
        'preferred_mailing_address': 'preferredMailingAddress',
        'e_statement_enrollment_flag': 'eStatementEnrollmentFlag'
    }

    def __init__(self, send_sms_advice_flag=None, send_email_advice_flag=None, preferred_mailing_address=None, e_statement_enrollment_flag=None):  # noqa: E501
        """ApplicationAddContactPreference - a model defined in Swagger"""  # noqa: E501
        self._send_sms_advice_flag = None
        self._send_email_advice_flag = None
        self._preferred_mailing_address = None
        self._e_statement_enrollment_flag = None
        self.discriminator = None
        if send_sms_advice_flag is not None:
            self.send_sms_advice_flag = send_sms_advice_flag
        if send_email_advice_flag is not None:
            self.send_email_advice_flag = send_email_advice_flag
        if preferred_mailing_address is not None:
            self.preferred_mailing_address = preferred_mailing_address
        if e_statement_enrollment_flag is not None:
            self.e_statement_enrollment_flag = e_statement_enrollment_flag

    @property
    def send_sms_advice_flag(self):
        """Gets the send_sms_advice_flag of this ApplicationAddContactPreference.  # noqa: E501

        Applicant's subscription for receiving advices through SMS. Valid values: true and false  # noqa: E501

        :return: The send_sms_advice_flag of this ApplicationAddContactPreference.  # noqa: E501
        :rtype: bool
        """
        return self._send_sms_advice_flag

    @send_sms_advice_flag.setter
    def send_sms_advice_flag(self, send_sms_advice_flag):
        """Sets the send_sms_advice_flag of this ApplicationAddContactPreference.

        Applicant's subscription for receiving advices through SMS. Valid values: true and false  # noqa: E501

        :param send_sms_advice_flag: The send_sms_advice_flag of this ApplicationAddContactPreference.  # noqa: E501
        :type: bool
        """

        self._send_sms_advice_flag = send_sms_advice_flag

    @property
    def send_email_advice_flag(self):
        """Gets the send_email_advice_flag of this ApplicationAddContactPreference.  # noqa: E501

        Applicant's subscription for receiving advices through email. Valid values: true and false  # noqa: E501

        :return: The send_email_advice_flag of this ApplicationAddContactPreference.  # noqa: E501
        :rtype: bool
        """
        return self._send_email_advice_flag

    @send_email_advice_flag.setter
    def send_email_advice_flag(self, send_email_advice_flag):
        """Sets the send_email_advice_flag of this ApplicationAddContactPreference.

        Applicant's subscription for receiving advices through email. Valid values: true and false  # noqa: E501

        :param send_email_advice_flag: The send_email_advice_flag of this ApplicationAddContactPreference.  # noqa: E501
        :type: bool
        """

        self._send_email_advice_flag = send_email_advice_flag

    @property
    def preferred_mailing_address(self):
        """Gets the preferred_mailing_address of this ApplicationAddContactPreference.  # noqa: E501

        Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The preferred_mailing_address of this ApplicationAddContactPreference.  # noqa: E501
        :rtype: str
        """
        return self._preferred_mailing_address

    @preferred_mailing_address.setter
    def preferred_mailing_address(self, preferred_mailing_address):
        """Sets the preferred_mailing_address of this ApplicationAddContactPreference.

        Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param preferred_mailing_address: The preferred_mailing_address of this ApplicationAddContactPreference.  # noqa: E501
        :type: str
        """

        self._preferred_mailing_address = preferred_mailing_address

    @property
    def e_statement_enrollment_flag(self):
        """Gets the e_statement_enrollment_flag of this ApplicationAddContactPreference.  # noqa: E501

        Applicant's subscription for receiving statement over email. Valid values: true and false  # noqa: E501

        :return: The e_statement_enrollment_flag of this ApplicationAddContactPreference.  # noqa: E501
        :rtype: bool
        """
        return self._e_statement_enrollment_flag

    @e_statement_enrollment_flag.setter
    def e_statement_enrollment_flag(self, e_statement_enrollment_flag):
        """Sets the e_statement_enrollment_flag of this ApplicationAddContactPreference.

        Applicant's subscription for receiving statement over email. Valid values: true and false  # noqa: E501

        :param e_statement_enrollment_flag: The e_statement_enrollment_flag of this ApplicationAddContactPreference.  # noqa: E501
        :type: bool
        """

        self._e_statement_enrollment_flag = e_statement_enrollment_flag

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
        if issubclass(ApplicationAddContactPreference, dict):
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
        if not isinstance(other, ApplicationAddContactPreference):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
