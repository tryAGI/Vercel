
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ForbiddenCode
    {
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ForbiddenCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForbiddenCode value)
        {
            return value switch
            {
                ForbiddenCode.Forbidden => "forbidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForbiddenCode? ToEnum(string value)
        {
            return value switch
            {
                "forbidden" => ForbiddenCode.Forbidden,
                _ => null,
            };
        }
    }
}