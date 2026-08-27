
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths when the env-var-config-secret-ui flag is enabled. Legacy rows omit this field; legacy rows omit it and callers fall back to existing `type` behavior.
    /// </summary>
    public enum FilterProjectEnvsResponseVariant1Visibility
    {
        /// <summary>
        ///
        /// </summary>
        Config,
        /// <summary>
        ///
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterProjectEnvsResponseVariant1VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant1Visibility value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant1Visibility.Config => "config",
                FilterProjectEnvsResponseVariant1Visibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant1Visibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => FilterProjectEnvsResponseVariant1Visibility.Config,
                "secret" => FilterProjectEnvsResponseVariant1Visibility.Secret,
                _ => null,
            };
        }
    }
}