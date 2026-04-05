
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType
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
    public static class GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetProjectsResponseVariant2ProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}