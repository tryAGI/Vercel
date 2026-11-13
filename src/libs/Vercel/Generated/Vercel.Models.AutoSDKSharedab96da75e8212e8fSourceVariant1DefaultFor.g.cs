
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor
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
    public static class AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKSharedab96da75e8212e8fSourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}