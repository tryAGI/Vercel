
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvSecurityIssue
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
    public static class FilterProjectEnvsResponseVariant3EnvSecurityIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvSecurityIssue value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvSecurityIssue.FlagsSecretNeedsSplit => "flags-secret-needs-split",
                FilterProjectEnvsResponseVariant3EnvSecurityIssue.ReadableSecret => "readable-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvSecurityIssue? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret-needs-split" => FilterProjectEnvsResponseVariant3EnvSecurityIssue.FlagsSecretNeedsSplit,
                "readable-secret" => FilterProjectEnvsResponseVariant3EnvSecurityIssue.ReadableSecret,
                _ => null,
            };
        }
    }
}