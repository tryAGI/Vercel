
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Informational marker for a system-owned default drain.
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultFor
    {
        /// <summary>
        ///
        /// </summary>
        EveTracing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultForExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultFor value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultFor.EveTracing => "eve-tracing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultFor? ToEnum(string value)
        {
            return value switch
            {
                "eve-tracing" => AutoSDKShared9c06dfe8dd59ad6dSourceVariant1DefaultFor.EveTracing,
                _ => null,
            };
        }
    }
}