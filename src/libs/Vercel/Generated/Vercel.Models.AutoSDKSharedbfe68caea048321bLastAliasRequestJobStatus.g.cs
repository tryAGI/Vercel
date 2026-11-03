
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus
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
    public static class AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKSharedbfe68caea048321bLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}