
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The workload type of this sandbox.
    /// </summary>
    public enum NamedSandboxWorkloadType
    {
        /// <summary>
        ///
        /// </summary>
        Sandbox,
        /// <summary>
        ///
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NamedSandboxWorkloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NamedSandboxWorkloadType value)
        {
            return value switch
            {
                NamedSandboxWorkloadType.Sandbox => "sandbox",
                NamedSandboxWorkloadType.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NamedSandboxWorkloadType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox" => NamedSandboxWorkloadType.Sandbox,
                "v0" => NamedSandboxWorkloadType.V0,
                _ => null,
            };
        }
    }
}