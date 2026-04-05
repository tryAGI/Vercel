
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CancelDeploymentResponseConfigFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Fluid,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseConfigFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseConfigFunctionType value)
        {
            return value switch
            {
                CancelDeploymentResponseConfigFunctionType.Fluid => "fluid",
                CancelDeploymentResponseConfigFunctionType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseConfigFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "fluid" => CancelDeploymentResponseConfigFunctionType.Fluid,
                "standard" => CancelDeploymentResponseConfigFunctionType.Standard,
                _ => null,
            };
        }
    }
}