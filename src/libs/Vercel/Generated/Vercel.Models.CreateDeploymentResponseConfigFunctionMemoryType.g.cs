
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseConfigFunctionMemoryType
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
    public static class CreateDeploymentResponseConfigFunctionMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseConfigFunctionMemoryType value)
        {
            return value switch
            {
                CreateDeploymentResponseConfigFunctionMemoryType.Performance => "performance",
                CreateDeploymentResponseConfigFunctionMemoryType.Standard => "standard",
                CreateDeploymentResponseConfigFunctionMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseConfigFunctionMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CreateDeploymentResponseConfigFunctionMemoryType.Performance,
                "standard" => CreateDeploymentResponseConfigFunctionMemoryType.Standard,
                "standard_legacy" => CreateDeploymentResponseConfigFunctionMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}