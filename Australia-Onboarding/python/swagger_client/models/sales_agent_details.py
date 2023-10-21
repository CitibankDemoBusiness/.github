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

class SalesAgentDetails(object):
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
        'originating_sales_agent_id': 'str',
        'originating_sales_branch_name': 'str'
    }

    attribute_map = {
        'originating_sales_agent_id': 'originatingSalesAgentId',
        'originating_sales_branch_name': 'originatingSalesBranchName'
    }

    def __init__(self, originating_sales_agent_id=None, originating_sales_branch_name=None):  # noqa: E501
        """SalesAgentDetails - a model defined in Swagger"""  # noqa: E501
        self._originating_sales_agent_id = None
        self._originating_sales_branch_name = None
        self.discriminator = None
        if originating_sales_agent_id is not None:
            self.originating_sales_agent_id = originating_sales_agent_id
        if originating_sales_branch_name is not None:
            self.originating_sales_branch_name = originating_sales_branch_name

    @property
    def originating_sales_agent_id(self):
        """Gets the originating_sales_agent_id of this SalesAgentDetails.  # noqa: E501

        Agent Id of the bank representative sourcing the application form. This agent might be different from the agent who is processing the application.  # noqa: E501

        :return: The originating_sales_agent_id of this SalesAgentDetails.  # noqa: E501
        :rtype: str
        """
        return self._originating_sales_agent_id

    @originating_sales_agent_id.setter
    def originating_sales_agent_id(self, originating_sales_agent_id):
        """Sets the originating_sales_agent_id of this SalesAgentDetails.

        Agent Id of the bank representative sourcing the application form. This agent might be different from the agent who is processing the application.  # noqa: E501

        :param originating_sales_agent_id: The originating_sales_agent_id of this SalesAgentDetails.  # noqa: E501
        :type: str
        """

        self._originating_sales_agent_id = originating_sales_agent_id

    @property
    def originating_sales_branch_name(self):
        """Gets the originating_sales_branch_name of this SalesAgentDetails.  # noqa: E501

        Name of branch where the application is originally sourced.  # noqa: E501

        :return: The originating_sales_branch_name of this SalesAgentDetails.  # noqa: E501
        :rtype: str
        """
        return self._originating_sales_branch_name

    @originating_sales_branch_name.setter
    def originating_sales_branch_name(self, originating_sales_branch_name):
        """Sets the originating_sales_branch_name of this SalesAgentDetails.

        Name of branch where the application is originally sourced.  # noqa: E501

        :param originating_sales_branch_name: The originating_sales_branch_name of this SalesAgentDetails.  # noqa: E501
        :type: str
        """

        self._originating_sales_branch_name = originating_sales_branch_name

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
        if issubclass(SalesAgentDetails, dict):
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
        if not isinstance(other, SalesAgentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other