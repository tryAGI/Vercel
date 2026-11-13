
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor
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
    public static class AutoSDKShared0001bb8e789a120eSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared0001bb8e789a120eSourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}