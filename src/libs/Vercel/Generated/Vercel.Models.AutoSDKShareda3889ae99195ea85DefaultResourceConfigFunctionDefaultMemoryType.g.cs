
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShareda3889ae99195ea85DefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}