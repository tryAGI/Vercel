
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum CreateDeploymentResponseVariant2PlatformOriginType
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
    public static class CreateDeploymentResponseVariant2PlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2PlatformOriginType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2PlatformOriginType.Id => "id",
                CreateDeploymentResponseVariant2PlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2PlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => CreateDeploymentResponseVariant2PlatformOriginType.Id,
                "url" => CreateDeploymentResponseVariant2PlatformOriginType.Url,
                _ => null,
            };
        }
    }
}