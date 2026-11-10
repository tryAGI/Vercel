
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor
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
    public static class AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShareda861c3cb40ec56dcSourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}