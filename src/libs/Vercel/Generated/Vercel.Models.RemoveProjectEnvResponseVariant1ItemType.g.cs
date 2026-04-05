
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum RemoveProjectEnvResponseVariant1ItemType
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
    public static class RemoveProjectEnvResponseVariant1ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveProjectEnvResponseVariant1ItemType value)
        {
            return value switch
            {
                RemoveProjectEnvResponseVariant1ItemType.Encrypted => "encrypted",
                RemoveProjectEnvResponseVariant1ItemType.Plain => "plain",
                RemoveProjectEnvResponseVariant1ItemType.Secret => "secret",
                RemoveProjectEnvResponseVariant1ItemType.Sensitive => "sensitive",
                RemoveProjectEnvResponseVariant1ItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveProjectEnvResponseVariant1ItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => RemoveProjectEnvResponseVariant1ItemType.Encrypted,
                "plain" => RemoveProjectEnvResponseVariant1ItemType.Plain,
                "secret" => RemoveProjectEnvResponseVariant1ItemType.Secret,
                "sensitive" => RemoveProjectEnvResponseVariant1ItemType.Sensitive,
                "system" => RemoveProjectEnvResponseVariant1ItemType.System,
                _ => null,
            };
        }
    }
}