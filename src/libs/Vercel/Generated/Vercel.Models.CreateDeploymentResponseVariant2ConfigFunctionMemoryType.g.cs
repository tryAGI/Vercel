
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDeploymentResponseVariant2ConfigFunctionMemoryType
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
    public static class CreateDeploymentResponseVariant2ConfigFunctionMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ConfigFunctionMemoryType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ConfigFunctionMemoryType.Performance => "performance",
                CreateDeploymentResponseVariant2ConfigFunctionMemoryType.PerformanceXl => "performance_xl",
                CreateDeploymentResponseVariant2ConfigFunctionMemoryType.Standard => "standard",
                CreateDeploymentResponseVariant2ConfigFunctionMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ConfigFunctionMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CreateDeploymentResponseVariant2ConfigFunctionMemoryType.Performance,
                "performance_xl" => CreateDeploymentResponseVariant2ConfigFunctionMemoryType.PerformanceXl,
                "standard" => CreateDeploymentResponseVariant2ConfigFunctionMemoryType.Standard,
                "standard_legacy" => CreateDeploymentResponseVariant2ConfigFunctionMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}