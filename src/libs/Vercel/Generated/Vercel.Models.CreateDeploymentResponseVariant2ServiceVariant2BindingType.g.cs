
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ServiceVariant2BindingType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ServiceVariant2BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ServiceVariant2BindingType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ServiceVariant2BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ServiceVariant2BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => CreateDeploymentResponseVariant2ServiceVariant2BindingType.Service,
                _ => null,
            };
        }
    }
}