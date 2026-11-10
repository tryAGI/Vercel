
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor
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
    public static class AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared2bfc0b0e9e85f636SourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}