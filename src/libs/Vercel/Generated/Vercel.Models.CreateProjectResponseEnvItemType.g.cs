
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectResponseEnvItemType
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
    public static class CreateProjectResponseEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseEnvItemType value)
        {
            return value switch
            {
                CreateProjectResponseEnvItemType.Encrypted => "encrypted",
                CreateProjectResponseEnvItemType.Plain => "plain",
                CreateProjectResponseEnvItemType.Secret => "secret",
                CreateProjectResponseEnvItemType.Sensitive => "sensitive",
                CreateProjectResponseEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => CreateProjectResponseEnvItemType.Encrypted,
                "plain" => CreateProjectResponseEnvItemType.Plain,
                "secret" => CreateProjectResponseEnvItemType.Secret,
                "sensitive" => CreateProjectResponseEnvItemType.Sensitive,
                "system" => CreateProjectResponseEnvItemType.System,
                _ => null,
            };
        }
    }
}