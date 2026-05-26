
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCode
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCode value)
        {
            return value switch
            {
                GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCode.SandboxStreamClosed => "sandbox_stream_closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCode? ToEnum(string value)
        {
            return value switch
            {
                "sandbox_stream_closed" => GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataCode.SandboxStreamClosed,
                _ => null,
            };
        }
    }
}