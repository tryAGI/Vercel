
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotFoundCode
    {
        /// <summary>
        /// 
        /// </summary>
        NotFound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotFoundCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotFoundCode value)
        {
            return value switch
            {
                NotFoundCode.NotFound => "not_found",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotFoundCode? ToEnum(string value)
        {
            return value switch
            {
                "not_found" => NotFoundCode.NotFound,
                _ => null,
            };
        }
    }
}