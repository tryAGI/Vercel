
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseLatestDeploymentReadySubstate
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
    public static class UpdateMicrofrontendsResponseLatestDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseLatestDeploymentReadySubstate value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Promoted => "PROMOTED",
                UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Rolling => "ROLLING",
                UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseLatestDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Promoted,
                "ROLLING" => UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Rolling,
                "STAGED" => UpdateMicrofrontendsResponseLatestDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}