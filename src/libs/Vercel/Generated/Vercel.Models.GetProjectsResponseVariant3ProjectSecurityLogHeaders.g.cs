
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectSecurityLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant3ProjectSecurityLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectSecurityLogHeaders value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectSecurityLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectSecurityLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => GetProjectsResponseVariant3ProjectSecurityLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}