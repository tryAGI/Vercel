
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus
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
    public static class AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Failed => "failed",
                AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.InProgress => "in-progress",
                AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Pending => "pending",
                AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Skipped => "skipped",
                AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Failed,
                "in-progress" => AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.InProgress,
                "pending" => AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Pending,
                "skipped" => AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Skipped,
                "succeeded" => AutoSDKShared6bf801e26ecd75afLastAliasRequestJobStatus.Succeeded,
                _ => null,
            };
        }
    }
}