
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant284Plan
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
    public static class UserEventPayloadVariant284PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant284Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant284Plan.Enterprise => "enterprise",
                UserEventPayloadVariant284Plan.Hobby => "hobby",
                UserEventPayloadVariant284Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant284Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant284Plan.Enterprise,
                "hobby" => UserEventPayloadVariant284Plan.Hobby,
                "pro" => UserEventPayloadVariant284Plan.Pro,
                _ => null,
            };
        }
    }
}