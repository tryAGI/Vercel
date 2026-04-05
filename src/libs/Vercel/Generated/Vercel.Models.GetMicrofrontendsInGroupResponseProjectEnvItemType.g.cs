
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemType
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
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemType value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemType.Encrypted => "encrypted",
                GetMicrofrontendsInGroupResponseProjectEnvItemType.Plain => "plain",
                GetMicrofrontendsInGroupResponseProjectEnvItemType.Secret => "secret",
                GetMicrofrontendsInGroupResponseProjectEnvItemType.Sensitive => "sensitive",
                GetMicrofrontendsInGroupResponseProjectEnvItemType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => GetMicrofrontendsInGroupResponseProjectEnvItemType.Encrypted,
                "plain" => GetMicrofrontendsInGroupResponseProjectEnvItemType.Plain,
                "secret" => GetMicrofrontendsInGroupResponseProjectEnvItemType.Secret,
                "sensitive" => GetMicrofrontendsInGroupResponseProjectEnvItemType.Sensitive,
                "system" => GetMicrofrontendsInGroupResponseProjectEnvItemType.System,
                _ => null,
            };
        }
    }
}