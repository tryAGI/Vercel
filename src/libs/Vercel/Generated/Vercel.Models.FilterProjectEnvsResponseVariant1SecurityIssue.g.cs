
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1SecurityIssue
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
    public static class FilterProjectEnvsResponseVariant1SecurityIssueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1SecurityIssue value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1SecurityIssue.FlagsSecretNeedsSplit => "flags-secret-needs-split",
                FilterProjectEnvsResponseVariant1SecurityIssue.ReadableSecret => "readable-secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1SecurityIssue? ToEnum(string value)
        {
            return value switch
            {
                "flags-secret-needs-split" => FilterProjectEnvsResponseVariant1SecurityIssue.FlagsSecretNeedsSplit,
                "readable-secret" => FilterProjectEnvsResponseVariant1SecurityIssue.ReadableSecret,
                _ => null,
            };
        }
    }
}