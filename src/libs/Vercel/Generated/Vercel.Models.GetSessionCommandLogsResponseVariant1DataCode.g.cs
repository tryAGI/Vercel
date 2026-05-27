
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSessionCommandLogsResponseVariant1DataCode
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionCommandLogsResponseVariant1DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionCommandLogsResponseVariant1DataCode value)
        {
            return value switch
            {
                GetSessionCommandLogsResponseVariant1DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionCommandLogsResponseVariant1DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => GetSessionCommandLogsResponseVariant1DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}