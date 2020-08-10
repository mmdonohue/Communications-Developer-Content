# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest

import avalara.comms.rest.v2
from avalara.comms.rest.v2.api.lookups_api import LookupsApi  # noqa: E501
from avalara.comms.rest.v2.rest import ApiException


class TestLookupsApi(unittest.TestCase):
    """LookupsApi unit test stubs"""

    def setUp(self):
        self.api = avalara.comms.rest.v2.api.lookups_api.LookupsApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_api_v2_afc_location_p_code_get(self):
        """Test case for api_v2_afc_location_p_code_get

        Get location data associated with a PCode  # noqa: E501
        """
        pass

    def test_api_v2_afc_primary_p_code_get(self):
        """Test case for api_v2_afc_primary_p_code_get

        Get primary location data associated with a PCode  # noqa: E501
        """
        pass

    def test_api_v2_afc_serviceinfo_get(self):
        """Test case for api_v2_afc_serviceinfo_get

        Retrieves server time, service build version and engine version  # noqa: E501
        """
        pass

    def test_api_v2_afc_taxtype_tax_type_get(self):
        """Test case for api_v2_afc_taxtype_tax_type_get

        Get the tax information (description and category) for a tax type ID  # noqa: E501
        """
        pass

    def test_api_v2_afc_tspairs_get(self):
        """Test case for api_v2_afc_tspairs_get

        Get transaction/service pair information  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
