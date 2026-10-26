
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The workload type of this sandbox.
    /// </summary>
    public enum SessionWorkloadType
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
    public static class SessionWorkloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionWorkloadType value)
        {
            return value switch
            {
                SessionWorkloadType.Sandbox => "sandbox",
                SessionWorkloadType.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionWorkloadType? ToEnum(string value)
        {
            return value switch
            {
                "sandbox" => SessionWorkloadType.Sandbox,
                "v0" => SessionWorkloadType.V0,
                _ => null,
            };
        }
    }
}