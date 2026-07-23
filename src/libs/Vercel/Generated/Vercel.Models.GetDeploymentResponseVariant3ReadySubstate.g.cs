
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum GetDeploymentResponseVariant3ReadySubstate
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
    public static class GetDeploymentResponseVariant3ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant3ReadySubstate value)
        {
            return value switch
            {
                GetDeploymentResponseVariant3ReadySubstate.Promoted => "PROMOTED",
                GetDeploymentResponseVariant3ReadySubstate.Rolling => "ROLLING",
                GetDeploymentResponseVariant3ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant3ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetDeploymentResponseVariant3ReadySubstate.Promoted,
                "ROLLING" => GetDeploymentResponseVariant3ReadySubstate.Rolling,
                "STAGED" => GetDeploymentResponseVariant3ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}