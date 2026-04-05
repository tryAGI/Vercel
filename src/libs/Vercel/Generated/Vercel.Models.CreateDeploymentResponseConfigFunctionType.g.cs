
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentResponseConfigFunctionType
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
    public static class CreateDeploymentResponseConfigFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseConfigFunctionType value)
        {
            return value switch
            {
                CreateDeploymentResponseConfigFunctionType.Fluid => "fluid",
                CreateDeploymentResponseConfigFunctionType.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseConfigFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "fluid" => CreateDeploymentResponseConfigFunctionType.Fluid,
                "standard" => CreateDeploymentResponseConfigFunctionType.Standard,
                _ => null,
            };
        }
    }
}