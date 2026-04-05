
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType
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
    public static class GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => GetMicrofrontendsInGroupResponseProjectResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}