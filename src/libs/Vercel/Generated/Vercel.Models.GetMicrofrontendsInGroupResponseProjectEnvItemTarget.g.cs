
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectEnvItemTarget
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
    public static class GetMicrofrontendsInGroupResponseProjectEnvItemTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectEnvItemTarget value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Development => "development",
                GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectEnvItemTarget? ToEnum(string value)
        {
            return value switch
            {
                "development" => GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Development,
                "preview" => GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectEnvItemTarget.Production,
                _ => null,
            };
        }
    }
}