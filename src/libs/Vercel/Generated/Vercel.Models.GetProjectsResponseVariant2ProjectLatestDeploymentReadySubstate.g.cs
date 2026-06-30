
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate
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
    public static class GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant2ProjectLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}