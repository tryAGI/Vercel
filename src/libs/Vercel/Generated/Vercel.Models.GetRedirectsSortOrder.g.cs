
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRedirectsSortOrder
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
    public static class GetRedirectsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRedirectsSortOrder value)
        {
            return value switch
            {
                GetRedirectsSortOrder.Asc => "asc",
                GetRedirectsSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRedirectsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetRedirectsSortOrder.Asc,
                "desc" => GetRedirectsSortOrder.Desc,
                _ => null,
            };
        }
    }
}