
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate
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
    public static class GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Rolling => "ROLLING",
                GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Rolling,
                "STAGED" => GetMicrofrontendsInGroupResponseProjectLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}