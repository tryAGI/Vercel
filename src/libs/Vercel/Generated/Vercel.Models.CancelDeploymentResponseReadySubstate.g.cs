
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum CancelDeploymentResponseReadySubstate
    {
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        Promoted,
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        Rolling,
        /// <summary>
        /// - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelDeploymentResponseReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseReadySubstate value)
        {
            return value switch
            {
                CancelDeploymentResponseReadySubstate.Promoted => "PROMOTED",
                CancelDeploymentResponseReadySubstate.Rolling => "ROLLING",
                CancelDeploymentResponseReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CancelDeploymentResponseReadySubstate.Promoted,
                "ROLLING" => CancelDeploymentResponseReadySubstate.Rolling,
                "STAGED" => CancelDeploymentResponseReadySubstate.Staged,
                _ => null,
            };
        }
    }
}