
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMicrofrontendsResponseEnvItemType
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
    public static class UpdateMicrofrontendsResponseEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrofrontendsResponseEnvItemType value)
        {
            return value switch
            {
                UpdateMicrofrontendsResponseEnvItemType.Encrypted => "encrypted",
                UpdateMicrofrontendsResponseEnvItemType.Plain => "plain",
                UpdateMicrofrontendsResponseEnvItemType.Secret => "secret",
                UpdateMicrofrontendsResponseEnvItemType.Sensitive => "sensitive",
                UpdateMicrofrontendsResponseEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrofrontendsResponseEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => UpdateMicrofrontendsResponseEnvItemType.Encrypted,
                "plain" => UpdateMicrofrontendsResponseEnvItemType.Plain,
                "secret" => UpdateMicrofrontendsResponseEnvItemType.Secret,
                "sensitive" => UpdateMicrofrontendsResponseEnvItemType.Sensitive,
                "system" => UpdateMicrofrontendsResponseEnvItemType.System,
                _ => null,
            };
        }
    }
}