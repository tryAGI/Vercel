
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Performance,
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
    public static class GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetProjectsResponseVariant1ItemResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}