
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type purchased for this build.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant2PurchaseType
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        Enhanced,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6120795acc1bdfb3Variant2PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant2PurchaseType value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Basic => "basic",
                AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Enhanced => "enhanced",
                AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Standard => "standard",
                AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant2PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Basic,
                "enhanced" => AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Enhanced,
                "standard" => AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Standard,
                "turbo" => AutoSDKShared6120795acc1bdfb3Variant2PurchaseType.Turbo,
                _ => null,
            };
        }
    }
}