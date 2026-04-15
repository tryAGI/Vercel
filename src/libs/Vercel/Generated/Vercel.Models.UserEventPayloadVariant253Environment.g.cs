
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant253Environment
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
    public static class UserEventPayloadVariant253EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant253Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant253Environment.Preview => "preview",
                UserEventPayloadVariant253Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant253Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant253Environment.Preview,
                "production" => UserEventPayloadVariant253Environment.Production,
                _ => null,
            };
        }
    }
}