
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared80effb7d5d0bf792CrsJavaAction
    {
        /// <summary>
        ///
        /// </summary>
        Deny,
        /// <summary>
        ///
        /// </summary>
        Log,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared80effb7d5d0bf792CrsJavaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared80effb7d5d0bf792CrsJavaAction value)
        {
            return value switch
            {
                AutoSDKShared80effb7d5d0bf792CrsJavaAction.Deny => "deny",
                AutoSDKShared80effb7d5d0bf792CrsJavaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared80effb7d5d0bf792CrsJavaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared80effb7d5d0bf792CrsJavaAction.Deny,
                "log" => AutoSDKShared80effb7d5d0bf792CrsJavaAction.Log,
                _ => null,
            };
        }
    }
}