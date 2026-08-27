
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `http` or `https`.
    /// </summary>
    public enum GetDeploymentResponseVariant2ImagesRemotePatternProtocol
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
    public static class GetDeploymentResponseVariant2ImagesRemotePatternProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ImagesRemotePatternProtocol value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ImagesRemotePatternProtocol.Http => "http",
                GetDeploymentResponseVariant2ImagesRemotePatternProtocol.Https => "https",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ImagesRemotePatternProtocol? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetDeploymentResponseVariant2ImagesRemotePatternProtocol.Http,
                "https" => GetDeploymentResponseVariant2ImagesRemotePatternProtocol.Https,
                _ => null,
            };
        }
    }
}