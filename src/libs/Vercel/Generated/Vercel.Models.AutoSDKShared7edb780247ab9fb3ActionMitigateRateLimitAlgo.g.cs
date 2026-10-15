
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo
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
    public static class AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo.FixedWindow => "fixed_window",
                AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo.FixedWindow,
                "token_bucket" => AutoSDKShared7edb780247ab9fb3ActionMitigateRateLimitAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}