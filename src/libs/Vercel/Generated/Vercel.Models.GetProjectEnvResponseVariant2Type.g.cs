
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant2Type
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
    public static class GetProjectEnvResponseVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant2Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant2Type.Encrypted => "encrypted",
                GetProjectEnvResponseVariant2Type.Plain => "plain",
                GetProjectEnvResponseVariant2Type.Secret => "secret",
                GetProjectEnvResponseVariant2Type.Sensitive => "sensitive",
                GetProjectEnvResponseVariant2Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectEnvResponseVariant2Type.Encrypted,
                "plain" => GetProjectEnvResponseVariant2Type.Plain,
                "secret" => GetProjectEnvResponseVariant2Type.Secret,
                "sensitive" => GetProjectEnvResponseVariant2Type.Sensitive,
                "system" => GetProjectEnvResponseVariant2Type.System,
                _ => null,
            };
        }
    }
}