
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedc9c79e81839bbccdResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}