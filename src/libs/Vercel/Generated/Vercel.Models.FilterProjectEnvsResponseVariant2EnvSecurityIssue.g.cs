
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvSecurityIssue
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
    public static class FilterProjectEnvsResponseVariant2EnvSecurityIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvSecurityIssue value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvSecurityIssue.FlagsSecretNeedsSplit => "flags-secret-needs-split",
                FilterProjectEnvsResponseVariant2EnvSecurityIssue.ReadableSecret => "readable-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvSecurityIssue? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret-needs-split" => FilterProjectEnvsResponseVariant2EnvSecurityIssue.FlagsSecretNeedsSplit,
                "readable-secret" => FilterProjectEnvsResponseVariant2EnvSecurityIssue.ReadableSecret,
                _ => null,
            };
        }
    }
}