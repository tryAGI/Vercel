
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseSecurityLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityLogHeaders value)
        {
            return value switch
            {
                CreateProjectResponseSecurityLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => CreateProjectResponseSecurityLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}