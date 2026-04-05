
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Must be `http` or `https`.
    /// </summary>
    public enum CancelDeploymentResponseImagesRemotePatternProtocol
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
    public static class CancelDeploymentResponseImagesRemotePatternProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseImagesRemotePatternProtocol value)
        {
            return value switch
            {
                CancelDeploymentResponseImagesRemotePatternProtocol.Http => "http",
                CancelDeploymentResponseImagesRemotePatternProtocol.Https => "https",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseImagesRemotePatternProtocol? ToEnum(string value)
        {
            return value switch
            {
                "http" => CancelDeploymentResponseImagesRemotePatternProtocol.Http,
                "https" => CancelDeploymentResponseImagesRemotePatternProtocol.Https,
                _ => null,
            };
        }
    }
}