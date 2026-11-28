
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0b04f80869bc5cc2Trigger
    {
        /// <summary>
        ///
        /// </summary>
        Queue,
        /// <summary>
        ///
        /// </summary>
        Schedule,
        /// <summary>
        ///
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0b04f80869bc5cc2TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0b04f80869bc5cc2Trigger value)
        {
            return value switch
            {
                AutoSDKShared0b04f80869bc5cc2Trigger.Queue => "queue",
                AutoSDKShared0b04f80869bc5cc2Trigger.Schedule => "schedule",
                AutoSDKShared0b04f80869bc5cc2Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0b04f80869bc5cc2Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared0b04f80869bc5cc2Trigger.Queue,
                "schedule" => AutoSDKShared0b04f80869bc5cc2Trigger.Schedule,
                "workflow" => AutoSDKShared0b04f80869bc5cc2Trigger.Workflow,
                _ => null,
            };
        }
    }
}