
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant262NewPlan
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
    public static class UserEventPayloadVariant262NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant262NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant262NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant262NewPlan.Hobby => "hobby",
                UserEventPayloadVariant262NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant262NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant262NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant262NewPlan.Hobby,
                "pro" => UserEventPayloadVariant262NewPlan.Pro,
                _ => null,
            };
        }
    }
}