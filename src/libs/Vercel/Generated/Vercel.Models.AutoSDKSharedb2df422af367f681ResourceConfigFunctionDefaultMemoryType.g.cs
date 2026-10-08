
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharedb2df422af367f681ResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}