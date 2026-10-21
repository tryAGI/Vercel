
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type purchased for this build.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant2PurchaseType
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
    public static class AutoSDKShared24b8e64f7956d798Variant2PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant2PurchaseType value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Basic => "basic",
                AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Enhanced => "enhanced",
                AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Standard => "standard",
                AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant2PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Basic,
                "enhanced" => AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Enhanced,
                "standard" => AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Standard,
                "turbo" => AutoSDKShared24b8e64f7956d798Variant2PurchaseType.Turbo,
                _ => null,
            };
        }
    }
}