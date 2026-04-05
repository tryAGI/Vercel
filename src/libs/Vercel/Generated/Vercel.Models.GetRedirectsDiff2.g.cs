
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRedirectsDiff2
    {
        /// <summary>
        /// 
        /// </summary>
        Only,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRedirectsDiff2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRedirectsDiff2 value)
        {
            return value switch
            {
                GetRedirectsDiff2.Only => "only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRedirectsDiff2? ToEnum(string value)
        {
            return value switch
            {
                "only" => GetRedirectsDiff2.Only,
                _ => null,
            };
        }
    }
}