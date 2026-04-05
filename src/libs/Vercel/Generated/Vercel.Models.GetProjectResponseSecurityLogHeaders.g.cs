
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseSecurityLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectResponseSecurityLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseSecurityLogHeaders value)
        {
            return value switch
            {
                GetProjectResponseSecurityLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseSecurityLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetProjectResponseSecurityLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}