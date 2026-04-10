
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant106UpdateDiffNewTargetItem
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
    public static class UserEventPayloadVariant106UpdateDiffNewTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106UpdateDiffNewTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant106UpdateDiffNewTargetItem.Development => "development",
                UserEventPayloadVariant106UpdateDiffNewTargetItem.Preview => "preview",
                UserEventPayloadVariant106UpdateDiffNewTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106UpdateDiffNewTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant106UpdateDiffNewTargetItem.Development,
                "preview" => UserEventPayloadVariant106UpdateDiffNewTargetItem.Preview,
                "production" => UserEventPayloadVariant106UpdateDiffNewTargetItem.Production,
                _ => null,
            };
        }
    }
}