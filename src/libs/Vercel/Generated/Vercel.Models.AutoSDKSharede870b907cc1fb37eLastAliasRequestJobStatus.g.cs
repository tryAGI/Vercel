
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus
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
    public static class AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharede870b907cc1fb37eLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}