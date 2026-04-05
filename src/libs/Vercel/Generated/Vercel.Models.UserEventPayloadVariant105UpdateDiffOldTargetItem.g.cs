
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant105UpdateDiffOldTargetItem
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
    public static class UserEventPayloadVariant105UpdateDiffOldTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105UpdateDiffOldTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant105UpdateDiffOldTargetItem.Development => "development",
                UserEventPayloadVariant105UpdateDiffOldTargetItem.Preview => "preview",
                UserEventPayloadVariant105UpdateDiffOldTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105UpdateDiffOldTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant105UpdateDiffOldTargetItem.Development,
                "preview" => UserEventPayloadVariant105UpdateDiffOldTargetItem.Preview,
                "production" => UserEventPayloadVariant105UpdateDiffOldTargetItem.Production,
                _ => null,
            };
        }
    }
}