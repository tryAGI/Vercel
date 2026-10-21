
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build machine tier included with the customer's plan. For most customers this is standard; enhanced entitlements include enhanced, while `none` means every build is billed at its purchase type.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType
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
    public static class AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Basic => "basic",
                AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Enhanced => "enhanced",
                AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.None => "none",
                AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Basic,
                "enhanced" => AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Enhanced,
                "none" => AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.None,
                "standard" => AutoSDKShared24b8e64f7956d798Variant2DefaultPurchaseType.Standard,
                _ => null,
            };
        }
    }
}