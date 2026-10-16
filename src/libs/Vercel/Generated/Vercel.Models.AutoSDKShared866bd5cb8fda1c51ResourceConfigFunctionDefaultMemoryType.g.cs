
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared866bd5cb8fda1c51ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}