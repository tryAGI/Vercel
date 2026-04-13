
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant255NewPlan
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
    public static class UserEventPayloadVariant255NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant255NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant255NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant255NewPlan.Hobby => "hobby",
                UserEventPayloadVariant255NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant255NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant255NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant255NewPlan.Hobby,
                "pro" => UserEventPayloadVariant255NewPlan.Pro,
                _ => null,
            };
        }
    }
}