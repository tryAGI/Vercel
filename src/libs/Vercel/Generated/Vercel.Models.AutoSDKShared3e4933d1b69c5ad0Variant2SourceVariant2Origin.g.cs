
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2Origin
    {
        /// <summary>
        ///
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2Origin value)
        {
            return value switch
            {
                AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2Origin.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2Origin? ToEnum(string value)
        {
            return value switch
            {
                "platform" => AutoSDKShared3e4933d1b69c5ad0Variant2SourceVariant2Origin.Platform,
                _ => null,
            };
        }
    }
}