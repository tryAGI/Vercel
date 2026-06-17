
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}