
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo
    {
        /// <summary>
        /// 
        /// </summary>
        FixedWindow,
        /// <summary>
        /// 
        /// </summary>
        TokenBucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => UploadProjectAvatarResponseSecurityRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}