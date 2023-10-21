# coding: utf-8

"""
    TaxStatement_Digital_Orchestation

    Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class Documents(object):
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
        'document_details': 'list[DocumentDetails]'
    }

    attribute_map = {
        'document_details': 'DocumentDetails'
    }

    def __init__(self, document_details=None):  # noqa: E501
        """Documents - a model defined in Swagger"""  # noqa: E501
        self._document_details = None
        self.discriminator = None
        if document_details is not None:
            self.document_details = document_details

    @property
    def document_details(self):
        """Gets the document_details of this Documents.  # noqa: E501


        :return: The document_details of this Documents.  # noqa: E501
        :rtype: list[DocumentDetails]
        """
        return self._document_details

    @document_details.setter
    def document_details(self, document_details):
        """Sets the document_details of this Documents.


        :param document_details: The document_details of this Documents.  # noqa: E501
        :type: list[DocumentDetails]
        """

        self._document_details = document_details

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
        if issubclass(Documents, dict):
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
        if not isinstance(other, Documents):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other