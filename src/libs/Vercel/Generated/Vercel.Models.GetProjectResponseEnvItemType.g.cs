
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectResponseEnvItemType
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
    public static class GetProjectResponseEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectResponseEnvItemType value)
        {
            return value switch
            {
                GetProjectResponseEnvItemType.Encrypted => "encrypted",
                GetProjectResponseEnvItemType.Plain => "plain",
                GetProjectResponseEnvItemType.Secret => "secret",
                GetProjectResponseEnvItemType.Sensitive => "sensitive",
                GetProjectResponseEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectResponseEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetProjectResponseEnvItemType.Encrypted,
                "plain" => GetProjectResponseEnvItemType.Plain,
                "secret" => GetProjectResponseEnvItemType.Secret,
                "sensitive" => GetProjectResponseEnvItemType.Sensitive,
                "system" => GetProjectResponseEnvItemType.System,
                _ => null,
            };
        }
    }
}