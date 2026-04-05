
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the value is an opaque identifier or a URL.
    /// </summary>
    public enum GetDeploymentsResponseDeploymentPlatformOriginType
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
    public static class GetDeploymentsResponseDeploymentPlatformOriginTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentPlatformOriginType value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentPlatformOriginType.Id => "id",
                GetDeploymentsResponseDeploymentPlatformOriginType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentPlatformOriginType? ToEnum(string value)
        {
            return value switch
            {
                "id" => GetDeploymentsResponseDeploymentPlatformOriginType.Id,
                "url" => GetDeploymentsResponseDeploymentPlatformOriginType.Url,
                _ => null,
            };
        }
    }
}