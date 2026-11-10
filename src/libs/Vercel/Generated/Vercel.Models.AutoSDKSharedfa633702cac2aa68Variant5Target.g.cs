
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedfa633702cac2aa68Variant5Target
    {
        /// <summary>
        ///
        /// </summary>
        VercelOtelTracesDb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfa633702cac2aa68Variant5TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfa633702cac2aa68Variant5Target value)
        {
            return value switch
            {
                AutoSDKSharedfa633702cac2aa68Variant5Target.VercelOtelTracesDb => "vercel-otel-traces-db",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfa633702cac2aa68Variant5Target? ToEnum(string value)
        {
            return value switch
            {
                "vercel-otel-traces-db" => AutoSDKSharedfa633702cac2aa68Variant5Target.VercelOtelTracesDb,
                _ => null,
            };
        }
    }
}