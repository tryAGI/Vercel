
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant257Plan
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
    public static class UserEventPayloadVariant257PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant257Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant257Plan.Enterprise => "enterprise",
                UserEventPayloadVariant257Plan.Hobby => "hobby",
                UserEventPayloadVariant257Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant257Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant257Plan.Enterprise,
                "hobby" => UserEventPayloadVariant257Plan.Hobby,
                "pro" => UserEventPayloadVariant257Plan.Pro,
                _ => null,
            };
        }
    }
}