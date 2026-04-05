
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results by creation time.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListSessionSnapshotsSortOrder
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
    public static class ListSessionSnapshotsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionSnapshotsSortOrder value)
        {
            return value switch
            {
                ListSessionSnapshotsSortOrder.Asc => "asc",
                ListSessionSnapshotsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionSnapshotsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSessionSnapshotsSortOrder.Asc,
                "desc" => ListSessionSnapshotsSortOrder.Desc,
                _ => null,
            };
        }
    }
}