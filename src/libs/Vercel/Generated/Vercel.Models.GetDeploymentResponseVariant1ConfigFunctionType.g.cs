
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1ConfigFunctionType
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
    public static class GetDeploymentResponseVariant1ConfigFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ConfigFunctionType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ConfigFunctionType.Fluid => "fluid",
                GetDeploymentResponseVariant1ConfigFunctionType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ConfigFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "fluid" => GetDeploymentResponseVariant1ConfigFunctionType.Fluid,
                "standard" => GetDeploymentResponseVariant1ConfigFunctionType.Standard,
                _ => null,
            };
        }
    }
}