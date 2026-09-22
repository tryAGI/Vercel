
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor
    {
        /// <summary>
        ///
        /// </summary>
        EveTracing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKSharedc396e89a7a8d84fbSourceVariant1DefaultFor.EveTracing,
                _ => null,
            };
        }
    }
}