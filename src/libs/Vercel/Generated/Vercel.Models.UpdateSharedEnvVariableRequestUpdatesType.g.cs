
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The new type of the Shared Environment Variable<br/>
    /// Example: encrypted
    /// </summary>
    public enum UpdateSharedEnvVariableRequestUpdatesType
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        Sensitive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSharedEnvVariableRequestUpdatesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSharedEnvVariableRequestUpdatesType value)
        {
            return value switch
            {
                UpdateSharedEnvVariableRequestUpdatesType.Encrypted => "encrypted",
                UpdateSharedEnvVariableRequestUpdatesType.Sensitive => "sensitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSharedEnvVariableRequestUpdatesType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UpdateSharedEnvVariableRequestUpdatesType.Encrypted,
                "sensitive" => UpdateSharedEnvVariableRequestUpdatesType.Sensitive,
                _ => null,
            };
        }
    }
}