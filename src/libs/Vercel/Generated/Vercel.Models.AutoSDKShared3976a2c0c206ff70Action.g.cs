
#nullable enable

namespace Vercel
{
    /// <summary>
    /// What to do when the gate trips: pause the rollout, or roll it back.
    /// </summary>
    public enum AutoSDKShared3976a2c0c206ff70Action
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
    public static class AutoSDKShared3976a2c0c206ff70ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3976a2c0c206ff70Action value)
        {
            return value switch
            {
                AutoSDKShared3976a2c0c206ff70Action.Pause => "pause",
                AutoSDKShared3976a2c0c206ff70Action.Rollback => "rollback",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3976a2c0c206ff70Action? ToEnum(string value)
        {
            return value switch
            {
                "pause" => AutoSDKShared3976a2c0c206ff70Action.Pause,
                "rollback" => AutoSDKShared3976a2c0c206ff70Action.Rollback,
                _ => null,
            };
        }
    }
}