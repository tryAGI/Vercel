
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort drives by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum ListDrivesV1SortBy
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
    public static class ListDrivesV1SortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDrivesV1SortBy value)
        {
            return value switch
            {
                ListDrivesV1SortBy.CreatedAt => "createdAt",
                ListDrivesV1SortBy.Name => "name",
                ListDrivesV1SortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDrivesV1SortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListDrivesV1SortBy.CreatedAt,
                "name" => ListDrivesV1SortBy.Name,
                "updatedAt" => ListDrivesV1SortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}