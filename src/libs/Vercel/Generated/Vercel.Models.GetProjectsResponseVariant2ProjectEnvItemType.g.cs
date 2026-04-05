
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant2ProjectEnvItemType
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
    public static class GetProjectsResponseVariant2ProjectEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant2ProjectEnvItemType value)
        {
            return value switch
            {
                GetProjectsResponseVariant2ProjectEnvItemType.Encrypted => "encrypted",
                GetProjectsResponseVariant2ProjectEnvItemType.Plain => "plain",
                GetProjectsResponseVariant2ProjectEnvItemType.Secret => "secret",
                GetProjectsResponseVariant2ProjectEnvItemType.Sensitive => "sensitive",
                GetProjectsResponseVariant2ProjectEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant2ProjectEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectsResponseVariant2ProjectEnvItemType.Encrypted,
                "plain" => GetProjectsResponseVariant2ProjectEnvItemType.Plain,
                "secret" => GetProjectsResponseVariant2ProjectEnvItemType.Secret,
                "sensitive" => GetProjectsResponseVariant2ProjectEnvItemType.Sensitive,
                "system" => GetProjectsResponseVariant2ProjectEnvItemType.System,
                _ => null,
            };
        }
    }
}