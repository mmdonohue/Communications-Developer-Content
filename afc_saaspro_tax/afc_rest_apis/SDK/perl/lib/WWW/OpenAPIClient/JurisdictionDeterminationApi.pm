=begin comment

SaasPro

APIs to interface with communications tax engine.<br />The API requires Basic authentication.<br />Users with access to multiple clients must also set request header parameter for <code>client_id</code>.<br />Set <code>client_profile_id</code> to specify profile to be used for taxation.

The version of the OpenAPI document: v2

Generated by: https://openapi-generator.tech

=end comment

=cut

#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# Do not edit the class manually.
# Ref: https://openapi-generator.tech
#
package WWW::OpenAPIClient::JurisdictionDeterminationApi;

require 5.6.0;
use strict;
use warnings;
use utf8; 
use Exporter;
use Carp qw( croak );
use Log::Any qw($log);

use WWW::OpenAPIClient::ApiClient;

use base "Class::Data::Inheritable";

__PACKAGE__->mk_classdata('method_documentation' => {});

sub new {
    my $class = shift;
    my $api_client;

    if ($_[0] && ref $_[0] && ref $_[0] eq 'WWW::OpenAPIClient::ApiClient' ) {
        $api_client = $_[0];
    } else {
        $api_client = WWW::OpenAPIClient::ApiClient->new(@_);
    }

    bless { api_client => $api_client }, $class;

}


#
# api_v2_afc_p_code_post
#
# Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.
# 
# @param PCodeLookupRequest $p_code_lookup_request  (optional)
{
    my $params = {
    'p_code_lookup_request' => {
        data_type => 'PCodeLookupRequest',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'api_v2_afc_p_code_post' } = { 
        summary => 'Get PCode(s) associated with a location - Ctry/State/County/City/Zip/NpaNxx/Fips.',
        params => $params,
        returns => 'PCodeLookupResult',
        };
}
# @return PCodeLookupResult
#
sub api_v2_afc_p_code_post {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/api/v2/afc/PCode';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('text/plain', 'application/json', 'text/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json-patch+json', 'application/json', 'text/json', 'application/*+json');

    my $_body_data;
    # body params
    if ( exists $args{'p_code_lookup_request'}) {
        $_body_data = $args{'p_code_lookup_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw(Basic )];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('PCodeLookupResult', $response);
    return $_response_object;
}

#
# api_v2_geo_batch_log_process_id_get
#
# Retrieves log on Geo Batch file
# 
# @param string $process_id Process Id for Geo Batch File. (required)
{
    my $params = {
    'process_id' => {
        data_type => 'string',
        description => 'Process Id for Geo Batch File.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'api_v2_geo_batch_log_process_id_get' } = { 
        summary => 'Retrieves log on Geo Batch file',
        params => $params,
        returns => 'GeoBatchLog',
        };
}
# @return GeoBatchLog
#
sub api_v2_geo_batch_log_process_id_get {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/api/v2/geo/batch/log/{processId}';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('text/plain', 'application/json', 'text/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # path params
    if ( exists $args{'process_id'}) {
        my $_base_variable = "{" . "processId" . "}";
        my $_base_value = $self->{api_client}->to_path_value($args{'process_id'});
        $_resource_path =~ s/$_base_variable/$_base_value/g;
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(Basic )];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('GeoBatchLog', $response);
    return $_response_object;
}

#
# api_v2_geo_batch_status_process_id_get
#
# Retrieves information on Geo Batch file status
# 
# @param string $process_id Process Id for Geo Batch File. (required)
{
    my $params = {
    'process_id' => {
        data_type => 'string',
        description => 'Process Id for Geo Batch File.',
        required => '1',
    },
    };
    __PACKAGE__->method_documentation->{ 'api_v2_geo_batch_status_process_id_get' } = { 
        summary => 'Retrieves information on Geo Batch file status',
        params => $params,
        returns => 'GeoBatchStatus',
        };
}
# @return GeoBatchStatus
#
sub api_v2_geo_batch_status_process_id_get {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/api/v2/geo/batch/status/{processId}';

    my $_method = 'GET';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('text/plain', 'application/json', 'text/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type();

    # path params
    if ( exists $args{'process_id'}) {
        my $_base_variable = "{" . "processId" . "}";
        my $_base_value = $self->{api_client}->to_path_value($args{'process_id'});
        $_resource_path =~ s/$_base_variable/$_base_value/g;
    }

    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(Basic )];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('GeoBatchStatus', $response);
    return $_response_object;
}

#
# api_v2_geo_batch_upload_post
#
# Uploads file to Geo Batch.
# 
# @param string $geo_batch_file  (optional)
{
    my $params = {
    'geo_batch_file' => {
        data_type => 'string',
        description => '',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'api_v2_geo_batch_upload_post' } = { 
        summary => 'Uploads file to Geo Batch.',
        params => $params,
        returns => 'GeoBatchSubmitFileResponse',
        };
}
# @return GeoBatchSubmitFileResponse
#
sub api_v2_geo_batch_upload_post {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/api/v2/geo/batch/Upload';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('text/plain', 'application/json', 'text/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('multipart/form-data');

    # form params
    if ( exists $args{'geo_batch_file'} ) {
        $form_params->{'geoBatchFile'} = [] unless defined $form_params->{'geoBatchFile'};
        push @{$form_params->{'geoBatchFile'}}, $args{'geo_batch_file'};
            }
    
    my $_body_data;
    # authentication setting, if any
    my $auth_settings = [qw(Basic )];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('GeoBatchSubmitFileResponse', $response);
    return $_response_object;
}

#
# api_v2_geo_geocode_post
#
# Geocodes one or multiple street addresses and/or lat/long coordinate pairs.
# 
# @param ARRAY[GeocodeRequest] $geocode_request List of street addresses and/or lat/long coordinate pairs to geocode. (optional)
{
    my $params = {
    'geocode_request' => {
        data_type => 'ARRAY[GeocodeRequest]',
        description => 'List of street addresses and/or lat/long coordinate pairs to geocode.',
        required => '0',
    },
    };
    __PACKAGE__->method_documentation->{ 'api_v2_geo_geocode_post' } = { 
        summary => 'Geocodes one or multiple street addresses and/or lat/long coordinate pairs.',
        params => $params,
        returns => 'ARRAY[GeocodeResult]',
        };
}
# @return ARRAY[GeocodeResult]
#
sub api_v2_geo_geocode_post {
    my ($self, %args) = @_;

    # parse inputs
    my $_resource_path = '/api/v2/geo/Geocode';

    my $_method = 'POST';
    my $query_params = {};
    my $header_params = {};
    my $form_params = {};

    # 'Accept' and 'Content-Type' header
    my $_header_accept = $self->{api_client}->select_header_accept('text/plain', 'application/json', 'text/json');
    if ($_header_accept) {
        $header_params->{'Accept'} = $_header_accept;
    }
    $header_params->{'Content-Type'} = $self->{api_client}->select_header_content_type('application/json-patch+json', 'application/json', 'text/json', 'application/*+json');

    my $_body_data;
    # body params
    if ( exists $args{'geocode_request'}) {
        $_body_data = $args{'geocode_request'};
    }

    # authentication setting, if any
    my $auth_settings = [qw(Basic )];

    # make the API Call
    my $response = $self->{api_client}->call_api($_resource_path, $_method,
                                           $query_params, $form_params,
                                           $header_params, $_body_data, $auth_settings);
    if (!$response) {
        return;
    }
    my $_response_object = $self->{api_client}->deserialize('ARRAY[GeocodeResult]', $response);
    return $_response_object;
}

1;
