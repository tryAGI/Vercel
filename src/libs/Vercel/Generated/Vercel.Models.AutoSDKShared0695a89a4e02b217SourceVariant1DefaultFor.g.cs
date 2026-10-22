
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217SourceVariant1DefaultFor
    {
        /// <summary>
        ///
        /// </summary>
        EveTracing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0695a89a4e02b217SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared0695a89a4e02b217SourceVariant1DefaultFor.EveTracing,
                _ => null,
            };
        }
    }
}