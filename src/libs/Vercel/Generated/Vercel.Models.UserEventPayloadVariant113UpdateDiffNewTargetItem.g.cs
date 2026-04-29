
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant113UpdateDiffNewTargetItem
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
    public static class UserEventPayloadVariant113UpdateDiffNewTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113UpdateDiffNewTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant113UpdateDiffNewTargetItem.Development => "development",
                UserEventPayloadVariant113UpdateDiffNewTargetItem.Preview => "preview",
                UserEventPayloadVariant113UpdateDiffNewTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113UpdateDiffNewTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant113UpdateDiffNewTargetItem.Development,
                "preview" => UserEventPayloadVariant113UpdateDiffNewTargetItem.Preview,
                "production" => UserEventPayloadVariant113UpdateDiffNewTargetItem.Production,
                _ => null,
            };
        }
    }
}