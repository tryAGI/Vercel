
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant272NewPlan
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
    public static class UserEventPayloadVariant272NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant272NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant272NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant272NewPlan.Hobby => "hobby",
                UserEventPayloadVariant272NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant272NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant272NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant272NewPlan.Hobby,
                "pro" => UserEventPayloadVariant272NewPlan.Pro,
                _ => null,
            };
        }
    }
}