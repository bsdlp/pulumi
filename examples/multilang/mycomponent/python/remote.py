# Copyright 2016-2018, Pulumi Corporation.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

from pulumi import ComponentResource, CustomResource, Output, InvokeOptions, ResourceOptions, log, Input
from pulumi.runtime.rpc import deserialize_properties, serialize_properties
from typing import Callable, Any, Dict, List, Optional

async def construct(
        libraryPath: str, 
        resource: str, 
        name: str, 
        args: Any, 
        opts: Any) -> Any:
    property_dependencies_resources: Dict[str, List['Resource']] = {}
    args_struct = await serialize_properties(args, property_dependencies_resources)
    opts_struct = await serialize_properties(opts, property_dependencies_resources)
    # TODO - actually implement
    outs = deserialize_properties(args_struct)
    return outs
    