
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `http` or `https`.
    /// </summary>
    public enum GetDeploymentResponseVariant1ImagesRemotePatternProtocol
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
    public static class GetDeploymentResponseVariant1ImagesRemotePatternProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ImagesRemotePatternProtocol value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ImagesRemotePatternProtocol.Http => "http",
                GetDeploymentResponseVariant1ImagesRemotePatternProtocol.Https => "https",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ImagesRemotePatternProtocol? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetDeploymentResponseVariant1ImagesRemotePatternProtocol.Http,
                "https" => GetDeploymentResponseVariant1ImagesRemotePatternProtocol.Https,
                _ => null,
            };
        }
    }
}