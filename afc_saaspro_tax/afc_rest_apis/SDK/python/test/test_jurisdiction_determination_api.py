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
from avalara.comms.rest.v2.api.jurisdiction_determination_api import JurisdictionDeterminationApi  # noqa: E501
from avalara.comms.rest.v2.rest import ApiException


class TestJurisdictionDeterminationApi(unittest.TestCase):
    """JurisdictionDeterminationApi unit test stubs"""

    def setUp(self):
        self.api = avalara.comms.rest.v2.api.jurisdiction_determination_api.JurisdictionDeterminationApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_api_v2_afc_p_code_post(self):
        """Test case for api_v2_afc_p_code_post

        Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.  # noqa: E501
        """
        pass

    def test_api_v2_geo_batch_log_process_id_get(self):
        """Test case for api_v2_geo_batch_log_process_id_get

        Retrieves log on Geo Batch file  # noqa: E501
        """
        pass

    def test_api_v2_geo_batch_status_process_id_get(self):
        """Test case for api_v2_geo_batch_status_process_id_get

        Retrieves information on Geo Batch file status  # noqa: E501
        """
        pass

    def test_api_v2_geo_batch_upload_post(self):
        """Test case for api_v2_geo_batch_upload_post

        Uploads file to Geo Batch.  # noqa: E501
        """
        pass

    def test_api_v2_geo_geocode_post(self):
        """Test case for api_v2_geo_geocode_post

        Geocodes one or multiple street addresses and/or lat/long coordinate pairs.  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
