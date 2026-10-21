
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared0d52d5fc16437df8ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}