
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant260Plan
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
    public static class UserEventPayloadVariant260PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant260Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant260Plan.Enterprise => "enterprise",
                UserEventPayloadVariant260Plan.Hobby => "hobby",
                UserEventPayloadVariant260Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant260Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant260Plan.Enterprise,
                "hobby" => UserEventPayloadVariant260Plan.Hobby,
                "pro" => UserEventPayloadVariant260Plan.Pro,
                _ => null,
            };
        }
    }
}