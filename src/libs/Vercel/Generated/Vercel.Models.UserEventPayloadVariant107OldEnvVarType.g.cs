
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum UserEventPayloadVariant107OldEnvVarType
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
    public static class UserEventPayloadVariant107OldEnvVarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant107OldEnvVarType value)
        {
            return value switch
            {
                UserEventPayloadVariant107OldEnvVarType.Encrypted => "encrypted",
                UserEventPayloadVariant107OldEnvVarType.Plain => "plain",
                UserEventPayloadVariant107OldEnvVarType.Sensitive => "sensitive",
                UserEventPayloadVariant107OldEnvVarType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant107OldEnvVarType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UserEventPayloadVariant107OldEnvVarType.Encrypted,
                "plain" => UserEventPayloadVariant107OldEnvVarType.Plain,
                "sensitive" => UserEventPayloadVariant107OldEnvVarType.Sensitive,
                "system" => UserEventPayloadVariant107OldEnvVarType.System,
                _ => null,
            };
        }
    }
}