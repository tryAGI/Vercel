
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared32260c85dfc16e39Trigger
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
    public static class AutoSDKShared32260c85dfc16e39TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared32260c85dfc16e39Trigger value)
        {
            return value switch
            {
                AutoSDKShared32260c85dfc16e39Trigger.Queue => "queue",
                AutoSDKShared32260c85dfc16e39Trigger.Schedule => "schedule",
                AutoSDKShared32260c85dfc16e39Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared32260c85dfc16e39Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared32260c85dfc16e39Trigger.Queue,
                "schedule" => AutoSDKShared32260c85dfc16e39Trigger.Schedule,
                "workflow" => AutoSDKShared32260c85dfc16e39Trigger.Workflow,
                _ => null,
            };
        }
    }
}