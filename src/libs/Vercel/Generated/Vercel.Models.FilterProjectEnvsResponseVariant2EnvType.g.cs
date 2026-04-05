
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterProjectEnvsResponseVariant2EnvType
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
    public static class FilterProjectEnvsResponseVariant2EnvTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterProjectEnvsResponseVariant2EnvType value)
        {
            return value switch
            {
                FilterProjectEnvsResponseVariant2EnvType.Encrypted => "encrypted",
                FilterProjectEnvsResponseVariant2EnvType.Plain => "plain",
                FilterProjectEnvsResponseVariant2EnvType.Secret => "secret",
                FilterProjectEnvsResponseVariant2EnvType.Sensitive => "sensitive",
                FilterProjectEnvsResponseVariant2EnvType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterProjectEnvsResponseVariant2EnvType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => FilterProjectEnvsResponseVariant2EnvType.Encrypted,
                "plain" => FilterProjectEnvsResponseVariant2EnvType.Plain,
                "secret" => FilterProjectEnvsResponseVariant2EnvType.Secret,
                "sensitive" => FilterProjectEnvsResponseVariant2EnvType.Sensitive,
                "system" => FilterProjectEnvsResponseVariant2EnvType.System,
                _ => null,
            };
        }
    }
}