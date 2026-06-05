
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Field to sort drives by.<br/>
    /// Default Value: createdAt
    /// </summary>
    public enum ListDrivesSortBy
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
    public static class ListDrivesSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDrivesSortBy value)
        {
            return value switch
            {
                ListDrivesSortBy.CreatedAt => "createdAt",
                ListDrivesSortBy.Name => "name",
                ListDrivesSortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDrivesSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListDrivesSortBy.CreatedAt,
                "name" => ListDrivesSortBy.Name,
                "updatedAt" => ListDrivesSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}