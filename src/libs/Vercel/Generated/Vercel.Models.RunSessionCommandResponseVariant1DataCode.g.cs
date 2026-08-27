
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RunSessionCommandResponseVariant1DataCode
    {
        /// <summary>
        ///
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSessionCommandResponseVariant1DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSessionCommandResponseVariant1DataCode value)
        {
            return value switch
            {
                RunSessionCommandResponseVariant1DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSessionCommandResponseVariant1DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => RunSessionCommandResponseVariant1DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}