
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum GetDeploymentResponseVariant2PlatformOriginType
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
    public static class GetDeploymentResponseVariant2PlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2PlatformOriginType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2PlatformOriginType.Id => "id",
                GetDeploymentResponseVariant2PlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2PlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => GetDeploymentResponseVariant2PlatformOriginType.Id,
                "url" => GetDeploymentResponseVariant2PlatformOriginType.Url,
                _ => null,
            };
        }
    }
}