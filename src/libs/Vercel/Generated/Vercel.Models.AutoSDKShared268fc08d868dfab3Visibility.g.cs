
#nullable enable

namespace Vercel
{
    /// <summary>
    /// User-facing config/secret model. When set, authoritative for new code paths. Legacy rows omit this field and callers fall back to existing `type` behavior.
    /// </summary>
    public enum AutoSDKShared268fc08d868dfab3Visibility
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
    public static class AutoSDKShared268fc08d868dfab3VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared268fc08d868dfab3Visibility value)
        {
            return value switch
            {
                AutoSDKShared268fc08d868dfab3Visibility.Config => "config",
                AutoSDKShared268fc08d868dfab3Visibility.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared268fc08d868dfab3Visibility? ToEnum(string value)
        {
            return value switch
            {
                "config" => AutoSDKShared268fc08d868dfab3Visibility.Config,
                "secret" => AutoSDKShared268fc08d868dfab3Visibility.Secret,
                _ => null,
            };
        }
    }
}