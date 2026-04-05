
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectResponseEnvItemType
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
    public static class UpdateProjectResponseEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectResponseEnvItemType value)
        {
            return value switch
            {
                UpdateProjectResponseEnvItemType.Encrypted => "encrypted",
                UpdateProjectResponseEnvItemType.Plain => "plain",
                UpdateProjectResponseEnvItemType.Secret => "secret",
                UpdateProjectResponseEnvItemType.Sensitive => "sensitive",
                UpdateProjectResponseEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectResponseEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UpdateProjectResponseEnvItemType.Encrypted,
                "plain" => UpdateProjectResponseEnvItemType.Plain,
                "secret" => UpdateProjectResponseEnvItemType.Secret,
                "sensitive" => UpdateProjectResponseEnvItemType.Sensitive,
                "system" => UpdateProjectResponseEnvItemType.System,
                _ => null,
            };
        }
    }
}