
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant105TargetItem
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
    public static class UserEventPayloadVariant105TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105TargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant105TargetItem.Development => "development",
                UserEventPayloadVariant105TargetItem.Preview => "preview",
                UserEventPayloadVariant105TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant105TargetItem.Development,
                "preview" => UserEventPayloadVariant105TargetItem.Preview,
                "production" => UserEventPayloadVariant105TargetItem.Production,
                _ => null,
            };
        }
    }
}