
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Billing mode. Always 'flat' for flat-rate projects.
    /// </summary>
    public enum AutoSDKSharedc1c2f92d02e0feb6UsageStatusKind
    {
        /// <summary>
        ///
        /// </summary>
        Flat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc1c2f92d02e0feb6UsageStatusKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc1c2f92d02e0feb6UsageStatusKind value)
        {
            return value switch
            {
                AutoSDKSharedc1c2f92d02e0feb6UsageStatusKind.Flat => "flat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc1c2f92d02e0feb6UsageStatusKind? ToEnum(string value)
        {
            return value switch
            {
                "flat" => AutoSDKSharedc1c2f92d02e0feb6UsageStatusKind.Flat,
                _ => null,
            };
        }
    }
}