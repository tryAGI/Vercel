
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether to include model mappings for each credential in the response<br/>
    /// Default Value: false
    /// </summary>
    public enum ListAiGatewayByokCredentialsIncludeModelMappings
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
    public static class ListAiGatewayByokCredentialsIncludeModelMappingsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayByokCredentialsIncludeModelMappings value)
        {
            return value switch
            {
                ListAiGatewayByokCredentialsIncludeModelMappings.False => "false",
                ListAiGatewayByokCredentialsIncludeModelMappings.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayByokCredentialsIncludeModelMappings? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListAiGatewayByokCredentialsIncludeModelMappings.False,
                "true" => ListAiGatewayByokCredentialsIncludeModelMappings.True,
                _ => null,
            };
        }
    }
}