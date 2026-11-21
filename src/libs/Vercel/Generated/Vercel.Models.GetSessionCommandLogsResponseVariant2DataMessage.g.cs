
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSessionCommandLogsResponseVariant2DataMessage
    {
        /// <summary>
        ///
        /// </summary>
        SandboxStreamWasClosedAndIsNotAcceptingCommands,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionCommandLogsResponseVariant2DataMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionCommandLogsResponseVariant2DataMessage value)
        {
            return value switch
            {
                GetSessionCommandLogsResponseVariant2DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands => "Sandbox stream was closed and is not accepting commands.",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionCommandLogsResponseVariant2DataMessage? ToEnum(string value)
        {
            return value switch
            {
                "Sandbox stream was closed and is not accepting commands." => GetSessionCommandLogsResponseVariant2DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands,
                _ => null,
            };
        }
    }
}