
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseTargetsReadySubstate
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
    public static class UpdateProjectResponseTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseTargetsReadySubstate value)
        {
            return value switch
            {
                UpdateProjectResponseTargetsReadySubstate.Promoted => "PROMOTED",
                UpdateProjectResponseTargetsReadySubstate.Rolling => "ROLLING",
                UpdateProjectResponseTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => UpdateProjectResponseTargetsReadySubstate.Promoted,
                "ROLLING" => UpdateProjectResponseTargetsReadySubstate.Rolling,
                "STAGED" => UpdateProjectResponseTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}