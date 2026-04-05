
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectEnvResponseVariant1Type
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
    public static class GetProjectEnvResponseVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectEnvResponseVariant1Type value)
        {
            return value switch
            {
                GetProjectEnvResponseVariant1Type.Encrypted => "encrypted",
                GetProjectEnvResponseVariant1Type.Plain => "plain",
                GetProjectEnvResponseVariant1Type.Secret => "secret",
                GetProjectEnvResponseVariant1Type.Sensitive => "sensitive",
                GetProjectEnvResponseVariant1Type.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectEnvResponseVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectEnvResponseVariant1Type.Encrypted,
                "plain" => GetProjectEnvResponseVariant1Type.Plain,
                "secret" => GetProjectEnvResponseVariant1Type.Secret,
                "sensitive" => GetProjectEnvResponseVariant1Type.Sensitive,
                "system" => GetProjectEnvResponseVariant1Type.System,
                _ => null,
            };
        }
    }
}