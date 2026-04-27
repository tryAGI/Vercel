
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant277Plan
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
    public static class UserEventPayloadVariant277PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant277Plan value)
        {
            return value switch
            {
                UserEventPayloadVariant277Plan.Enterprise => "enterprise",
                UserEventPayloadVariant277Plan.Hobby => "hobby",
                UserEventPayloadVariant277Plan.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant277Plan? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => UserEventPayloadVariant277Plan.Enterprise,
                "hobby" => UserEventPayloadVariant277Plan.Hobby,
                "pro" => UserEventPayloadVariant277Plan.Pro,
                _ => null,
            };
        }
    }
}