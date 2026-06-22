
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum GetDeploymentResponseVariant1ServiceVariant2BindingType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1ServiceVariant2BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ServiceVariant2BindingType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ServiceVariant2BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ServiceVariant2BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => GetDeploymentResponseVariant1ServiceVariant2BindingType.Service,
                _ => null,
            };
        }
    }
}