
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemTargetsReadySubstate
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
    public static class GetProjectsResponseVariant1ItemTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemTargetsReadySubstate value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemTargetsReadySubstate.Promoted => "PROMOTED",
                GetProjectsResponseVariant1ItemTargetsReadySubstate.Rolling => "ROLLING",
                GetProjectsResponseVariant1ItemTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => GetProjectsResponseVariant1ItemTargetsReadySubstate.Promoted,
                "ROLLING" => GetProjectsResponseVariant1ItemTargetsReadySubstate.Rolling,
                "STAGED" => GetProjectsResponseVariant1ItemTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}