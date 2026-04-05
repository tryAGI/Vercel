
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentsResponseDeploymentChecksDeploymentAliasState
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentChecksDeploymentAliasStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentChecksDeploymentAliasState value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Failed => "failed",
                GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Pending => "pending",
                GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentChecksDeploymentAliasState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Failed,
                "pending" => GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Pending,
                "succeeded" => GetDeploymentsResponseDeploymentChecksDeploymentAliasState.Succeeded,
                _ => null,
            };
        }
    }
}