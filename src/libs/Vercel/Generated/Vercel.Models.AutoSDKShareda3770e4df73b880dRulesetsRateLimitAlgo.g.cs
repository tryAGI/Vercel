
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo
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
    public static class AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShareda3770e4df73b880dRulesetsRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}