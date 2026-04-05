
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRoutesDiff2
    {
        /// <summary>
        /// 
        /// </summary>
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRoutesDiff2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRoutesDiff2 value)
        {
            return value switch
            {
                GetRoutesDiff2.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRoutesDiff2? ToEnum(string value)
        {
            return value switch
            {
                "only" => GetRoutesDiff2.Only,
                _ => null,
            };
        }
    }
}