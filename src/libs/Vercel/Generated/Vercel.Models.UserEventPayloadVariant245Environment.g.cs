
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant245Environment
    {
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
    public static class UserEventPayloadVariant245EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant245Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant245Environment.Preview => "preview",
                UserEventPayloadVariant245Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant245Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant245Environment.Preview,
                "production" => UserEventPayloadVariant245Environment.Production,
                _ => null,
            };
        }
    }
}