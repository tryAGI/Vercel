
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType
    {
        /// <summary>
        ///
        /// </summary>
        Performance,
        /// <summary>
        ///
        /// </summary>
        PerformanceXl,
        /// <summary>
        ///
        /// </summary>
        Standard,
        /// <summary>
        ///
        /// </summary>
        StandardLegacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShareda223f19b9c37327fResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}