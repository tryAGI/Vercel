
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbca3e7a986162538ChecksConclusion
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedbca3e7a986162538ChecksConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbca3e7a986162538ChecksConclusion value)
        {
            return value switch
            {
                AutoSDKSharedbca3e7a986162538ChecksConclusion.Canceled => "canceled",
                AutoSDKSharedbca3e7a986162538ChecksConclusion.Failed => "failed",
                AutoSDKSharedbca3e7a986162538ChecksConclusion.Skipped => "skipped",
                AutoSDKSharedbca3e7a986162538ChecksConclusion.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbca3e7a986162538ChecksConclusion? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => AutoSDKSharedbca3e7a986162538ChecksConclusion.Canceled,
                "failed" => AutoSDKSharedbca3e7a986162538ChecksConclusion.Failed,
                "skipped" => AutoSDKSharedbca3e7a986162538ChecksConclusion.Skipped,
                "succeeded" => AutoSDKSharedbca3e7a986162538ChecksConclusion.Succeeded,
                _ => null,
            };
        }
    }
}