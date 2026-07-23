
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseVariant2ConfigFunctionType
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
    public static class CreateDeploymentResponseVariant2ConfigFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ConfigFunctionType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ConfigFunctionType.Fluid => "fluid",
                CreateDeploymentResponseVariant2ConfigFunctionType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ConfigFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "fluid" => CreateDeploymentResponseVariant2ConfigFunctionType.Fluid,
                "standard" => CreateDeploymentResponseVariant2ConfigFunctionType.Standard,
                _ => null,
            };
        }
    }
}