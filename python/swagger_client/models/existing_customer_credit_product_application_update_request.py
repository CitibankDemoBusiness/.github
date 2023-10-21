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

class ExistingCustomerCreditProductApplicationUpdateRequest(object):
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
        'product': 'ECMProductUpdate',
        'survivor_product': 'SurvivorProduct',
        'applicant': 'ECMApplicantUpdate',
        'sales_agent_details': 'SalesAgentDetails',
        'control_flow_id': 'str'
    }

    attribute_map = {
        'product': 'product',
        'survivor_product': 'survivorProduct',
        'applicant': 'applicant',
        'sales_agent_details': 'salesAgentDetails',
        'control_flow_id': 'controlFlowId'
    }

    def __init__(self, product=None, survivor_product=None, applicant=None, sales_agent_details=None, control_flow_id=None):  # noqa: E501
        """ExistingCustomerCreditProductApplicationUpdateRequest - a model defined in Swagger"""  # noqa: E501
        self._product = None
        self._survivor_product = None
        self._applicant = None
        self._sales_agent_details = None
        self._control_flow_id = None
        self.discriminator = None
        if product is not None:
            self.product = product
        if survivor_product is not None:
            self.survivor_product = survivor_product
        if applicant is not None:
            self.applicant = applicant
        if sales_agent_details is not None:
            self.sales_agent_details = sales_agent_details
        self.control_flow_id = control_flow_id

    @property
    def product(self):
        """Gets the product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501


        :return: The product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :rtype: ECMProductUpdate
        """
        return self._product

    @product.setter
    def product(self, product):
        """Sets the product of this ExistingCustomerCreditProductApplicationUpdateRequest.


        :param product: The product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :type: ECMProductUpdate
        """

        self._product = product

    @property
    def survivor_product(self):
        """Gets the survivor_product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501


        :return: The survivor_product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :rtype: SurvivorProduct
        """
        return self._survivor_product

    @survivor_product.setter
    def survivor_product(self, survivor_product):
        """Sets the survivor_product of this ExistingCustomerCreditProductApplicationUpdateRequest.


        :param survivor_product: The survivor_product of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :type: SurvivorProduct
        """

        self._survivor_product = survivor_product

    @property
    def applicant(self):
        """Gets the applicant of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501


        :return: The applicant of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :rtype: ECMApplicantUpdate
        """
        return self._applicant

    @applicant.setter
    def applicant(self, applicant):
        """Sets the applicant of this ExistingCustomerCreditProductApplicationUpdateRequest.


        :param applicant: The applicant of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :type: ECMApplicantUpdate
        """

        self._applicant = applicant

    @property
    def sales_agent_details(self):
        """Gets the sales_agent_details of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501


        :return: The sales_agent_details of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :rtype: SalesAgentDetails
        """
        return self._sales_agent_details

    @sales_agent_details.setter
    def sales_agent_details(self, sales_agent_details):
        """Sets the sales_agent_details of this ExistingCustomerCreditProductApplicationUpdateRequest.


        :param sales_agent_details: The sales_agent_details of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :type: SalesAgentDetails
        """

        self._sales_agent_details = sales_agent_details

    @property
    def control_flow_id(self):
        """Gets the control_flow_id of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501

        Control flow id is used to control the flow for subsequent requests in the session.  # noqa: E501

        :return: The control_flow_id of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
        :rtype: str
        """
        return self._control_flow_id

    @control_flow_id.setter
    def control_flow_id(self, control_flow_id):
        """Sets the control_flow_id of this ExistingCustomerCreditProductApplicationUpdateRequest.

        Control flow id is used to control the flow for subsequent requests in the session.  # noqa: E501

        :param control_flow_id: The control_flow_id of this ExistingCustomerCreditProductApplicationUpdateRequest.  # noqa: E501
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
        if issubclass(ExistingCustomerCreditProductApplicationUpdateRequest, dict):
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
        if not isinstance(other, ExistingCustomerCreditProductApplicationUpdateRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
