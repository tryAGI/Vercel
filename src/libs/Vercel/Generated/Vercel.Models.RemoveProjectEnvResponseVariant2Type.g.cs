
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant2Type
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
    public static class RemoveProjectEnvResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant2Type value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant2Type.Encrypted => "encrypted",
                RemoveProjectEnvResponseVariant2Type.Plain => "plain",
                RemoveProjectEnvResponseVariant2Type.Secret => "secret",
                RemoveProjectEnvResponseVariant2Type.Sensitive => "sensitive",
                RemoveProjectEnvResponseVariant2Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => RemoveProjectEnvResponseVariant2Type.Encrypted,
                "plain" => RemoveProjectEnvResponseVariant2Type.Plain,
                "secret" => RemoveProjectEnvResponseVariant2Type.Secret,
                "sensitive" => RemoveProjectEnvResponseVariant2Type.Sensitive,
                "system" => RemoveProjectEnvResponseVariant2Type.System,
                _ => null,
            };
        }
    }
}