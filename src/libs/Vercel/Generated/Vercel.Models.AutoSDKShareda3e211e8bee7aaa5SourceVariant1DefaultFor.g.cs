
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor
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
    public static class AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShareda3e211e8bee7aaa5SourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}