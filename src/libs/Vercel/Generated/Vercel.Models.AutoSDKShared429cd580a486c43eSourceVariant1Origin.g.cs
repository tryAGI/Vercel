
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eSourceVariant1Origin
    {
        /// <summary>
        ///
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eSourceVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eSourceVariant1Origin value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eSourceVariant1Origin.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eSourceVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "config" => AutoSDKShared429cd580a486c43eSourceVariant1Origin.Config,
                _ => null,
            };
        }
    }
}