
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeaders value)
        {
            return value switch
            {
                AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared7edb780247ab9fb3ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}