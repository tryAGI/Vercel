
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Optional explicit format marker. The destination is identified by the presence of `service`, so `type` is no longer required.
    /// </summary>
    public enum GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "service" => GetDeploymentResponseVariant2ServiceVariant2RewriteDestinationType.Service,
                _ => null,
            };
        }
    }
}