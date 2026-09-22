
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared268fc08d868dfab3SecurityIssue
    {
        /// <summary>
        ///
        /// </summary>
        FlagsSecretNeedsSplit,
        /// <summary>
        ///
        /// </summary>
        ReadableSecret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared268fc08d868dfab3SecurityIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared268fc08d868dfab3SecurityIssue value)
        {
            return value switch
            {
                AutoSDKShared268fc08d868dfab3SecurityIssue.FlagsSecretNeedsSplit => "flags-secret-needs-split",
                AutoSDKShared268fc08d868dfab3SecurityIssue.ReadableSecret => "readable-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared268fc08d868dfab3SecurityIssue? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret-needs-split" => AutoSDKShared268fc08d868dfab3SecurityIssue.FlagsSecretNeedsSplit,
                "readable-secret" => AutoSDKShared268fc08d868dfab3SecurityIssue.ReadableSecret,
                _ => null,
            };
        }
    }
}