
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant107NewEnvVarType
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
    public static class UserEventPayloadVariant107NewEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107NewEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant107NewEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant107NewEnvVarType.Plain => "plain",
                UserEventPayloadVariant107NewEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant107NewEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107NewEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant107NewEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant107NewEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant107NewEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant107NewEnvVarType.System,
                _ => null,
            };
        }
    }
}