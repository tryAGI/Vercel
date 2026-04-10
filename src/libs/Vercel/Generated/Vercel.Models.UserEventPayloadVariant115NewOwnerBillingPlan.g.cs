
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerBillingPlan
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
    public static class UserEventPayloadVariant115NewOwnerBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerBillingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerBillingPlan.Enterprise => "enterprise",
                UserEventPayloadVariant115NewOwnerBillingPlan.Hobby => "hobby",
                UserEventPayloadVariant115NewOwnerBillingPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant115NewOwnerBillingPlan.Enterprise,
                "hobby" => UserEventPayloadVariant115NewOwnerBillingPlan.Hobby,
                "pro" => UserEventPayloadVariant115NewOwnerBillingPlan.Pro,
                _ => null,
            };
        }
    }
}