
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "standard" => CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => CreateProjectResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}