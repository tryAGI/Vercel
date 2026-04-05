
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalServerErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternalServerErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalServerErrorCode value)
        {
            return value switch
            {
                InternalServerErrorCode.InternalServerError => "internal_server_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalServerErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "internal_server_error" => InternalServerErrorCode.InternalServerError,
                _ => null,
            };
        }
    }
}