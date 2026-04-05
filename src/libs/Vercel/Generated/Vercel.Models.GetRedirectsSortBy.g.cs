
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRedirectsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Destination,
        /// <summary>
        /// 
        /// </summary>
        Source,
        /// <summary>
        /// 
        /// </summary>
        StatusCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRedirectsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRedirectsSortBy value)
        {
            return value switch
            {
                GetRedirectsSortBy.Destination => "destination",
                GetRedirectsSortBy.Source => "source",
                GetRedirectsSortBy.StatusCode => "statusCode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRedirectsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "destination" => GetRedirectsSortBy.Destination,
                "source" => GetRedirectsSortBy.Source,
                "statusCode" => GetRedirectsSortBy.StatusCode,
                _ => null,
            };
        }
    }
}