
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TooManyRequestsCode
    {
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TooManyRequestsCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TooManyRequestsCode value)
        {
            return value switch
            {
                TooManyRequestsCode.TooManyRequests => "too_many_requests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TooManyRequestsCode? ToEnum(string value)
        {
            return value switch
            {
                "too_many_requests" => TooManyRequestsCode.TooManyRequests,
                _ => null,
            };
        }
    }
}