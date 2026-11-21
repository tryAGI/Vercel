
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum RunSessionCommandResponseVariant3DataMessage
    {
        /// <summary>
        ///
        /// </summary>
        SandboxStreamWasClosedAndIsNotAcceptingCommands,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunSessionCommandResponseVariant3DataMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunSessionCommandResponseVariant3DataMessage value)
        {
            return value switch
            {
                RunSessionCommandResponseVariant3DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands => "Sandbox stream was closed and is not accepting commands.",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunSessionCommandResponseVariant3DataMessage? ToEnum(string value)
        {
            return value switch
            {
                "Sandbox stream was closed and is not accepting commands." => RunSessionCommandResponseVariant3DataMessage.SandboxStreamWasClosedAndIsNotAcceptingCommands,
                _ => null,
            };
        }
    }
}