
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant106Type
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
    public static class UserEventPayloadVariant106TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106Type value)
        {
            return value switch
            {
                UserEventPayloadVariant106Type.Encrypted => "encrypted",
                UserEventPayloadVariant106Type.Plain => "plain",
                UserEventPayloadVariant106Type.Sensitive => "sensitive",
                UserEventPayloadVariant106Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant106Type.Encrypted,
                "plain" => UserEventPayloadVariant106Type.Plain,
                "sensitive" => UserEventPayloadVariant106Type.Sensitive,
                "system" => UserEventPayloadVariant106Type.System,
                _ => null,
            };
        }
    }
}