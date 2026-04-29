
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant113NewEnvVarTargetItem
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
    public static class UserEventPayloadVariant113NewEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113NewEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant113NewEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant113NewEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant113NewEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113NewEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant113NewEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant113NewEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant113NewEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}