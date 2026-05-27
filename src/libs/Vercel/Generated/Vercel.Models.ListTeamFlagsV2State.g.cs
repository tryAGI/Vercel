
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the flags to retrieve. Defaults to `active`.
    /// </summary>
    public enum ListTeamFlagsV2State
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTeamFlagsV2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamFlagsV2State value)
        {
            return value switch
            {
                ListTeamFlagsV2State.Active => "active",
                ListTeamFlagsV2State.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamFlagsV2State? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListTeamFlagsV2State.Active,
                "archived" => ListTeamFlagsV2State.Archived,
                _ => null,
            };
        }
    }
}