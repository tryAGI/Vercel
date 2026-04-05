
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The state of the flags to retrieve. Defaults to `active`.
    /// </summary>
    public enum ListFlagsState
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
    public static class ListFlagsStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagsState value)
        {
            return value switch
            {
                ListFlagsState.Active => "active",
                ListFlagsState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagsState? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListFlagsState.Active,
                "archived" => ListFlagsState.Archived,
                _ => null,
            };
        }
    }
}