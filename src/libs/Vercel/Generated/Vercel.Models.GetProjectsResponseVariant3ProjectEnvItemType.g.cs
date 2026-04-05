
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant3ProjectEnvItemType
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
    public static class GetProjectsResponseVariant3ProjectEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant3ProjectEnvItemType value)
        {
            return value switch
            {
                GetProjectsResponseVariant3ProjectEnvItemType.Encrypted => "encrypted",
                GetProjectsResponseVariant3ProjectEnvItemType.Plain => "plain",
                GetProjectsResponseVariant3ProjectEnvItemType.Secret => "secret",
                GetProjectsResponseVariant3ProjectEnvItemType.Sensitive => "sensitive",
                GetProjectsResponseVariant3ProjectEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant3ProjectEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectsResponseVariant3ProjectEnvItemType.Encrypted,
                "plain" => GetProjectsResponseVariant3ProjectEnvItemType.Plain,
                "secret" => GetProjectsResponseVariant3ProjectEnvItemType.Secret,
                "sensitive" => GetProjectsResponseVariant3ProjectEnvItemType.Sensitive,
                "system" => GetProjectsResponseVariant3ProjectEnvItemType.System,
                _ => null,
            };
        }
    }
}