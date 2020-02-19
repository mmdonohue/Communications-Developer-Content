# coding: utf-8

"""
    SaasPro

    APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.  # noqa: E501

    The version of the OpenAPI document: v2
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

import unittest
import datetime

import avalara.comms.rest.v2
from avalara.comms.rest.v2.models.tax_bracket import TaxBracket  # noqa: E501
from avalara.comms.rest.v2.rest import ApiException

class TestTaxBracket(unittest.TestCase):
    """TaxBracket unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def make_instance(self, include_optional):
        """Test TaxBracket
            include_option is a boolean, when False only required
            params are included, when True both required and
            optional params are included """
        # model = avalara.comms.rest.v2.models.tax_bracket.TaxBracket()  # noqa: E501
        if include_optional :
            return TaxBracket(
                rate = 1.337, 
                max = 1.337
            )
        else :
            return TaxBracket(
        )

    def testTaxBracket(self):
        """Test TaxBracket"""
        inst_req_only = self.make_instance(include_optional=False)
        inst_req_and_optional = self.make_instance(include_optional=True)


if __name__ == '__main__':
    unittest.main()
