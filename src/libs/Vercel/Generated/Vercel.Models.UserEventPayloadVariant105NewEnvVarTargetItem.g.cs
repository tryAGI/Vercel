
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum UserEventPayloadVariant105NewEnvVarTargetItem
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
    public static class UserEventPayloadVariant105NewEnvVarTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105NewEnvVarTargetItem value)
        {
            return value switch
            {
                UserEventPayloadVariant105NewEnvVarTargetItem.Development => "development",
                UserEventPayloadVariant105NewEnvVarTargetItem.Preview => "preview",
                UserEventPayloadVariant105NewEnvVarTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105NewEnvVarTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => UserEventPayloadVariant105NewEnvVarTargetItem.Development,
                "preview" => UserEventPayloadVariant105NewEnvVarTargetItem.Preview,
                "production" => UserEventPayloadVariant105NewEnvVarTargetItem.Production,
                _ => null,
            };
        }
    }
}