
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bbdd9b0474e1d24Trigger
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
    public static class AutoSDKShared6bbdd9b0474e1d24TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bbdd9b0474e1d24Trigger value)
        {
            return value switch
            {
                AutoSDKShared6bbdd9b0474e1d24Trigger.Queue => "queue",
                AutoSDKShared6bbdd9b0474e1d24Trigger.Schedule => "schedule",
                AutoSDKShared6bbdd9b0474e1d24Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bbdd9b0474e1d24Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared6bbdd9b0474e1d24Trigger.Queue,
                "schedule" => AutoSDKShared6bbdd9b0474e1d24Trigger.Schedule,
                "workflow" => AutoSDKShared6bbdd9b0474e1d24Trigger.Workflow,
                _ => null,
            };
        }
    }
}