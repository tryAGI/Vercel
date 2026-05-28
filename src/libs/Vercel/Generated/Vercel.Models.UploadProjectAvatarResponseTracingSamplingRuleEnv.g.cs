
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseTracingSamplingRuleEnv
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
    public static class UploadProjectAvatarResponseTracingSamplingRuleEnvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseTracingSamplingRuleEnv value)
        {
            return value switch
            {
                UploadProjectAvatarResponseTracingSamplingRuleEnv.Preview => "preview",
                UploadProjectAvatarResponseTracingSamplingRuleEnv.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseTracingSamplingRuleEnv? ToEnum(string value)
        {
            return value switch
            {
                "preview" => UploadProjectAvatarResponseTracingSamplingRuleEnv.Preview,
                "production" => UploadProjectAvatarResponseTracingSamplingRuleEnv.Production,
                _ => null,
            };
        }
    }
}