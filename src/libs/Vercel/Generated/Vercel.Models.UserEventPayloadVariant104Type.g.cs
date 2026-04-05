
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant104Type
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        Plain,
        /// <summary>
        /// 
        /// </summary>
        Sensitive,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant104TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant104Type value)
        {
            return value switch
            {
                UserEventPayloadVariant104Type.Encrypted => "encrypted",
                UserEventPayloadVariant104Type.Plain => "plain",
                UserEventPayloadVariant104Type.Sensitive => "sensitive",
                UserEventPayloadVariant104Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant104Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant104Type.Encrypted,
                "plain" => UserEventPayloadVariant104Type.Plain,
                "sensitive" => UserEventPayloadVariant104Type.Sensitive,
                "system" => UserEventPayloadVariant104Type.System,
                _ => null,
            };
        }
    }
}