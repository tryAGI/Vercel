
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant107UpdateDiffOldTargetItem
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
    public static class UserEventPayloadVariant107UpdateDiffOldTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107UpdateDiffOldTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant107UpdateDiffOldTargetItem.Development => "development",
                UserEventPayloadVariant107UpdateDiffOldTargetItem.Preview => "preview",
                UserEventPayloadVariant107UpdateDiffOldTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107UpdateDiffOldTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant107UpdateDiffOldTargetItem.Development,
                "preview" => UserEventPayloadVariant107UpdateDiffOldTargetItem.Preview,
                "production" => UserEventPayloadVariant107UpdateDiffOldTargetItem.Production,
                _ => null,
            };
        }
    }
}