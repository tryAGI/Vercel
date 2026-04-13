
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant107OldEnvVarTargetItem
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
    public static class UserEventPayloadVariant107OldEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107OldEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant107OldEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant107OldEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant107OldEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107OldEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant107OldEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant107OldEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant107OldEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}