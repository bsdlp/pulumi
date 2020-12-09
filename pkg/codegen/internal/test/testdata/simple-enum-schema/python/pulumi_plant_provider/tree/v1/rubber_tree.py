# coding=utf-8
# *** WARNING: this file was generated by test. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from ... import _enums as _root_enums
from ... import _inputs as _root_inputs
from ... import outputs as _root_outputs
from ._enums import *

__all__ = ['RubberTree']


class RubberTree(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 container: Optional[pulumi.Input[pulumi.InputType['_root_inputs.ContainerArgs']]] = None,
                 farm: Optional[pulumi.Input[Union['Farm', str]]] = None,
                 type: Optional[pulumi.Input['RubberTreeVariety']] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a RubberTree resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['container'] = container
            __props__['farm'] = farm
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
        super(RubberTree, __self__).__init__(
            'plant-provider:tree/v1:RubberTree',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RubberTree':
        """
        Get an existing RubberTree resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return RubberTree(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def container(self) -> pulumi.Output[Optional['_root_outputs.Container']]:
        return pulumi.get(self, "container")

    @property
    @pulumi.getter
    def farm(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "farm")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output['RubberTreeVariety']:
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

