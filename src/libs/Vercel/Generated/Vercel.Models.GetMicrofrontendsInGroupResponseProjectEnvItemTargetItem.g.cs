
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Development => "development",
                GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Development,
                "preview" => GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectEnvItemTargetItem.Production,
                _ => null,
            };
        }
    }
}