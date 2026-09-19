
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2Visibility
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
    public static class RemoveProjectEnvResponseVariant2VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2Visibility value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2Visibility.Config => "config",
                RemoveProjectEnvResponseVariant2Visibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2Visibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => RemoveProjectEnvResponseVariant2Visibility.Config,
                "secret" => RemoveProjectEnvResponseVariant2Visibility.Secret,
                _ => null,
            };
        }
    }
}