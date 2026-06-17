
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => UploadProjectAvatarResponseDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}