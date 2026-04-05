
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum GetDeploymentResponseVariant1ReadySubstate
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
    public static class GetDeploymentResponseVariant1ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1ReadySubstate value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1ReadySubstate.Promoted => "PROMOTED",
                GetDeploymentResponseVariant1ReadySubstate.Rolling => "ROLLING",
                GetDeploymentResponseVariant1ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetDeploymentResponseVariant1ReadySubstate.Promoted,
                "ROLLING" => GetDeploymentResponseVariant1ReadySubstate.Rolling,
                "STAGED" => GetDeploymentResponseVariant1ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}