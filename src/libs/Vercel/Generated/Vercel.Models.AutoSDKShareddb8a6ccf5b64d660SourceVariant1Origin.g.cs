
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareddb8a6ccf5b64d660SourceVariant1Origin
    {
        /// <summary>
        ///
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareddb8a6ccf5b64d660SourceVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareddb8a6ccf5b64d660SourceVariant1Origin value)
        {
            return value switch
            {
                AutoSDKShareddb8a6ccf5b64d660SourceVariant1Origin.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareddb8a6ccf5b64d660SourceVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "config" => AutoSDKShareddb8a6ccf5b64d660SourceVariant1Origin.Config,
                _ => null,
            };
        }
    }
}