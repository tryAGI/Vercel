
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensRequestTokenSubjectTypeUserType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportConnectorTokensRequestTokenSubjectTypeUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensRequestTokenSubjectTypeUserType value)
        {
            return value switch
            {
                ImportConnectorTokensRequestTokenSubjectTypeUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensRequestTokenSubjectTypeUserType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ImportConnectorTokensRequestTokenSubjectTypeUserType.User,
                _ => null,
            };
        }
    }
}