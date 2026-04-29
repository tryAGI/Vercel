
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant113OldEnvVarType
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
    public static class UserEventPayloadVariant113OldEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113OldEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant113OldEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant113OldEnvVarType.Plain => "plain",
                UserEventPayloadVariant113OldEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant113OldEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113OldEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant113OldEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant113OldEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant113OldEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant113OldEnvVarType.System,
                _ => null,
            };
        }
    }
}