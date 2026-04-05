
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant105OldEnvVarType
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
    public static class UserEventPayloadVariant105OldEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105OldEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant105OldEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant105OldEnvVarType.Plain => "plain",
                UserEventPayloadVariant105OldEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant105OldEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105OldEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant105OldEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant105OldEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant105OldEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant105OldEnvVarType.System,
                _ => null,
            };
        }
    }
}