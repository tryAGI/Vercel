
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseTargetsReadySubstate
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
    public static class CreateProjectResponseTargetsReadySubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseTargetsReadySubstate value)
        {
            return value switch
            {
                CreateProjectResponseTargetsReadySubstate.Promoted => "PROMOTED",
                CreateProjectResponseTargetsReadySubstate.Rolling => "ROLLING",
                CreateProjectResponseTargetsReadySubstate.Staged => "STAGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseTargetsReadySubstate? ToEnum(string value)
        {
            return value switch
            {
                "PROMOTED" => CreateProjectResponseTargetsReadySubstate.Promoted,
                "ROLLING" => CreateProjectResponseTargetsReadySubstate.Rolling,
                "STAGED" => CreateProjectResponseTargetsReadySubstate.Staged,
                _ => null,
            };
        }
    }
}