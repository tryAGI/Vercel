
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant107NewEnvVarTargetItem
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
    public static class UserEventPayloadVariant107NewEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107NewEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant107NewEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant107NewEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant107NewEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107NewEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant107NewEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant107NewEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant107NewEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}