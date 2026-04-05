
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant104TargetItem
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant104TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant104TargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant104TargetItem.Development => "development",
                UserEventPayloadVariant104TargetItem.Preview => "preview",
                UserEventPayloadVariant104TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant104TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant104TargetItem.Development,
                "preview" => UserEventPayloadVariant104TargetItem.Preview,
                "production" => UserEventPayloadVariant104TargetItem.Production,
                _ => null,
            };
        }
    }
}