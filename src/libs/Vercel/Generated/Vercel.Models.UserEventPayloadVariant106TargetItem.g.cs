
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant106TargetItem
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
    public static class UserEventPayloadVariant106TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106TargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant106TargetItem.Development => "development",
                UserEventPayloadVariant106TargetItem.Preview => "preview",
                UserEventPayloadVariant106TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant106TargetItem.Development,
                "preview" => UserEventPayloadVariant106TargetItem.Preview,
                "production" => UserEventPayloadVariant106TargetItem.Production,
                _ => null,
            };
        }
    }
}