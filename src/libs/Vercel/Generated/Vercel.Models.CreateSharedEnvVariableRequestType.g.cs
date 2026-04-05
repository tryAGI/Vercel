
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of environment variable<br/>
    /// Example: encrypted
    /// </summary>
    public enum CreateSharedEnvVariableRequestType
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
    public static class CreateSharedEnvVariableRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSharedEnvVariableRequestType value)
        {
            return value switch
            {
                CreateSharedEnvVariableRequestType.Encrypted => "encrypted",
                CreateSharedEnvVariableRequestType.Sensitive => "sensitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSharedEnvVariableRequestType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateSharedEnvVariableRequestType.Encrypted,
                "sensitive" => CreateSharedEnvVariableRequestType.Sensitive,
                _ => null,
            };
        }
    }
}