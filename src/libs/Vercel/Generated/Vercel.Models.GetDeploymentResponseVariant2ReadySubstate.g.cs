
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum GetDeploymentResponseVariant2ReadySubstate
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
    public static class GetDeploymentResponseVariant2ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ReadySubstate value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ReadySubstate.Promoted => "PROMOTED",
                GetDeploymentResponseVariant2ReadySubstate.Rolling => "ROLLING",
                GetDeploymentResponseVariant2ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetDeploymentResponseVariant2ReadySubstate.Promoted,
                "ROLLING" => GetDeploymentResponseVariant2ReadySubstate.Rolling,
                "STAGED" => GetDeploymentResponseVariant2ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}