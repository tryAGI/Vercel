
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AiGatewayRuleListItemType
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
    public static class AiGatewayRuleListItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayRuleListItemType value)
        {
            return value switch
            {
                AiGatewayRuleListItemType.Deny => "deny",
                AiGatewayRuleListItemType.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayRuleListItemType? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AiGatewayRuleListItemType.Deny,
                "rewrite" => AiGatewayRuleListItemType.Rewrite,
                _ => null,
            };
        }
    }
}