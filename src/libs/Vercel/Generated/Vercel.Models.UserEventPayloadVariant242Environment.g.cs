
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant242Environment
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
    public static class UserEventPayloadVariant242EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant242Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant242Environment.Preview => "preview",
                UserEventPayloadVariant242Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant242Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant242Environment.Preview,
                "production" => UserEventPayloadVariant242Environment.Production,
                _ => null,
            };
        }
    }
}