
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectRequestResourceConfigFunctionDefaultMemoryType
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
    public static class CreateProjectRequestResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                CreateProjectRequestResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                CreateProjectRequestResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                CreateProjectRequestResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CreateProjectRequestResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => CreateProjectRequestResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => CreateProjectRequestResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}