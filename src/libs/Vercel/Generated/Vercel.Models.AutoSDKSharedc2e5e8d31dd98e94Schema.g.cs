
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc2e5e8d31dd98e94Schema
    {
        /// <summary>
        ///
        /// </summary>
        ExperimentalServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc2e5e8d31dd98e94SchemaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc2e5e8d31dd98e94Schema value)
        {
            return value switch
            {
                AutoSDKSharedc2e5e8d31dd98e94Schema.ExperimentalServices => "experimentalServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc2e5e8d31dd98e94Schema? ToEnum(string value)
        {
            return value switch
            {
                "experimentalServices" => AutoSDKSharedc2e5e8d31dd98e94Schema.ExperimentalServices,
                _ => null,
            };
        }
    }
}