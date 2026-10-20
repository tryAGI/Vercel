
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared6bf801e26ecd75afDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}