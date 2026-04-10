
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant106NewEnvVarTargetItem
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
    public static class UserEventPayloadVariant106NewEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106NewEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant106NewEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant106NewEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant106NewEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106NewEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant106NewEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant106NewEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant106NewEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}