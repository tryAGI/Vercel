
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eConclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Neutral,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
        /// <summary>
        ///
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eConclusion value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eConclusion.Canceled => "canceled",
                AutoSDKShared429cd580a486c43eConclusion.Failed => "failed",
                AutoSDKShared429cd580a486c43eConclusion.Neutral => "neutral",
                AutoSDKShared429cd580a486c43eConclusion.Skipped => "skipped",
                AutoSDKShared429cd580a486c43eConclusion.Succeeded => "succeeded",
                AutoSDKShared429cd580a486c43eConclusion.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared429cd580a486c43eConclusion.Canceled,
                "failed" => AutoSDKShared429cd580a486c43eConclusion.Failed,
                "neutral" => AutoSDKShared429cd580a486c43eConclusion.Neutral,
                "skipped" => AutoSDKShared429cd580a486c43eConclusion.Skipped,
                "succeeded" => AutoSDKShared429cd580a486c43eConclusion.Succeeded,
                "timeout" => AutoSDKShared429cd580a486c43eConclusion.Timeout,
                _ => null,
            };
        }
    }
}