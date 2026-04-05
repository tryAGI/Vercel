
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum BadRequestCode
    {
        /// <summary>
        /// 
        /// </summary>
        BadRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BadRequestCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BadRequestCode value)
        {
            return value switch
            {
                BadRequestCode.BadRequest => "bad_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BadRequestCode? ToEnum(string value)
        {
            return value switch
            {
                "bad_request" => BadRequestCode.BadRequest,
                _ => null,
            };
        }
    }
}