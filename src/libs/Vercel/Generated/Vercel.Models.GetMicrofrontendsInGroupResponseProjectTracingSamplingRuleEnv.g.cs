
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv
    {
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
    public static class GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv.Preview => "preview",
                GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv.Preview,
                "production" => GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}