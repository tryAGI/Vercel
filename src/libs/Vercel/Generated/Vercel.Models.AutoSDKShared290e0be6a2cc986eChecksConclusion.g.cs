
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared290e0be6a2cc986eChecksConclusion
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
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared290e0be6a2cc986eChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared290e0be6a2cc986eChecksConclusion value)
        {
            return value switch
            {
                AutoSDKShared290e0be6a2cc986eChecksConclusion.Canceled => "canceled",
                AutoSDKShared290e0be6a2cc986eChecksConclusion.Failed => "failed",
                AutoSDKShared290e0be6a2cc986eChecksConclusion.Skipped => "skipped",
                AutoSDKShared290e0be6a2cc986eChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared290e0be6a2cc986eChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKShared290e0be6a2cc986eChecksConclusion.Canceled,
                "failed" => AutoSDKShared290e0be6a2cc986eChecksConclusion.Failed,
                "skipped" => AutoSDKShared290e0be6a2cc986eChecksConclusion.Skipped,
                "succeeded" => AutoSDKShared290e0be6a2cc986eChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}