
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerBillingPlan
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
    public static class UserEventPayloadVariant114NewOwnerBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerBillingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerBillingPlan.Enterprise => "enterprise",
                UserEventPayloadVariant114NewOwnerBillingPlan.Hobby => "hobby",
                UserEventPayloadVariant114NewOwnerBillingPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant114NewOwnerBillingPlan.Enterprise,
                "hobby" => UserEventPayloadVariant114NewOwnerBillingPlan.Hobby,
                "pro" => UserEventPayloadVariant114NewOwnerBillingPlan.Pro,
                _ => null,
            };
        }
    }
}