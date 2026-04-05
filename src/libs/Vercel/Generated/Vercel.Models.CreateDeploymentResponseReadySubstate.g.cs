
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum CreateDeploymentResponseReadySubstate
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
    public static class CreateDeploymentResponseReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseReadySubstate value)
        {
            return value switch
            {
                CreateDeploymentResponseReadySubstate.Promoted => "PROMOTED",
                CreateDeploymentResponseReadySubstate.Rolling => "ROLLING",
                CreateDeploymentResponseReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CreateDeploymentResponseReadySubstate.Promoted,
                "ROLLING" => CreateDeploymentResponseReadySubstate.Rolling,
                "STAGED" => CreateDeploymentResponseReadySubstate.Staged,
                _ => null,
            };
        }
    }
}