
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerBillingPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Hobby,
        /// <summary>
        /// 
        /// </summary>
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerBillingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerBillingPlan.Enterprise => "enterprise",
                UserEventPayloadVariant116NewOwnerBillingPlan.Hobby => "hobby",
                UserEventPayloadVariant116NewOwnerBillingPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant116NewOwnerBillingPlan.Enterprise,
                "hobby" => UserEventPayloadVariant116NewOwnerBillingPlan.Hobby,
                "pro" => UserEventPayloadVariant116NewOwnerBillingPlan.Pro,
                _ => null,
            };
        }
    }
}