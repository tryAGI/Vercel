
#nullable enable

namespace Vercel
{
    /// <summary>
    /// `rewrite` sends requests for the matched model to another model. `deny` rejects them.
    /// </summary>
    public enum CreateAiGatewayRuleRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Rewrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAiGatewayRuleRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAiGatewayRuleRequestType value)
        {
            return value switch
            {
                CreateAiGatewayRuleRequestType.Deny => "deny",
                CreateAiGatewayRuleRequestType.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAiGatewayRuleRequestType? ToEnum(string value)
        {
            return value switch
            {
                "deny" => CreateAiGatewayRuleRequestType.Deny,
                "rewrite" => CreateAiGatewayRuleRequestType.Rewrite,
                _ => null,
            };
        }
    }
}