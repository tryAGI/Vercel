
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant105OldEnvVarTargetItem
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
    public static class UserEventPayloadVariant105OldEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105OldEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant105OldEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant105OldEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant105OldEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105OldEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant105OldEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant105OldEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant105OldEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}