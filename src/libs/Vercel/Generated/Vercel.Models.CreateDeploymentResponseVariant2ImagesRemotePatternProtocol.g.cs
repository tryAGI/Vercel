
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `http` or `https`.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ImagesRemotePatternProtocol
    {
        /// <summary>
        /// 
        /// </summary>
        Http,
        /// <summary>
        /// 
        /// </summary>
        Https,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseVariant2ImagesRemotePatternProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ImagesRemotePatternProtocol value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ImagesRemotePatternProtocol.Http => "http",
                CreateDeploymentResponseVariant2ImagesRemotePatternProtocol.Https => "https",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ImagesRemotePatternProtocol? ToEnum(string value)
        {
            return value switch
            {
                "http" => CreateDeploymentResponseVariant2ImagesRemotePatternProtocol.Http,
                "https" => CreateDeploymentResponseVariant2ImagesRemotePatternProtocol.Https,
                _ => null,
            };
        }
    }
}