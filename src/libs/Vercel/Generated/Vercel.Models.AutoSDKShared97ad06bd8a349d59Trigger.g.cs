
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared97ad06bd8a349d59Trigger
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
    public static class AutoSDKShared97ad06bd8a349d59TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared97ad06bd8a349d59Trigger value)
        {
            return value switch
            {
                AutoSDKShared97ad06bd8a349d59Trigger.Queue => "queue",
                AutoSDKShared97ad06bd8a349d59Trigger.Schedule => "schedule",
                AutoSDKShared97ad06bd8a349d59Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared97ad06bd8a349d59Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared97ad06bd8a349d59Trigger.Queue,
                "schedule" => AutoSDKShared97ad06bd8a349d59Trigger.Schedule,
                "workflow" => AutoSDKShared97ad06bd8a349d59Trigger.Workflow,
                _ => null,
            };
        }
    }
}