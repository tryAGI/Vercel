
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum GetProjectEnvResponseVariant3Type
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
        Secret,
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
    public static class GetProjectEnvResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant3Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant3Type.Encrypted => "encrypted",
                GetProjectEnvResponseVariant3Type.Plain => "plain",
                GetProjectEnvResponseVariant3Type.Secret => "secret",
                GetProjectEnvResponseVariant3Type.Sensitive => "sensitive",
                GetProjectEnvResponseVariant3Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectEnvResponseVariant3Type.Encrypted,
                "plain" => GetProjectEnvResponseVariant3Type.Plain,
                "secret" => GetProjectEnvResponseVariant3Type.Secret,
                "sensitive" => GetProjectEnvResponseVariant3Type.Sensitive,
                "system" => GetProjectEnvResponseVariant3Type.System,
                _ => null,
            };
        }
    }
}