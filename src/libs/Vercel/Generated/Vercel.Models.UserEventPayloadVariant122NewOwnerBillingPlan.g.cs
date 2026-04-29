
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerBillingPlan
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
    public static class UserEventPayloadVariant122NewOwnerBillingPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerBillingPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerBillingPlan.Enterprise => "enterprise",
                UserEventPayloadVariant122NewOwnerBillingPlan.Hobby => "hobby",
                UserEventPayloadVariant122NewOwnerBillingPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerBillingPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant122NewOwnerBillingPlan.Enterprise,
                "hobby" => UserEventPayloadVariant122NewOwnerBillingPlan.Hobby,
                "pro" => UserEventPayloadVariant122NewOwnerBillingPlan.Pro,
                _ => null,
            };
        }
    }
}