
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseConfigFunctionMemoryType
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
    public static class CancelDeploymentResponseConfigFunctionMemoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseConfigFunctionMemoryType value)
        {
            return value switch
            {
                CancelDeploymentResponseConfigFunctionMemoryType.Performance => "performance",
                CancelDeploymentResponseConfigFunctionMemoryType.Standard => "standard",
                CancelDeploymentResponseConfigFunctionMemoryType.StandardLegacy => "standard_legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseConfigFunctionMemoryType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CancelDeploymentResponseConfigFunctionMemoryType.Performance,
                "standard" => CancelDeploymentResponseConfigFunctionMemoryType.Standard,
                "standard_legacy" => CancelDeploymentResponseConfigFunctionMemoryType.StandardLegacy,
                _ => null,
            };
        }
    }
}