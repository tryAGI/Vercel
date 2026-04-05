
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCommandLogsResponseVariant1DataCode
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCommandLogsResponseVariant1DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCommandLogsResponseVariant1DataCode value)
        {
            return value switch
            {
                GetCommandLogsResponseVariant1DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCommandLogsResponseVariant1DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => GetCommandLogsResponseVariant1DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}