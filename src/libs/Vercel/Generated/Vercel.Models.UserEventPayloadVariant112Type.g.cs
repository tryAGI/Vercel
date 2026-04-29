
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant112Type
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
    public static class UserEventPayloadVariant112TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant112Type value)
        {
            return value switch
            {
                UserEventPayloadVariant112Type.Encrypted => "encrypted",
                UserEventPayloadVariant112Type.Plain => "plain",
                UserEventPayloadVariant112Type.Sensitive => "sensitive",
                UserEventPayloadVariant112Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant112Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant112Type.Encrypted,
                "plain" => UserEventPayloadVariant112Type.Plain,
                "sensitive" => UserEventPayloadVariant112Type.Sensitive,
                "system" => UserEventPayloadVariant112Type.System,
                _ => null,
            };
        }
    }
}