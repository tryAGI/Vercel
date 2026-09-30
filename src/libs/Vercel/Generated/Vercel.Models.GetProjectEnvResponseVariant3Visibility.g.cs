
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum GetProjectEnvResponseVariant3Visibility
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
    public static class GetProjectEnvResponseVariant3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant3Visibility value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant3Visibility.Config => "config",
                GetProjectEnvResponseVariant3Visibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => GetProjectEnvResponseVariant3Visibility.Config,
                "secret" => GetProjectEnvResponseVariant3Visibility.Secret,
                _ => null,
            };
        }
    }
}