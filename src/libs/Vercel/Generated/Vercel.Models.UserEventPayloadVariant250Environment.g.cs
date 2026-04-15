
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant250Environment
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
    public static class UserEventPayloadVariant250EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant250Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant250Environment.Preview => "preview",
                UserEventPayloadVariant250Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant250Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant250Environment.Preview,
                "production" => UserEventPayloadVariant250Environment.Production,
                _ => null,
            };
        }
    }
}