
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant106OldEnvVarTargetItem
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
    public static class UserEventPayloadVariant106OldEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106OldEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant106OldEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant106OldEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant106OldEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106OldEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant106OldEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant106OldEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant106OldEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}