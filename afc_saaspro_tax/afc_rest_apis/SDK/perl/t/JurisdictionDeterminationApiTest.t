=begin comment

SaasPro

APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

The version of the OpenAPI document: v2

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator
# Please update the test cases below to test the API endpoints.
# Ref: https://openapi-generator.tech
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::OpenAPIClient::JurisdictionDeterminationApi');

my $api = WWW::OpenAPIClient::JurisdictionDeterminationApi->new();
isa_ok($api, 'WWW::OpenAPIClient::JurisdictionDeterminationApi');

#
# api_v2_afc_p_code_post test
#
{
    my $p_code_lookup_request = undef; # replace NULL with a proper value
    my $result = $api->api_v2_afc_p_code_post(p_code_lookup_request => $p_code_lookup_request);
}

#
# api_v2_geo_batch_log_process_id_get test
#
{
    my $process_id = undef; # replace NULL with a proper value
    my $result = $api->api_v2_geo_batch_log_process_id_get(process_id => $process_id);
}

#
# api_v2_geo_batch_status_process_id_get test
#
{
    my $process_id = undef; # replace NULL with a proper value
    my $result = $api->api_v2_geo_batch_status_process_id_get(process_id => $process_id);
}

#
# api_v2_geo_batch_upload_post test
#
{
    my $file = undef; # replace NULL with a proper value
    my $result = $api->api_v2_geo_batch_upload_post(file => $file);
}

#
# api_v2_geo_geocode_post test
#
{
    my $geocode_request = undef; # replace NULL with a proper value
    my $result = $api->api_v2_geo_geocode_post(geocode_request => $geocode_request);
}


1;