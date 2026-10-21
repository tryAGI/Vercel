
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared03f29e765d13306dTrigger
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
    public static class AutoSDKShared03f29e765d13306dTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared03f29e765d13306dTrigger value)
        {
            return value switch
            {
                AutoSDKShared03f29e765d13306dTrigger.Queue => "queue",
                AutoSDKShared03f29e765d13306dTrigger.Schedule => "schedule",
                AutoSDKShared03f29e765d13306dTrigger.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared03f29e765d13306dTrigger? ToEnum(string value)
        {
            return value switch
            {
                "queue" => AutoSDKShared03f29e765d13306dTrigger.Queue,
                "schedule" => AutoSDKShared03f29e765d13306dTrigger.Schedule,
                "workflow" => AutoSDKShared03f29e765d13306dTrigger.Workflow,
                _ => null,
            };
        }
    }
}