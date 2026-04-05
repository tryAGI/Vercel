
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFlagVersionsResponseVersionDataState
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
    public static class ListFlagVersionsResponseVersionDataStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFlagVersionsResponseVersionDataState value)
        {
            return value switch
            {
                ListFlagVersionsResponseVersionDataState.Active => "active",
                ListFlagVersionsResponseVersionDataState.Archived => "archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFlagVersionsResponseVersionDataState? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListFlagVersionsResponseVersionDataState.Active,
                "archived" => ListFlagVersionsResponseVersionDataState.Archived,
                _ => null,
            };
        }
    }
}