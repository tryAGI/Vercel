
#nullable enable

namespace Vercel
{
    /// <summary>
    /// On which environment has the deployment been deployed to.<br/>
    /// Example: production
    /// </summary>
    public enum GetDeploymentsResponseDeploymentTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Production,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentTarget value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentTarget.Production => "production",
                GetDeploymentsResponseDeploymentTarget.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentTarget? ToEnum(string value)
        {
            return value switch
            {
                "production" => GetDeploymentsResponseDeploymentTarget.Production,
                "staging" => GetDeploymentsResponseDeploymentTarget.Staging,
                _ => null,
            };
        }
    }
}