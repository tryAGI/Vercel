
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UpdateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}