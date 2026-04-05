
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of credits to purchase.
    /// </summary>
    public enum BuyCreditsRequestItemCreditType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Gateway,
        /// <summary>
        /// 
        /// </summary>
        V0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuyCreditsRequestItemCreditTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuyCreditsRequestItemCreditType value)
        {
            return value switch
            {
                BuyCreditsRequestItemCreditType.Agent => "agent",
                BuyCreditsRequestItemCreditType.Gateway => "gateway",
                BuyCreditsRequestItemCreditType.V0 => "v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuyCreditsRequestItemCreditType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BuyCreditsRequestItemCreditType.Agent,
                "gateway" => BuyCreditsRequestItemCreditType.Gateway,
                "v0" => BuyCreditsRequestItemCreditType.V0,
                _ => null,
            };
        }
    }
}