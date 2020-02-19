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
package WWW::OpenAPIClient::Object::Location;

require 5.6.0;
use strict;
use warnings;
use utf8;
use JSON qw(decode_json);
use Data::Dumper;
use Module::Runtime qw(use_module);
use Log::Any qw($log);
use Date::Parse;
use DateTime;


use base ("Class::Accessor", "Class::Data::Inheritable");

#
#Location data used to determine taxing jurisdiction.
#
# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech). Do not edit the class manually.
# REF: https://openapi-generator.tech
#

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
__PACKAGE__->mk_classdata('attribute_map' => {});
__PACKAGE__->mk_classdata('openapi_types' => {});
__PACKAGE__->mk_classdata('method_documentation' => {}); 
__PACKAGE__->mk_classdata('class_documentation' => {});

# new plain object
sub new { 
    my ($class, %args) = @_; 

    my $self = bless {}, $class;

    $self->init(%args);
    
    return $self;
}

# initialize the object
sub init
{
    my ($self, %args) = @_;

    foreach my $attribute (keys %{$self->attribute_map}) {
        my $args_key = $self->attribute_map->{$attribute};
        $self->$attribute( $args{ $args_key } );
    }
}

# return perl hash
sub to_hash {
    my $self = shift;
    my $_hash = decode_json(JSON->new->convert_blessed->encode($self));

    return $_hash;
}

# used by JSON for serialization
sub TO_JSON { 
    my $self = shift;
    my $_data = {};
    foreach my $_key (keys %{$self->attribute_map}) {
        if (defined $self->{$_key}) {
            $_data->{$self->attribute_map->{$_key}} = $self->{$_key};
        }
    }

    return $_data;
}

# from Perl hashref
sub from_hash {
    my ($self, $hash) = @_;

    # loop through attributes and use openapi_types to deserialize the data
    while ( my ($_key, $_type) = each %{$self->openapi_types} ) {
        my $_json_attribute = $self->attribute_map->{$_key}; 
        if ($_type =~ /^array\[(.+)\]$/i) { # array
            my $_subclass = $1;
            my @_array = ();
            foreach my $_element (@{$hash->{$_json_attribute}}) {
                push @_array, $self->_deserialize($_subclass, $_element);
            }
            $self->{$_key} = \@_array;
        } elsif ($_type =~ /^hash\[string,(.+)\]$/i) { # hash
            my $_subclass = $1;
            my %_hash = ();
            while (my($_key, $_element) = each %{$hash->{$_json_attribute}}) {
                $_hash{$_key} = $self->_deserialize($_subclass, $_element);
            }
            $self->{$_key} = \%_hash;
        } elsif (exists $hash->{$_json_attribute}) { #hash(model), primitive, datetime
            $self->{$_key} = $self->_deserialize($_type, $hash->{$_json_attribute});
        } else {
            $log->debugf("Warning: %s (%s) does not exist in input hash\n", $_key, $_json_attribute);
        }
    }
  
    return $self;
}

# deserialize non-array data
sub _deserialize {
    my ($self, $type, $data) = @_;
    $log->debugf("deserializing %s with %s",Dumper($data), $type);

    if ($type eq 'DateTime') {
        return DateTime->from_epoch(epoch => str2time($data));
    } elsif ( grep( /^$type$/, ('int', 'double', 'string', 'boolean'))) {
        return $data;
    } else { # hash(model)
        my $_instance = eval "WWW::OpenAPIClient::Object::$type->new()";
        return $_instance->from_hash($data);
    }
}



__PACKAGE__->class_documentation({description => 'Location data used to determine taxing jurisdiction.',
                                  class => 'Location',
                                  required => [], # TODO
}                                 );

__PACKAGE__->method_documentation({
    'cnty' => {
        datatype => 'string',
        base_name => 'cnty',
        description => '',
        format => '',
        read_only => '',
            },
    'ctry' => {
        datatype => 'string',
        base_name => 'ctry',
        description => '',
        format => '',
        read_only => '',
            },
    'int' => {
        datatype => 'boolean',
        base_name => 'int',
        description => '',
        format => '',
        read_only => '',
            },
    'geo' => {
        datatype => 'boolean',
        base_name => 'geo',
        description => '',
        format => '',
        read_only => '',
            },
    'pcd' => {
        datatype => 'int',
        base_name => 'pcd',
        description => '',
        format => '',
        read_only => '',
            },
    'npa' => {
        datatype => 'int',
        base_name => 'npa',
        description => '',
        format => '',
        read_only => '',
            },
    'fips' => {
        datatype => 'string',
        base_name => 'fips',
        description => '',
        format => '',
        read_only => '',
            },
    'addr' => {
        datatype => 'string',
        base_name => 'addr',
        description => '',
        format => '',
        read_only => '',
            },
    'city' => {
        datatype => 'string',
        base_name => 'city',
        description => 'City name.',
        format => '',
        read_only => '',
            },
    'st' => {
        datatype => 'string',
        base_name => 'st',
        description => '',
        format => '',
        read_only => '',
            },
    'zip' => {
        datatype => 'string',
        base_name => 'zip',
        description => '',
        format => '',
        read_only => '',
            },
});

__PACKAGE__->openapi_types( {
    'cnty' => 'string',
    'ctry' => 'string',
    'int' => 'boolean',
    'geo' => 'boolean',
    'pcd' => 'int',
    'npa' => 'int',
    'fips' => 'string',
    'addr' => 'string',
    'city' => 'string',
    'st' => 'string',
    'zip' => 'string'
} );

__PACKAGE__->attribute_map( {
    'cnty' => 'cnty',
    'ctry' => 'ctry',
    'int' => 'int',
    'geo' => 'geo',
    'pcd' => 'pcd',
    'npa' => 'npa',
    'fips' => 'fips',
    'addr' => 'addr',
    'city' => 'city',
    'st' => 'st',
    'zip' => 'zip'
} );

__PACKAGE__->mk_accessors(keys %{__PACKAGE__->attribute_map});


1;
