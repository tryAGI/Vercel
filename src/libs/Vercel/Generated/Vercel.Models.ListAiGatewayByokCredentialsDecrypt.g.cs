
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Not supported. Credential values are never returned.<br/>
    /// Default Value: false
    /// </summary>
    public enum ListAiGatewayByokCredentialsDecrypt
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAiGatewayByokCredentialsDecryptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayByokCredentialsDecrypt value)
        {
            return value switch
            {
                ListAiGatewayByokCredentialsDecrypt.False => "false",
                ListAiGatewayByokCredentialsDecrypt.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayByokCredentialsDecrypt? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListAiGatewayByokCredentialsDecrypt.False,
                "true" => ListAiGatewayByokCredentialsDecrypt.True,
                _ => null,
            };
        }
    }
}