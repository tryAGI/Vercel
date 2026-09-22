
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared08bf5d361fc08707ActionMitigateLogHeaders
    {
        /// <summary>
        ///
        /// </summary>
        Multiply,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared08bf5d361fc08707ActionMitigateLogHeadersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared08bf5d361fc08707ActionMitigateLogHeaders value)
        {
            return value switch
            {
                AutoSDKShared08bf5d361fc08707ActionMitigateLogHeaders.Multiply => "*",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared08bf5d361fc08707ActionMitigateLogHeaders? ToEnum(string value)
        {
            return value switch
            {
                "*" => AutoSDKShared08bf5d361fc08707ActionMitigateLogHeaders.Multiply,
                _ => null,
            };
        }
    }
}