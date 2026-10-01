
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType
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
    public static class AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType value)
        {
            return value switch
            {
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.Performance => "performance",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl => "performance_xl",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.Standard => "standard",
                AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.Performance,
                "performance_xl" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.PerformanceXl,
                "standard" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.Standard,
                "standard_legacy" => AutoSDKSharede27e7ff1aa86f19eDefaultResourceConfigFunctionDefaultMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}