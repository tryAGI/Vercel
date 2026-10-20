
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared78bd7b18568312c4Trigger
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
    public static class AutoSDKShared78bd7b18568312c4TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared78bd7b18568312c4Trigger value)
        {
            return value switch
            {
                AutoSDKShared78bd7b18568312c4Trigger.Queue => "queue",
                AutoSDKShared78bd7b18568312c4Trigger.Schedule => "schedule",
                AutoSDKShared78bd7b18568312c4Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared78bd7b18568312c4Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared78bd7b18568312c4Trigger.Queue,
                "schedule" => AutoSDKShared78bd7b18568312c4Trigger.Schedule,
                "workflow" => AutoSDKShared78bd7b18568312c4Trigger.Workflow,
                _ => null,
            };
        }
    }
}