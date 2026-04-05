
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
    /// </summary>
    public enum GetDeploymentsResponseDeploymentReadySubstate
    {
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
        /// </summary>
        Promoted,
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
        /// </summary>
        Rolling,
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of gradually transitioning production traffic - PROMOTED: has seen production traffic
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentsResponseDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentsResponseDeploymentReadySubstate value)
        {
            return value switch
            {
                GetDeploymentsResponseDeploymentReadySubstate.Promoted => "PROMOTED",
                GetDeploymentsResponseDeploymentReadySubstate.Rolling => "ROLLING",
                GetDeploymentsResponseDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentsResponseDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetDeploymentsResponseDeploymentReadySubstate.Promoted,
                "ROLLING" => GetDeploymentsResponseDeploymentReadySubstate.Rolling,
                "STAGED" => GetDeploymentsResponseDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}