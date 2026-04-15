
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260NewPlan
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
    public static class UserEventPayloadVariant260NewPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260NewPlan value)
        {
            return value switch
            {
                UserEventPayloadVariant260NewPlan.Enterprise => "enterprise",
                UserEventPayloadVariant260NewPlan.Hobby => "hobby",
                UserEventPayloadVariant260NewPlan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260NewPlan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant260NewPlan.Enterprise,
                "hobby" => UserEventPayloadVariant260NewPlan.Hobby,
                "pro" => UserEventPayloadVariant260NewPlan.Pro,
                _ => null,
            };
        }
    }
}