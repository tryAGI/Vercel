
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Principal type of the deployment creator. Defaults to `"user"` if absent (legacy deployments created before principal attribution was recorded).
    /// </summary>
    public enum GetDeploymentsResponseDeploymentCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentCreatorType value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentCreatorType.App => "app",
                GetDeploymentsResponseDeploymentCreatorType.Integration => "integration",
                GetDeploymentsResponseDeploymentCreatorType.System => "system",
                GetDeploymentsResponseDeploymentCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "app" => GetDeploymentsResponseDeploymentCreatorType.App,
                "integration" => GetDeploymentsResponseDeploymentCreatorType.Integration,
                "system" => GetDeploymentsResponseDeploymentCreatorType.System,
                "user" => GetDeploymentsResponseDeploymentCreatorType.User,
                _ => null,
            };
        }
    }
}