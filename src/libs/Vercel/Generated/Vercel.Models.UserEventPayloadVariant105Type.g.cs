
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant105Type
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
    public static class UserEventPayloadVariant105TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105Type value)
        {
            return value switch
            {
                UserEventPayloadVariant105Type.Encrypted => "encrypted",
                UserEventPayloadVariant105Type.Plain => "plain",
                UserEventPayloadVariant105Type.Sensitive => "sensitive",
                UserEventPayloadVariant105Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant105Type.Encrypted,
                "plain" => UserEventPayloadVariant105Type.Plain,
                "sensitive" => UserEventPayloadVariant105Type.Sensitive,
                "system" => UserEventPayloadVariant105Type.System,
                _ => null,
            };
        }
    }
}