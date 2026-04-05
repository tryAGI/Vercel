
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnauthorizedCode
    {
        /// <summary>
        /// 
        /// </summary>
        Unauthorized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnauthorizedCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnauthorizedCode value)
        {
            return value switch
            {
                UnauthorizedCode.Unauthorized => "unauthorized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnauthorizedCode? ToEnum(string value)
        {
            return value switch
            {
                "unauthorized" => UnauthorizedCode.Unauthorized,
                _ => null,
            };
        }
    }
}