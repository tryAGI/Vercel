
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharede870b907cc1fb37eResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}