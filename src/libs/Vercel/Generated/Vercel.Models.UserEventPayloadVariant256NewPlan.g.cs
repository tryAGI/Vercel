
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256NewPlan
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
    public static class UserEventPayloadVariant256NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant256NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant256NewPlan.Hobby => "hobby",
                UserEventPayloadVariant256NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant256NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant256NewPlan.Hobby,
                "pro" => UserEventPayloadVariant256NewPlan.Pro,
                _ => null,
            };
        }
    }
}