
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListDrivesSortOrder
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
    public static class ListDrivesSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDrivesSortOrder value)
        {
            return value switch
            {
                ListDrivesSortOrder.Asc => "asc",
                ListDrivesSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDrivesSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListDrivesSortOrder.Asc,
                "desc" => ListDrivesSortOrder.Desc,
                _ => null,
            };
        }
    }
}