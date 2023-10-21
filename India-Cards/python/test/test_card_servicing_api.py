# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.card_servicing_api import CardServicingApi  # noqa: E501
from swagger_client.rest import ApiException


class TestCardServicingApi(unittest.TestCase):
    """CardServicingApi unit test stubs"""

    def setUp(self):
        self.api = CardServicingApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_v1_cards_activations_confirmation_post(self):
        """Test case for v1_cards_activations_confirmation_post

        Confirm Card Activation Deactivation  # noqa: E501
        """
        pass

    def test_v1_cards_atm_pin_reset_confirmation_post(self):
        """Test case for v1_cards_atm_pin_reset_confirmation_post

        Confirm ATM Pin Request  # noqa: E501
        """
        pass

    def test_v1_cards_atm_pin_reset_put(self):
        """Test case for v1_cards_atm_pin_reset_put

        Reset ATM Pin  # noqa: E501
        """
        pass

    def test_v1_cards_overseas_usage_confirmation_post(self):
        """Test case for v1_cards_overseas_usage_confirmation_post

        Confirm Card Overseas Activation Deactivation  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
