
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant3Type
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
    public static class RemoveProjectEnvResponseVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant3Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant3Type.Encrypted => "encrypted",
                RemoveProjectEnvResponseVariant3Type.Plain => "plain",
                RemoveProjectEnvResponseVariant3Type.Secret => "secret",
                RemoveProjectEnvResponseVariant3Type.Sensitive => "sensitive",
                RemoveProjectEnvResponseVariant3Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => RemoveProjectEnvResponseVariant3Type.Encrypted,
                "plain" => RemoveProjectEnvResponseVariant3Type.Plain,
                "secret" => RemoveProjectEnvResponseVariant3Type.Secret,
                "sensitive" => RemoveProjectEnvResponseVariant3Type.Sensitive,
                "system" => RemoveProjectEnvResponseVariant3Type.System,
                _ => null,
            };
        }
    }
}