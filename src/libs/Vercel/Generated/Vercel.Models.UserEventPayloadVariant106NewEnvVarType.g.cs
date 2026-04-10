
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant106NewEnvVarType
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
    public static class UserEventPayloadVariant106NewEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant106NewEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant106NewEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant106NewEnvVarType.Plain => "plain",
                UserEventPayloadVariant106NewEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant106NewEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant106NewEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant106NewEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant106NewEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant106NewEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant106NewEnvVarType.System,
                _ => null,
            };
        }
    }
}