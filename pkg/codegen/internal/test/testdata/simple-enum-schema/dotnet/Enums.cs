// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi.Serialization;

namespace Pulumi.PlantProvider
{
    [EnumType]
    public readonly struct ContainerBrightness : IEquatable<ContainerBrightness>
    {
        private readonly double _value;

        private ContainerBrightness(double value)
        {
            _value = value;
        }

        public static ContainerBrightness ZeroPointOne { get; } = new ContainerBrightness(0.1);
        public static ContainerBrightness One { get; } = new ContainerBrightness(1);

        public static bool operator ==(ContainerBrightness left, ContainerBrightness right) => left.Equals(right);
        public static bool operator !=(ContainerBrightness left, ContainerBrightness right) => !left.Equals(right);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerBrightness other && Equals(other);
        public bool Equals(ContainerBrightness other) => _value == other._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode();

        public override string ToString() => _value.ToString();
    }

    /// <summary>
    /// plant container colors
    /// </summary>
    [EnumType]
    public readonly struct ContainerColor : IEquatable<ContainerColor>
    {
        private readonly string _value;

        private ContainerColor(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ContainerColor Red { get; } = new ContainerColor("red");
        public static ContainerColor Blue { get; } = new ContainerColor("blue");
        public static ContainerColor Yellow { get; } = new ContainerColor("yellow");

        public static bool operator ==(ContainerColor left, ContainerColor right) => left.Equals(right);
        public static bool operator !=(ContainerColor left, ContainerColor right) => !left.Equals(right);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerColor other && Equals(other);
        public bool Equals(ContainerColor other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// plant container sizes
    /// </summary>
    public enum ContainerSize
    {
        FourInch = 4,
        SixInch = 6,
        [Obsolete(@"Eight inch pots are no longer supported.")]
        EightInch = 8,
    }
}
