
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeploymentResponseVariant2ConfigFunctionMemoryType
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
    public static class GetDeploymentResponseVariant2ConfigFunctionMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ConfigFunctionMemoryType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ConfigFunctionMemoryType.Performance => "performance",
                GetDeploymentResponseVariant2ConfigFunctionMemoryType.PerformanceXl => "performance_xl",
                GetDeploymentResponseVariant2ConfigFunctionMemoryType.Standard => "standard",
                GetDeploymentResponseVariant2ConfigFunctionMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ConfigFunctionMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetDeploymentResponseVariant2ConfigFunctionMemoryType.Performance,
                "performance_xl" => GetDeploymentResponseVariant2ConfigFunctionMemoryType.PerformanceXl,
                "standard" => GetDeploymentResponseVariant2ConfigFunctionMemoryType.Standard,
                "standard_legacy" => GetDeploymentResponseVariant2ConfigFunctionMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}