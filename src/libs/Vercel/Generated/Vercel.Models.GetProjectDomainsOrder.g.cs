
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Domains sort order by createdAt<br/>
    /// Default Value: DESC
    /// </summary>
    public enum GetProjectDomainsOrder
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
    public static class GetProjectDomainsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectDomainsOrder value)
        {
            return value switch
            {
                GetProjectDomainsOrder.Asc => "ASC",
                GetProjectDomainsOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectDomainsOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetProjectDomainsOrder.Asc,
                "DESC" => GetProjectDomainsOrder.Desc,
                _ => null,
            };
        }
    }
}