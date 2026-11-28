
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSessionCommandLogsResponseVariant2DataCode
    {
        /// <summary>
        ///
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionCommandLogsResponseVariant2DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionCommandLogsResponseVariant2DataCode value)
        {
            return value switch
            {
                GetSessionCommandLogsResponseVariant2DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionCommandLogsResponseVariant2DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => GetSessionCommandLogsResponseVariant2DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}