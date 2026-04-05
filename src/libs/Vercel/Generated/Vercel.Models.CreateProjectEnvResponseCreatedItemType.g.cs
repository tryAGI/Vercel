
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectEnvResponseCreatedItemType
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
    public static class CreateProjectEnvResponseCreatedItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectEnvResponseCreatedItemType value)
        {
            return value switch
            {
                CreateProjectEnvResponseCreatedItemType.Encrypted => "encrypted",
                CreateProjectEnvResponseCreatedItemType.Plain => "plain",
                CreateProjectEnvResponseCreatedItemType.Secret => "secret",
                CreateProjectEnvResponseCreatedItemType.Sensitive => "sensitive",
                CreateProjectEnvResponseCreatedItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectEnvResponseCreatedItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectEnvResponseCreatedItemType.Encrypted,
                "plain" => CreateProjectEnvResponseCreatedItemType.Plain,
                "secret" => CreateProjectEnvResponseCreatedItemType.Secret,
                "sensitive" => CreateProjectEnvResponseCreatedItemType.Sensitive,
                "system" => CreateProjectEnvResponseCreatedItemType.System,
                _ => null,
            };
        }
    }
}