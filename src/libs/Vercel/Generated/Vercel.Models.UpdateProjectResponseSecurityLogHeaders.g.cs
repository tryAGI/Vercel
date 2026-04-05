
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseSecurityLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityLogHeaders value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => UpdateProjectResponseSecurityLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}