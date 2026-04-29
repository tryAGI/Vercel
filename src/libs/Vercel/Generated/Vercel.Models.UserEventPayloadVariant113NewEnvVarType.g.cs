
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant113NewEnvVarType
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
    public static class UserEventPayloadVariant113NewEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant113NewEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant113NewEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant113NewEnvVarType.Plain => "plain",
                UserEventPayloadVariant113NewEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant113NewEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant113NewEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant113NewEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant113NewEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant113NewEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant113NewEnvVarType.System,
                _ => null,
            };
        }
    }
}