# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class CreditLimitDecreaseResponse(object):
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
        'control_flow_id': 'str',
        'credit_limitd_decrease_reference_id': 'str',
        'customer_consent_required_flag': 'bool'
    }

    attribute_map = {
        'control_flow_id': 'controlFlowId',
        'credit_limitd_decrease_reference_id': 'creditLimitdDecreaseReferenceId',
        'customer_consent_required_flag': 'customerConsentRequiredFlag'
    }

    def __init__(self, control_flow_id=None, credit_limitd_decrease_reference_id=None, customer_consent_required_flag=None):  # noqa: E501
        """CreditLimitDecreaseResponse - a model defined in Swagger"""  # noqa: E501
        self._control_flow_id = None
        self._credit_limitd_decrease_reference_id = None
        self._customer_consent_required_flag = None
        self.discriminator = None
        if control_flow_id is not None:
            self.control_flow_id = control_flow_id
        if credit_limitd_decrease_reference_id is not None:
            self.credit_limitd_decrease_reference_id = credit_limitd_decrease_reference_id
        if customer_consent_required_flag is not None:
            self.customer_consent_required_flag = customer_consent_required_flag

    @property
    def control_flow_id(self):
        """Gets the control_flow_id of this CreditLimitDecreaseResponse.  # noqa: E501

        It is used to control the flow for subsequent requests in the session.  # noqa: E501

        :return: The control_flow_id of this CreditLimitDecreaseResponse.  # noqa: E501
        :rtype: str
        """
        return self._control_flow_id

    @control_flow_id.setter
    def control_flow_id(self, control_flow_id):
        """Sets the control_flow_id of this CreditLimitDecreaseResponse.

        It is used to control the flow for subsequent requests in the session.  # noqa: E501

        :param control_flow_id: The control_flow_id of this CreditLimitDecreaseResponse.  # noqa: E501
        :type: str
        """

        self._control_flow_id = control_flow_id

    @property
    def credit_limitd_decrease_reference_id(self):
        """Gets the credit_limitd_decrease_reference_id of this CreditLimitDecreaseResponse.  # noqa: E501

        Unique Reference Id for the request for credit limit decrease request.  # noqa: E501

        :return: The credit_limitd_decrease_reference_id of this CreditLimitDecreaseResponse.  # noqa: E501
        :rtype: str
        """
        return self._credit_limitd_decrease_reference_id

    @credit_limitd_decrease_reference_id.setter
    def credit_limitd_decrease_reference_id(self, credit_limitd_decrease_reference_id):
        """Sets the credit_limitd_decrease_reference_id of this CreditLimitDecreaseResponse.

        Unique Reference Id for the request for credit limit decrease request.  # noqa: E501

        :param credit_limitd_decrease_reference_id: The credit_limitd_decrease_reference_id of this CreditLimitDecreaseResponse.  # noqa: E501
        :type: str
        """

        self._credit_limitd_decrease_reference_id = credit_limitd_decrease_reference_id

    @property
    def customer_consent_required_flag(self):
        """Gets the customer_consent_required_flag of this CreditLimitDecreaseResponse.  # noqa: E501

        This refers that consent is required from customer as new limit lower than the outstanding request.  # noqa: E501

        :return: The customer_consent_required_flag of this CreditLimitDecreaseResponse.  # noqa: E501
        :rtype: bool
        """
        return self._customer_consent_required_flag

    @customer_consent_required_flag.setter
    def customer_consent_required_flag(self, customer_consent_required_flag):
        """Sets the customer_consent_required_flag of this CreditLimitDecreaseResponse.

        This refers that consent is required from customer as new limit lower than the outstanding request.  # noqa: E501

        :param customer_consent_required_flag: The customer_consent_required_flag of this CreditLimitDecreaseResponse.  # noqa: E501
        :type: bool
        """

        self._customer_consent_required_flag = customer_consent_required_flag

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
        if issubclass(CreditLimitDecreaseResponse, dict):
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
        if not isinstance(other, CreditLimitDecreaseResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
