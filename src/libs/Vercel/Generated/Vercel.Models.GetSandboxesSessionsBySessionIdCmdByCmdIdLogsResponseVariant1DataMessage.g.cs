
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessage
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamWasClosedAndIsNotAcceptingCommands,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessage value)
        {
            return value switch
            {
                GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands => "Sandbox stream was closed and is not accepting commands.",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessage? ToEnum(string value)
        {
            return value switch
            {
                "Sandbox stream was closed and is not accepting commands." => GetSandboxesSessionsBySessionIdCmdByCmdIdLogsResponseVariant1DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands,
                _ => null,
            };
        }
    }
}