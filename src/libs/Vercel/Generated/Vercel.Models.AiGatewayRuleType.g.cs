
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AiGatewayRuleType
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
    public static class AiGatewayRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AiGatewayRuleType value)
        {
            return value switch
            {
                AiGatewayRuleType.Deny => "deny",
                AiGatewayRuleType.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AiGatewayRuleType? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AiGatewayRuleType.Deny,
                "rewrite" => AiGatewayRuleType.Rewrite,
                _ => null,
            };
        }
    }
}