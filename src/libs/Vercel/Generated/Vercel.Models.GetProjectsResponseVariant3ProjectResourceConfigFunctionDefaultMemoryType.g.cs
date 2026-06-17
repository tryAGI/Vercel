
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType
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
    public static class GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetProjectsResponseVariant3ProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}