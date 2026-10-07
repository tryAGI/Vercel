
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum AutoSDKSharedf29c7949a8a48e4aAction
    {
        /// <summary>
        /// pause the rollout, or roll it back.
        /// </summary>
        Pause,
        /// <summary>
        ///
        /// </summary>
        Rollback,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedf29c7949a8a48e4aActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedf29c7949a8a48e4aAction value)
        {
            return value switch
            {
                AutoSDKSharedf29c7949a8a48e4aAction.Pause => "pause",
                AutoSDKSharedf29c7949a8a48e4aAction.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedf29c7949a8a48e4aAction? ToEnum(string value)
        {
            return value switch
            {
                "pause" => AutoSDKSharedf29c7949a8a48e4aAction.Pause,
                "rollback" => AutoSDKSharedf29c7949a8a48e4aAction.Rollback,
                _ => null,
            };
        }
    }
}