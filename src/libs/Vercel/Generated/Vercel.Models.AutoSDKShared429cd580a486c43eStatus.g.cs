
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eStatus value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eStatus.Completed => "completed",
                AutoSDKShared429cd580a486c43eStatus.Queued => "queued",
                AutoSDKShared429cd580a486c43eStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AutoSDKShared429cd580a486c43eStatus.Completed,
                "queued" => AutoSDKShared429cd580a486c43eStatus.Queued,
                "running" => AutoSDKShared429cd580a486c43eStatus.Running,
                _ => null,
            };
        }
    }
}