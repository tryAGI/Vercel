
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Performance,
        /// <summary>
        /// 
        /// </summary>
        PerformanceXl,
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
    public static class UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UploadProjectAvatarResponseResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}