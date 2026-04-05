
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant105UpdateDiffNewTargetItem
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
    public static class UserEventPayloadVariant105UpdateDiffNewTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105UpdateDiffNewTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant105UpdateDiffNewTargetItem.Development => "development",
                UserEventPayloadVariant105UpdateDiffNewTargetItem.Preview => "preview",
                UserEventPayloadVariant105UpdateDiffNewTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105UpdateDiffNewTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant105UpdateDiffNewTargetItem.Development,
                "preview" => UserEventPayloadVariant105UpdateDiffNewTargetItem.Preview,
                "production" => UserEventPayloadVariant105UpdateDiffNewTargetItem.Production,
                _ => null,
            };
        }
    }
}