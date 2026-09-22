
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedbc14f6f0dbfaa660Environment
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
    public static class AutoSDKSharedbc14f6f0dbfaa660EnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedbc14f6f0dbfaa660Environment value)
        {
            return value switch
            {
                AutoSDKSharedbc14f6f0dbfaa660Environment.Preview => "preview",
                AutoSDKSharedbc14f6f0dbfaa660Environment.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedbc14f6f0dbfaa660Environment? ToEnum(string value)
        {
            return value switch
            {
                "preview" => AutoSDKSharedbc14f6f0dbfaa660Environment.Preview,
                "production" => AutoSDKSharedbc14f6f0dbfaa660Environment.Production,
                _ => null,
            };
        }
    }
}