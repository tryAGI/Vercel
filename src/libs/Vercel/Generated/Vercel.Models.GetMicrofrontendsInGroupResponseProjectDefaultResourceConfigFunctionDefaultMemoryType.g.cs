
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetMicrofrontendsInGroupResponseProjectDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}