
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant253NewPlan
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
    public static class UserEventPayloadVariant253NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant253NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant253NewPlan.Hobby => "hobby",
                UserEventPayloadVariant253NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant253NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant253NewPlan.Hobby,
                "pro" => UserEventPayloadVariant253NewPlan.Pro,
                _ => null,
            };
        }
    }
}