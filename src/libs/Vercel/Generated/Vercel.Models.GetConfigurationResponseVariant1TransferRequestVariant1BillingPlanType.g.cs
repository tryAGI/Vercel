
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType
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
    public static class GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType.Prepayment => "prepayment",
                GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType? ToEnum(string value)
        {
            return value switch
            {
                "prepayment" => GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType.Prepayment,
                "subscription" => GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanType.Subscription,
                _ => null,
            };
        }
    }
}