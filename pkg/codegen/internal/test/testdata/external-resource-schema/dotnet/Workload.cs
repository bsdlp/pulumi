// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Example
{
    [ExampleResourceType("example::Workload")]
    public partial class Workload : Pulumi.CustomResource
    {
        [Output("pod")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Core.V1.Pod?> Pod { get; private set; } = null!;


        /// <summary>
        /// Create a Workload resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workload(string name, WorkloadArgs? args = null, CustomResourceOptions? options = null)
            : base("example::Workload", name, args ?? new WorkloadArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workload(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("example::Workload", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workload resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workload Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workload(name, id, options);
        }
    }

    public sealed class WorkloadArgs : Pulumi.ResourceArgs
    {
        public WorkloadArgs()
        {
        }
    }
}
