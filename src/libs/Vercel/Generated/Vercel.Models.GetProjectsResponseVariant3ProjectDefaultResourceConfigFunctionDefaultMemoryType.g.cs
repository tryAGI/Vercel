
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetProjectsResponseVariant3ProjectDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}