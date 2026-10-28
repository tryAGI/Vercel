
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Machine type purchased for this build. `basic` is the 2vCPU tier, recorded so the build pipeline can detect a basic build without consulting the project.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant1PurchaseType
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
    public static class AutoSDKShared6120795acc1bdfb3Variant1PurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant1PurchaseType value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.x14cpu28gb => "14cpu-28gb",
                AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Basic => "basic",
                AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Enhanced => "enhanced",
                AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Standard => "standard",
                AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant1PurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "14cpu-28gb" => AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.x14cpu28gb,
                "basic" => AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Basic,
                "enhanced" => AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Enhanced,
                "standard" => AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Standard,
                "turbo" => AutoSDKShared6120795acc1bdfb3Variant1PurchaseType.Turbo,
                _ => null,
            };
        }
    }
}