
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedfe1f84289679c6c4ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}