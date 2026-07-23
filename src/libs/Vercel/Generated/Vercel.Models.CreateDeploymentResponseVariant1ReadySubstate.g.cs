
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Substate of deployment when readyState is 'READY' Tracks whether or not deployment has seen production traffic: - STAGED: never seen production traffic - ROLLING: in the process of having production traffic gradually transitioned. - PROMOTED: has seen production traffic
    /// </summary>
    public enum CreateDeploymentResponseVariant1ReadySubstate
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
    public static class CreateDeploymentResponseVariant1ReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant1ReadySubstate value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant1ReadySubstate.Promoted => "PROMOTED",
                CreateDeploymentResponseVariant1ReadySubstate.Rolling => "ROLLING",
                CreateDeploymentResponseVariant1ReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant1ReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CreateDeploymentResponseVariant1ReadySubstate.Promoted,
                "ROLLING" => CreateDeploymentResponseVariant1ReadySubstate.Rolling,
                "STAGED" => CreateDeploymentResponseVariant1ReadySubstate.Staged,
                _ => null,
            };
        }
    }
}