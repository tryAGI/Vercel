
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant105NewEnvVarType
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
    public static class UserEventPayloadVariant105NewEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant105NewEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant105NewEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant105NewEnvVarType.Plain => "plain",
                UserEventPayloadVariant105NewEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant105NewEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant105NewEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant105NewEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant105NewEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant105NewEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant105NewEnvVarType.System,
                _ => null,
            };
        }
    }
}