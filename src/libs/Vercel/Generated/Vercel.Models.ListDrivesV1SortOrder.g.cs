
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort direction for results.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ListDrivesV1SortOrder
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
    public static class ListDrivesV1SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDrivesV1SortOrder value)
        {
            return value switch
            {
                ListDrivesV1SortOrder.Asc => "asc",
                ListDrivesV1SortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDrivesV1SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListDrivesV1SortOrder.Asc,
                "desc" => ListDrivesV1SortOrder.Desc,
                _ => null,
            };
        }
    }
}