
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant264Plan
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
    public static class UserEventPayloadVariant264PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant264Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant264Plan.Enterprise => "enterprise",
                UserEventPayloadVariant264Plan.Hobby => "hobby",
                UserEventPayloadVariant264Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant264Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant264Plan.Enterprise,
                "hobby" => UserEventPayloadVariant264Plan.Hobby,
                "pro" => UserEventPayloadVariant264Plan.Pro,
                _ => null,
            };
        }
    }
}