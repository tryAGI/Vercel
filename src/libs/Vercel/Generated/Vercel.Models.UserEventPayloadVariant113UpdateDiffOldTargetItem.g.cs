
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant113UpdateDiffOldTargetItem
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
    public static class UserEventPayloadVariant113UpdateDiffOldTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113UpdateDiffOldTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant113UpdateDiffOldTargetItem.Development => "development",
                UserEventPayloadVariant113UpdateDiffOldTargetItem.Preview => "preview",
                UserEventPayloadVariant113UpdateDiffOldTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113UpdateDiffOldTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant113UpdateDiffOldTargetItem.Development,
                "preview" => UserEventPayloadVariant113UpdateDiffOldTargetItem.Preview,
                "production" => UserEventPayloadVariant113UpdateDiffOldTargetItem.Production,
                _ => null,
            };
        }
    }
}