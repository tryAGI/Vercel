
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor
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
    public static class AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared9f8c0585e20078fcSourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}