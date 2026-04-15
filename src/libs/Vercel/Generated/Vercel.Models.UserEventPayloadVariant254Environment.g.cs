
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant254Environment
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
    public static class UserEventPayloadVariant254EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant254Environment value)
        {
            return value switch
            {
                UserEventPayloadVariant254Environment.Preview => "preview",
                UserEventPayloadVariant254Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant254Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UserEventPayloadVariant254Environment.Preview,
                "production" => UserEventPayloadVariant254Environment.Production,
                _ => null,
            };
        }
    }
}