
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor
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
    public static class AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared2b02cf1378da97a7SourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}