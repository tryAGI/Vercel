
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The type of this cosmos doc instance, if blank, assume secret.<br/>
    /// Example: encrypted
    /// </summary>
    public enum GetSharedEnvVarResponseType
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
    public static class GetSharedEnvVarResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSharedEnvVarResponseType value)
        {
            return value switch
            {
                GetSharedEnvVarResponseType.Encrypted => "encrypted",
                GetSharedEnvVarResponseType.Plain => "plain",
                GetSharedEnvVarResponseType.Sensitive => "sensitive",
                GetSharedEnvVarResponseType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSharedEnvVarResponseType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetSharedEnvVarResponseType.Encrypted,
                "plain" => GetSharedEnvVarResponseType.Plain,
                "sensitive" => GetSharedEnvVarResponseType.Sensitive,
                "system" => GetSharedEnvVarResponseType.System,
                _ => null,
            };
        }
    }
}