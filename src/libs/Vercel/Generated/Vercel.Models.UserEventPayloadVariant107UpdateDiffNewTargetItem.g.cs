
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant107UpdateDiffNewTargetItem
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
    public static class UserEventPayloadVariant107UpdateDiffNewTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107UpdateDiffNewTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant107UpdateDiffNewTargetItem.Development => "development",
                UserEventPayloadVariant107UpdateDiffNewTargetItem.Preview => "preview",
                UserEventPayloadVariant107UpdateDiffNewTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107UpdateDiffNewTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant107UpdateDiffNewTargetItem.Development,
                "preview" => UserEventPayloadVariant107UpdateDiffNewTargetItem.Preview,
                "production" => UserEventPayloadVariant107UpdateDiffNewTargetItem.Production,
                _ => null,
            };
        }
    }
}