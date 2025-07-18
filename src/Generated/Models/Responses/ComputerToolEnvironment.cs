// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using OpenAI;

namespace OpenAI.Responses
{
    [Experimental("OPENAICUA001")]
    public readonly partial struct ComputerToolEnvironment : IEquatable<ComputerToolEnvironment>
    {
        private readonly string _value;
        private const string WindowsValue = "windows";
        private const string MacValue = "mac";
        private const string LinuxValue = "linux";
        private const string UbuntuValue = "ubuntu";
        private const string BrowserValue = "browser";

        public ComputerToolEnvironment(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static ComputerToolEnvironment Windows { get; } = new ComputerToolEnvironment(WindowsValue);

        public static ComputerToolEnvironment Mac { get; } = new ComputerToolEnvironment(MacValue);

        public static ComputerToolEnvironment Linux { get; } = new ComputerToolEnvironment(LinuxValue);

        public static ComputerToolEnvironment Ubuntu { get; } = new ComputerToolEnvironment(UbuntuValue);

        public static ComputerToolEnvironment Browser { get; } = new ComputerToolEnvironment(BrowserValue);

        public static bool operator ==(ComputerToolEnvironment left, ComputerToolEnvironment right) => left.Equals(right);

        public static bool operator !=(ComputerToolEnvironment left, ComputerToolEnvironment right) => !left.Equals(right);

        public static implicit operator ComputerToolEnvironment(string value) => new ComputerToolEnvironment(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputerToolEnvironment other && Equals(other);

        public bool Equals(ComputerToolEnvironment other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
