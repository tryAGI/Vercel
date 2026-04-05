
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the flags to retrieve. Defaults to `active`.
    /// </summary>
    public enum ListTeamFlagsState
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
    public static class ListTeamFlagsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamFlagsState value)
        {
            return value switch
            {
                ListTeamFlagsState.Active => "active",
                ListTeamFlagsState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamFlagsState? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListTeamFlagsState.Active,
                "archived" => ListTeamFlagsState.Archived,
                _ => null,
            };
        }
    }
}