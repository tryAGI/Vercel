
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor
    {
        /// <summary>
        ///
        /// </summary>
        EveTracing,
        /// <summary>
        ///
        /// </summary>
        NextjsTracing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKSharedd5d6c9ab94c25f66SourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}