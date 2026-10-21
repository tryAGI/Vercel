
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type purchased for this build. `basic` is the 2vCPU tier, recorded so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant1PurchaseType
    {
        /// <summary>
        ///
        /// </summary>
        x14cpu28gb,
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
    public static class AutoSDKShared24b8e64f7956d798Variant1PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant1PurchaseType value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant1PurchaseType.x14cpu28gb => "14cpu-28gb",
                AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Basic => "basic",
                AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Enhanced => "enhanced",
                AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Standard => "standard",
                AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant1PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "14cpu-28gb" => AutoSDKShared24b8e64f7956d798Variant1PurchaseType.x14cpu28gb,
                "basic" => AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Basic,
                "enhanced" => AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Enhanced,
                "standard" => AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Standard,
                "turbo" => AutoSDKShared24b8e64f7956d798Variant1PurchaseType.Turbo,
                _ => null,
            };
        }
    }
}