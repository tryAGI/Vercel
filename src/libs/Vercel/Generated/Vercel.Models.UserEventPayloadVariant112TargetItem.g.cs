
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant112TargetItem
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
    public static class UserEventPayloadVariant112TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant112TargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant112TargetItem.Development => "development",
                UserEventPayloadVariant112TargetItem.Preview => "preview",
                UserEventPayloadVariant112TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant112TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant112TargetItem.Development,
                "preview" => UserEventPayloadVariant112TargetItem.Preview,
                "production" => UserEventPayloadVariant112TargetItem.Production,
                _ => null,
            };
        }
    }
}