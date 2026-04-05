
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType
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
    public static class UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UpdateMicrofrontendsResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}