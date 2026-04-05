
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCommandLogsResponseVariant1DataMessage
    {
        /// <summary>
        /// 
        /// </summary>
        SandboxStreamWasClosedAndIsNotAcceptingCommands,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCommandLogsResponseVariant1DataMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCommandLogsResponseVariant1DataMessage value)
        {
            return value switch
            {
                GetCommandLogsResponseVariant1DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands => "Sandbox stream was closed and is not accepting commands.",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCommandLogsResponseVariant1DataMessage? ToEnum(string value)
        {
            return value switch
            {
                "Sandbox stream was closed and is not accepting commands." => GetCommandLogsResponseVariant1DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands,
                _ => null,
            };
        }
    }
}