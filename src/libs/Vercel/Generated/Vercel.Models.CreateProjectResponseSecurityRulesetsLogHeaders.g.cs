
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseSecurityRulesetsLogHeaders
    {
        /// <summary>
        /// 
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectResponseSecurityRulesetsLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseSecurityRulesetsLogHeaders value)
        {
            return value switch
            {
                CreateProjectResponseSecurityRulesetsLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseSecurityRulesetsLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => CreateProjectResponseSecurityRulesetsLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}