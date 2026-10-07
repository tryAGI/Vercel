
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc2e5e8d31dd98e94Trigger
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
    public static class AutoSDKSharedc2e5e8d31dd98e94TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc2e5e8d31dd98e94Trigger value)
        {
            return value switch
            {
                AutoSDKSharedc2e5e8d31dd98e94Trigger.Queue => "queue",
                AutoSDKSharedc2e5e8d31dd98e94Trigger.Schedule => "schedule",
                AutoSDKSharedc2e5e8d31dd98e94Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc2e5e8d31dd98e94Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKSharedc2e5e8d31dd98e94Trigger.Queue,
                "schedule" => AutoSDKSharedc2e5e8d31dd98e94Trigger.Schedule,
                "workflow" => AutoSDKSharedc2e5e8d31dd98e94Trigger.Workflow,
                _ => null,
            };
        }
    }
}