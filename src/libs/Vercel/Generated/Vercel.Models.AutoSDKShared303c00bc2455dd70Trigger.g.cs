
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared303c00bc2455dd70Trigger
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
    public static class AutoSDKShared303c00bc2455dd70TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared303c00bc2455dd70Trigger value)
        {
            return value switch
            {
                AutoSDKShared303c00bc2455dd70Trigger.Queue => "queue",
                AutoSDKShared303c00bc2455dd70Trigger.Schedule => "schedule",
                AutoSDKShared303c00bc2455dd70Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared303c00bc2455dd70Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared303c00bc2455dd70Trigger.Queue,
                "schedule" => AutoSDKShared303c00bc2455dd70Trigger.Schedule,
                "workflow" => AutoSDKShared303c00bc2455dd70Trigger.Workflow,
                _ => null,
            };
        }
    }
}