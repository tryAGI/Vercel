
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths when the env-var-config-secret-ui flag is enabled. Legacy rows omit this field; legacy rows omit it and callers fall back to existing `type` behavior.
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvVisibility
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
    public static class FilterProjectEnvsResponseVariant3EnvVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvVisibility value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvVisibility.Config => "config",
                FilterProjectEnvsResponseVariant3EnvVisibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvVisibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => FilterProjectEnvsResponseVariant3EnvVisibility.Config,
                "secret" => FilterProjectEnvsResponseVariant3EnvVisibility.Secret,
                _ => null,
            };
        }
    }
}