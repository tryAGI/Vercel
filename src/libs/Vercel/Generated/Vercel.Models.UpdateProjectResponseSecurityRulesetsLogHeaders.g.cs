
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseSecurityRulesetsLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectResponseSecurityRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseSecurityRulesetsLogHeaders value)
        {
            return value switch
            {
                UpdateProjectResponseSecurityRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseSecurityRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => UpdateProjectResponseSecurityRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}