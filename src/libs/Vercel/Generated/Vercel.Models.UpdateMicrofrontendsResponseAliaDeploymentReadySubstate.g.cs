
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrofrontendsResponseAliaDeploymentReadySubstate
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
    public static class UpdateMicrofrontendsResponseAliaDeploymentReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseAliaDeploymentReadySubstate value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Promoted => "PROMOTED",
                UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Rolling => "ROLLING",
                UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseAliaDeploymentReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Promoted,
                "ROLLING" => UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Rolling,
                "STAGED" => UpdateMicrofrontendsResponseAliaDeploymentReadySubstate.Staged,
                _ => null,
            };
        }
    }
}