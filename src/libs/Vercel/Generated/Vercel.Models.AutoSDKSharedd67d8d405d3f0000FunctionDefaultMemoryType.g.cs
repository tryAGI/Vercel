
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType
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
    public static class AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedd67d8d405d3f0000FunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}