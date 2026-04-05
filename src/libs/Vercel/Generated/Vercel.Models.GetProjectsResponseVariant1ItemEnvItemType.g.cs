
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemEnvItemType
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
    public static class GetProjectsResponseVariant1ItemEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemEnvItemType value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemEnvItemType.Encrypted => "encrypted",
                GetProjectsResponseVariant1ItemEnvItemType.Plain => "plain",
                GetProjectsResponseVariant1ItemEnvItemType.Secret => "secret",
                GetProjectsResponseVariant1ItemEnvItemType.Sensitive => "sensitive",
                GetProjectsResponseVariant1ItemEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectsResponseVariant1ItemEnvItemType.Encrypted,
                "plain" => GetProjectsResponseVariant1ItemEnvItemType.Plain,
                "secret" => GetProjectsResponseVariant1ItemEnvItemType.Secret,
                "sensitive" => GetProjectsResponseVariant1ItemEnvItemType.Sensitive,
                "system" => GetProjectsResponseVariant1ItemEnvItemType.System,
                _ => null,
            };
        }
    }
}