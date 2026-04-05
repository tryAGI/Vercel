
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreBillingPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Prepayment,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationStoreDirectResponseStoreBillingPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreBillingPlanType value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreBillingPlanType.Prepayment => "prepayment",
                CreateIntegrationStoreDirectResponseStoreBillingPlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreBillingPlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => CreateIntegrationStoreDirectResponseStoreBillingPlanType.Prepayment,
                "subscription" => CreateIntegrationStoreDirectResponseStoreBillingPlanType.Subscription,
                _ => null,
            };
        }
    }
}