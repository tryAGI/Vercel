
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant2ConfigFunctionType
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
    public static class GetDeploymentResponseVariant2ConfigFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ConfigFunctionType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ConfigFunctionType.Fluid => "fluid",
                GetDeploymentResponseVariant2ConfigFunctionType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ConfigFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "fluid" => GetDeploymentResponseVariant2ConfigFunctionType.Fluid,
                "standard" => GetDeploymentResponseVariant2ConfigFunctionType.Standard,
                _ => null,
            };
        }
    }
}