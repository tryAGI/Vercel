
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType
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
    public static class AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShareda38de73cc9e23e17FunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}