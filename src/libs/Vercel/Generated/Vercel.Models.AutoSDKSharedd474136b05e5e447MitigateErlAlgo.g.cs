
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd474136b05e5e447MitigateErlAlgo
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
    public static class AutoSDKSharedd474136b05e5e447MitigateErlAlgoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd474136b05e5e447MitigateErlAlgo value)
        {
            return value switch
            {
                AutoSDKSharedd474136b05e5e447MitigateErlAlgo.FixedWindow => "fixed_window",
                AutoSDKSharedd474136b05e5e447MitigateErlAlgo.TokenBucket => "token_bucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd474136b05e5e447MitigateErlAlgo? ToEnum(string value)
        {
            return value switch
            {
                "fixed_window" => AutoSDKSharedd474136b05e5e447MitigateErlAlgo.FixedWindow,
                "token_bucket" => AutoSDKSharedd474136b05e5e447MitigateErlAlgo.TokenBucket,
                _ => null,
            };
        }
    }
}