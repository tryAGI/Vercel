
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor
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
    public static class AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor.EveTracing => "eve-tracing",
                AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor.NextjsTracing => "nextjs-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor.EveTracing,
                "nextjs-tracing" => AutoSDKShared8df5bff0bb4332b8SourceVariant1DefaultFor.NextjsTracing,
                _ => null,
            };
        }
    }
}