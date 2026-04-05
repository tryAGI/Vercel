
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ConfigFunctionMemoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Performance,
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
    public static class GetDeploymentResponseVariant1ConfigFunctionMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ConfigFunctionMemoryType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ConfigFunctionMemoryType.Performance => "performance",
                GetDeploymentResponseVariant1ConfigFunctionMemoryType.Standard => "standard",
                GetDeploymentResponseVariant1ConfigFunctionMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ConfigFunctionMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => GetDeploymentResponseVariant1ConfigFunctionMemoryType.Performance,
                "standard" => GetDeploymentResponseVariant1ConfigFunctionMemoryType.Standard,
                "standard_legacy" => GetDeploymentResponseVariant1ConfigFunctionMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}