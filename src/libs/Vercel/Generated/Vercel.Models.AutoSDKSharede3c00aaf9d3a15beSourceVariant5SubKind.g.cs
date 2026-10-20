
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCiCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind value)
        {
            return value switch
            {
                AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind.VercelCiCheck => "vercel-ci-check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci-check" => AutoSDKSharede3c00aaf9d3a15beSourceVariant5SubKind.VercelCiCheck,
                _ => null,
            };
        }
    }
}