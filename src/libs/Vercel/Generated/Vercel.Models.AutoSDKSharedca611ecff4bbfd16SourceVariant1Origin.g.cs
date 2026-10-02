
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedca611ecff4bbfd16SourceVariant1Origin
    {
        /// <summary>
        ///
        /// </summary>
        Config,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedca611ecff4bbfd16SourceVariant1OriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedca611ecff4bbfd16SourceVariant1Origin value)
        {
            return value switch
            {
                AutoSDKSharedca611ecff4bbfd16SourceVariant1Origin.Config => "config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedca611ecff4bbfd16SourceVariant1Origin? ToEnum(string value)
        {
            return value switch
            {
                "config" => AutoSDKSharedca611ecff4bbfd16SourceVariant1Origin.Config,
                _ => null,
            };
        }
    }
}