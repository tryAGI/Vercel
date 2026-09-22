
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum AutoSDKShared470bc56668090392Visibility
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
    public static class AutoSDKShared470bc56668090392VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared470bc56668090392Visibility value)
        {
            return value switch
            {
                AutoSDKShared470bc56668090392Visibility.Config => "config",
                AutoSDKShared470bc56668090392Visibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared470bc56668090392Visibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => AutoSDKShared470bc56668090392Visibility.Config,
                "secret" => AutoSDKShared470bc56668090392Visibility.Secret,
                _ => null,
            };
        }
    }
}