
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant261NewPlan
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
    public static class UserEventPayloadVariant261NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant261NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant261NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant261NewPlan.Hobby => "hobby",
                UserEventPayloadVariant261NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant261NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant261NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant261NewPlan.Hobby,
                "pro" => UserEventPayloadVariant261NewPlan.Pro,
                _ => null,
            };
        }
    }
}