
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor
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
    public static class AutoSDKShared92580a598ccc210fSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared92580a598ccc210fSourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}