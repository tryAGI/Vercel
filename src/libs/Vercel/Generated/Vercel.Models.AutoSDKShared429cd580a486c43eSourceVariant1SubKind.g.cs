
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared429cd580a486c43eSourceVariant1SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared429cd580a486c43eSourceVariant1SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared429cd580a486c43eSourceVariant1SubKind value)
        {
            return value switch
            {
                AutoSDKShared429cd580a486c43eSourceVariant1SubKind.VercelCi => "vercel-ci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared429cd580a486c43eSourceVariant1SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci" => AutoSDKShared429cd580a486c43eSourceVariant1SubKind.VercelCi,
                _ => null,
            };
        }
    }
}