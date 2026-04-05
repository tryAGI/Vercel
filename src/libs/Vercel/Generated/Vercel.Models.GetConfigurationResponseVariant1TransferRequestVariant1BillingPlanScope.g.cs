
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope
    {
        /// <summary>
        /// 
        /// </summary>
        Installation,
        /// <summary>
        /// 
        /// </summary>
        Resource,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope value)
        {
            return value switch
            {
                GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope.Installation => "installation",
                GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope.Resource => "resource",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope? ToEnum(string value)
        {
            return value switch
            {
                "installation" => GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope.Installation,
                "resource" => GetConfigurationResponseVariant1TransferRequestVariant1BillingPlanScope.Resource,
                _ => null,
            };
        }
    }
}