// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi.Serialization;

namespace Pulumi.PlantProvider.Tree.V1
{
    [EnumType]
    public readonly struct Farm : IEquatable<Farm>
    {
        private readonly string _value;

        private Farm(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static Farm Pulumi_Planters_Inc_ { get; } = new Farm("Pulumi Planters Inc.");
        public static Farm Plants_R_Us { get; } = new Farm("Plants'R'Us");

        public static bool operator ==(Farm left, Farm right) => left.Equals(right);
        public static bool operator !=(Farm left, Farm right) => !left.Equals(right);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Farm other && Equals(other);
        public bool Equals(Farm other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// types of rubber trees
    /// </summary>
    [EnumType]
    public readonly struct RubberTreeVariety : IEquatable<RubberTreeVariety>
    {
        private readonly string _value;

        private RubberTreeVariety(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// A burgundy rubber tree.
        /// </summary>
        public static RubberTreeVariety Burgundy { get; } = new RubberTreeVariety("Burgundy");
        /// <summary>
        /// A ruby rubber tree.
        /// </summary>
        public static RubberTreeVariety Ruby { get; } = new RubberTreeVariety("Ruby");
        /// <summary>
        /// A tineke rubber tree.
        /// </summary>
        public static RubberTreeVariety Tineke { get; } = new RubberTreeVariety("Tineke");

        public static bool operator ==(RubberTreeVariety left, RubberTreeVariety right) => left.Equals(right);
        public static bool operator !=(RubberTreeVariety left, RubberTreeVariety right) => !left.Equals(right);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is RubberTreeVariety other && Equals(other);
        public bool Equals(RubberTreeVariety other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
