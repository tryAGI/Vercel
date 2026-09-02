
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Sort by name in ascending order, or by creation or update time in descending order.
    /// </summary>
    public enum ListConnectorsSort
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConnectorsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConnectorsSort value)
        {
            return value switch
            {
                ListConnectorsSort.CreatedAt => "createdAt",
                ListConnectorsSort.Name => "name",
                ListConnectorsSort.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConnectorsSort? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListConnectorsSort.CreatedAt,
                "name" => ListConnectorsSort.Name,
                "updatedAt" => ListConnectorsSort.UpdatedAt,
                _ => null,
            };
        }
    }
}