
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant106UpdateDiffOldTargetItem
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
    public static class UserEventPayloadVariant106UpdateDiffOldTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106UpdateDiffOldTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant106UpdateDiffOldTargetItem.Development => "development",
                UserEventPayloadVariant106UpdateDiffOldTargetItem.Preview => "preview",
                UserEventPayloadVariant106UpdateDiffOldTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106UpdateDiffOldTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant106UpdateDiffOldTargetItem.Development,
                "preview" => UserEventPayloadVariant106UpdateDiffOldTargetItem.Preview,
                "production" => UserEventPayloadVariant106UpdateDiffOldTargetItem.Production,
                _ => null,
            };
        }
    }
}