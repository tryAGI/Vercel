
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared29b35dda7b3e47c4Environment
    {
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared29b35dda7b3e47c4EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared29b35dda7b3e47c4Environment value)
        {
            return value switch
            {
                AutoSDKShared29b35dda7b3e47c4Environment.Preview => "preview",
                AutoSDKShared29b35dda7b3e47c4Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared29b35dda7b3e47c4Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKShared29b35dda7b3e47c4Environment.Preview,
                "production" => AutoSDKShared29b35dda7b3e47c4Environment.Production,
                _ => null,
            };
        }
    }
}