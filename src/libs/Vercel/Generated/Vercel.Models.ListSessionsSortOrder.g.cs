
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results by creation time.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListSessionsSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListSessionsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionsSortOrder value)
        {
            return value switch
            {
                ListSessionsSortOrder.Asc => "asc",
                ListSessionsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSessionsSortOrder.Asc,
                "desc" => ListSessionsSortOrder.Desc,
                _ => null,
            };
        }
    }
}