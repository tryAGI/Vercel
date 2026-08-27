
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the flags to retrieve. Defaults to `active`.
    /// </summary>
    public enum ListFlagsV2State
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
    public static class ListFlagsV2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagsV2State value)
        {
            return value switch
            {
                ListFlagsV2State.Active => "active",
                ListFlagsV2State.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagsV2State? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListFlagsV2State.Active,
                "archived" => ListFlagsV2State.Archived,
                _ => null,
            };
        }
    }
}