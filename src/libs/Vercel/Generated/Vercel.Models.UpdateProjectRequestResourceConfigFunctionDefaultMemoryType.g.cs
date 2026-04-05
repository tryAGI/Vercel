
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestResourceConfigFunctionDefaultMemoryType
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
    public static class UpdateProjectRequestResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UpdateProjectRequestResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}