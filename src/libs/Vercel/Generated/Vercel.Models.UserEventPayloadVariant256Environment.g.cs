
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant256Environment
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
    public static class UserEventPayloadVariant256EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant256Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant256Environment.Preview => "preview",
                UserEventPayloadVariant256Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant256Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant256Environment.Preview,
                "production" => UserEventPayloadVariant256Environment.Production,
                _ => null,
            };
        }
    }
}