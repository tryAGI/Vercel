
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The currency being purchased
    /// </summary>
    public enum BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        AiCredits,
        /// <summary>
        /// 
        /// </summary>
        AiGatewayCredits,
        /// <summary>
        /// 
        /// </summary>
        CopperTestUnits,
        /// <summary>
        /// 
        /// </summary>
        V0UserCredits,
        /// <summary>
        /// 
        /// </summary>
        VercelAgentCredits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency value)
        {
            return value switch
            {
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.AiCredits => "ai_credits",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.AiGatewayCredits => "ai_gateway_credits",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.CopperTestUnits => "copper_test_units",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.V0UserCredits => "v0_user_credits",
                BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.VercelAgentCredits => "vercel_agent_credits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency? ToEnum(string value)
        {
            return value switch
            {
                "ai_credits" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.AiCredits,
                "ai_gateway_credits" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.AiGatewayCredits,
                "copper_test_units" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.CopperTestUnits,
                "v0_user_credits" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.V0UserCredits,
                "vercel_agent_credits" => BuyCreditsResponseVariant2PurchaseIntentConfigurationVariant1OptionsCurrency.VercelAgentCredits,
                _ => null,
            };
        }
    }
}