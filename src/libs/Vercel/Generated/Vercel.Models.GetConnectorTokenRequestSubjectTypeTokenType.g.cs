
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectorTokenRequestSubjectTypeTokenType
    {
        /// <summary>
        ///
        /// </summary>
        Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectorTokenRequestSubjectTypeTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectorTokenRequestSubjectTypeTokenType value)
        {
            return value switch
            {
                GetConnectorTokenRequestSubjectTypeTokenType.Token => "token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectorTokenRequestSubjectTypeTokenType? ToEnum(string value)
        {
            return value switch
            {
                "token" => GetConnectorTokenRequestSubjectTypeTokenType.Token,
                _ => null,
            };
        }
    }
}