
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6ed60ada20c5170aCrsJavaAction
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
    public static class AutoSDKShared6ed60ada20c5170aCrsJavaActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6ed60ada20c5170aCrsJavaAction value)
        {
            return value switch
            {
                AutoSDKShared6ed60ada20c5170aCrsJavaAction.Deny => "deny",
                AutoSDKShared6ed60ada20c5170aCrsJavaAction.Log => "log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6ed60ada20c5170aCrsJavaAction? ToEnum(string value)
        {
            return value switch
            {
                "deny" => AutoSDKShared6ed60ada20c5170aCrsJavaAction.Deny,
                "log" => AutoSDKShared6ed60ada20c5170aCrsJavaAction.Log,
                _ => null,
            };
        }
    }
}