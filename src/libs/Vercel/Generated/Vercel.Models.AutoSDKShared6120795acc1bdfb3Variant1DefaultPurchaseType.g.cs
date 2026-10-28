
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType
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
        None,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Basic => "basic",
                AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Enhanced => "enhanced",
                AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.None => "none",
                AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Basic,
                "enhanced" => AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Enhanced,
                "none" => AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.None,
                "standard" => AutoSDKShared6120795acc1bdfb3Variant1DefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}