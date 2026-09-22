
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo
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
    public static class AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared08bf5d361fc08707ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}