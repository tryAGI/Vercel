
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant3EnvType
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
    public static class FilterProjectEnvsResponseVariant3EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant3EnvType value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant3EnvType.Encrypted => "encrypted",
                FilterProjectEnvsResponseVariant3EnvType.Plain => "plain",
                FilterProjectEnvsResponseVariant3EnvType.Secret => "secret",
                FilterProjectEnvsResponseVariant3EnvType.Sensitive => "sensitive",
                FilterProjectEnvsResponseVariant3EnvType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant3EnvType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => FilterProjectEnvsResponseVariant3EnvType.Encrypted,
                "plain" => FilterProjectEnvsResponseVariant3EnvType.Plain,
                "secret" => FilterProjectEnvsResponseVariant3EnvType.Secret,
                "sensitive" => FilterProjectEnvsResponseVariant3EnvType.Sensitive,
                "system" => FilterProjectEnvsResponseVariant3EnvType.System,
                _ => null,
            };
        }
    }
}