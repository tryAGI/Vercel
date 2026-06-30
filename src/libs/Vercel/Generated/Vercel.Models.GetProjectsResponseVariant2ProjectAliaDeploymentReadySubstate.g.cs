
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate
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
    public static class GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant2ProjectAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}