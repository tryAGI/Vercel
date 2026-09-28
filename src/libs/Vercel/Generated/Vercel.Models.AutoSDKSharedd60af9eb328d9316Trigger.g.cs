
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd60af9eb328d9316Trigger
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
    public static class AutoSDKSharedd60af9eb328d9316TriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd60af9eb328d9316Trigger value)
        {
            return value switch
            {
                AutoSDKSharedd60af9eb328d9316Trigger.Queue => "queue",
                AutoSDKSharedd60af9eb328d9316Trigger.Schedule => "schedule",
                AutoSDKSharedd60af9eb328d9316Trigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd60af9eb328d9316Trigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKSharedd60af9eb328d9316Trigger.Queue,
                "schedule" => AutoSDKSharedd60af9eb328d9316Trigger.Schedule,
                "workflow" => AutoSDKSharedd60af9eb328d9316Trigger.Workflow,
                _ => null,
            };
        }
    }
}