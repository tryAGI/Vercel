
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether to include soft-deleted credentials<br/>
    /// Default Value: false
    /// </summary>
    public enum ListAiGatewayByokCredentialsIncludeDeleted
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
    public static class ListAiGatewayByokCredentialsIncludeDeletedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAiGatewayByokCredentialsIncludeDeleted value)
        {
            return value switch
            {
                ListAiGatewayByokCredentialsIncludeDeleted.False => "false",
                ListAiGatewayByokCredentialsIncludeDeleted.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAiGatewayByokCredentialsIncludeDeleted? ToEnum(string value)
        {
            return value switch
            {
                "false" => ListAiGatewayByokCredentialsIncludeDeleted.False,
                "true" => ListAiGatewayByokCredentialsIncludeDeleted.True,
                _ => null,
            };
        }
    }
}