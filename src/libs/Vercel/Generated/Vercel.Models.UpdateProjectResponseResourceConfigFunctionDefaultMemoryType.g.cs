
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseResourceConfigFunctionDefaultMemoryType
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
    public static class UpdateProjectResponseResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UpdateProjectResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}