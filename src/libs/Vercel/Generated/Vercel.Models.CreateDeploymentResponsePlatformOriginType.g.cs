
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum CreateDeploymentResponsePlatformOriginType
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
    public static class CreateDeploymentResponsePlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponsePlatformOriginType value)
        {
            return value switch
            {
                CreateDeploymentResponsePlatformOriginType.Id => "id",
                CreateDeploymentResponsePlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponsePlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => CreateDeploymentResponsePlatformOriginType.Id,
                "url" => CreateDeploymentResponsePlatformOriginType.Url,
                _ => null,
            };
        }
    }
}