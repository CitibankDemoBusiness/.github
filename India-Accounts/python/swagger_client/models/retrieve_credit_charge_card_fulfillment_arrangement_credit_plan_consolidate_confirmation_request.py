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

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest(object):
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
        'control_flow_id': 'str'
    }

    attribute_map = {
        'control_flow_id': 'controlFlowId'
    }

    def __init__(self, control_flow_id=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest - a model defined in Swagger"""  # noqa: E501
        self._control_flow_id = None
        self.discriminator = None
        self.control_flow_id = control_flow_id

    @property
    def control_flow_id(self):
        """Gets the control_flow_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.  # noqa: E501

        Control Flow Id  # noqa: E501

        :return: The control_flow_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.  # noqa: E501
        :rtype: str
        """
        return self._control_flow_id

    @control_flow_id.setter
    def control_flow_id(self, control_flow_id):
        """Sets the control_flow_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.

        Control Flow Id  # noqa: E501

        :param control_flow_id: The control_flow_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.  # noqa: E501
        :type: str
        """
        if control_flow_id is None:
            raise ValueError("Invalid value for `control_flow_id`, must not be `None`")  # noqa: E501

        self._control_flow_id = control_flow_id

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
