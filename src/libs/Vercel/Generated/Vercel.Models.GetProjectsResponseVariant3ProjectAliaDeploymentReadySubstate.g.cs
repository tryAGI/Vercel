
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate
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
    public static class GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant3ProjectAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}