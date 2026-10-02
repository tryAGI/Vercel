
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKShared949b4255932cb64aResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}