
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum GetDeploymentResponseVariant1PlatformOriginType
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
    public static class GetDeploymentResponseVariant1PlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1PlatformOriginType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1PlatformOriginType.Id => "id",
                GetDeploymentResponseVariant1PlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1PlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => GetDeploymentResponseVariant1PlatformOriginType.Id,
                "url" => GetDeploymentResponseVariant1PlatformOriginType.Url,
                _ => null,
            };
        }
    }
}