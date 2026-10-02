
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKind
    {
        /// <summary>
        ///
        /// </summary>
        VercelCi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKind value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKind.VercelCi => "vercel-ci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKind? ToEnum(string value)
        {
            return value switch
            {
                "vercel-ci" => AutoSDKSharedca611ecff4bbfd16SourceVariant1SubKind.VercelCi,
                _ => null,
            };
        }
    }
}