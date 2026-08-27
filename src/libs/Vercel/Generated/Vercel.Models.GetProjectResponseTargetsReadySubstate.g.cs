
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectResponseTargetsReadySubstate
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
    public static class GetProjectResponseTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseTargetsReadySubstate value)
        {
            return value switch
            {
                GetProjectResponseTargetsReadySubstate.Promoted => "PROMOTED",
                GetProjectResponseTargetsReadySubstate.Rolling => "ROLLING",
                GetProjectResponseTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectResponseTargetsReadySubstate.Promoted,
                "ROLLING" => GetProjectResponseTargetsReadySubstate.Rolling,
                "STAGED" => GetProjectResponseTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}