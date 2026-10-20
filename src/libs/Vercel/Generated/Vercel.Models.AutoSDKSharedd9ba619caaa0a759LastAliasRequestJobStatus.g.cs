
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InProgress,
        /// <summary>
        ///
        /// </summary>
        Pending,
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
    public static class AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedd9ba619caaa0a759LastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}