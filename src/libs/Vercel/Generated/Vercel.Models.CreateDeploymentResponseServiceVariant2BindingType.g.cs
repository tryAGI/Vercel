
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `"service"` for Service-to-Service HTTP bindings.
    /// </summary>
    public enum CreateDeploymentResponseServiceVariant2BindingType
    {
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseServiceVariant2BindingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseServiceVariant2BindingType value)
        {
            return value switch
            {
                CreateDeploymentResponseServiceVariant2BindingType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseServiceVariant2BindingType? ToEnum(string value)
        {
            return value switch
            {
                "service" => CreateDeploymentResponseServiceVariant2BindingType.Service,
                _ => null,
            };
        }
    }
}