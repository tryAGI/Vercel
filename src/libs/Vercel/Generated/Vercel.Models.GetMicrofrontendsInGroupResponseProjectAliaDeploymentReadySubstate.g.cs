
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate
    {
        /// <summary>
        ///
        /// </summary>
        Promoted,
        /// <summary>
        ///
        /// </summary>
        Rolling,
        /// <summary>
        ///
        /// </summary>
        Staged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Rolling => "ROLLING",
                GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Rolling,
                "STAGED" => GetMicrofrontendsInGroupResponseProjectAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}