
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant268Environment
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
    public static class UserEventPayloadVariant268EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant268Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant268Environment.Preview => "preview",
                UserEventPayloadVariant268Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant268Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant268Environment.Preview,
                "production" => UserEventPayloadVariant268Environment.Production,
                _ => null,
            };
        }
    }
}