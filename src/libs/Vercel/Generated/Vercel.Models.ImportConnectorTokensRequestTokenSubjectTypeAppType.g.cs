
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportConnectorTokensRequestTokenSubjectTypeAppType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportConnectorTokensRequestTokenSubjectTypeAppTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportConnectorTokensRequestTokenSubjectTypeAppType value)
        {
            return value switch
            {
                ImportConnectorTokensRequestTokenSubjectTypeAppType.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportConnectorTokensRequestTokenSubjectTypeAppType? ToEnum(string value)
        {
            return value switch
            {
                "app" => ImportConnectorTokensRequestTokenSubjectTypeAppType.App,
                _ => null,
            };
        }
    }
}