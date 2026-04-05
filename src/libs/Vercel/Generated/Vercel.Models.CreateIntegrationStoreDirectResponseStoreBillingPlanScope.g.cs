
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateIntegrationStoreDirectResponseStoreBillingPlanScope
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
    public static class CreateIntegrationStoreDirectResponseStoreBillingPlanScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationStoreDirectResponseStoreBillingPlanScope value)
        {
            return value switch
            {
                CreateIntegrationStoreDirectResponseStoreBillingPlanScope.Installation => "installation",
                CreateIntegrationStoreDirectResponseStoreBillingPlanScope.Resource => "resource",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationStoreDirectResponseStoreBillingPlanScope? ToEnum(string value)
        {
            return value switch
            {
                "installation" => CreateIntegrationStoreDirectResponseStoreBillingPlanScope.Installation,
                "resource" => CreateIntegrationStoreDirectResponseStoreBillingPlanScope.Resource,
                _ => null,
            };
        }
    }
}