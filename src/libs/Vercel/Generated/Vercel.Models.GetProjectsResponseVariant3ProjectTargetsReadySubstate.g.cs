
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectTargetsReadySubstate
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
    public static class GetProjectsResponseVariant3ProjectTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectTargetsReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectTargetsReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant3ProjectTargetsReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant3ProjectTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant3ProjectTargetsReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant3ProjectTargetsReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant3ProjectTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}