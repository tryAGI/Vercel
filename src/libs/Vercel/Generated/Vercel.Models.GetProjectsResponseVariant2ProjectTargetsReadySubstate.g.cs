
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectTargetsReadySubstate
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
    public static class GetProjectsResponseVariant2ProjectTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectTargetsReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectTargetsReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant2ProjectTargetsReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant2ProjectTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant2ProjectTargetsReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant2ProjectTargetsReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant2ProjectTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}