
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum CancelDeploymentResponsePlatformOriginType
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponsePlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponsePlatformOriginType value)
        {
            return value switch
            {
                CancelDeploymentResponsePlatformOriginType.Id => "id",
                CancelDeploymentResponsePlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponsePlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => CancelDeploymentResponsePlatformOriginType.Id,
                "url" => CancelDeploymentResponsePlatformOriginType.Url,
                _ => null,
            };
        }
    }
}