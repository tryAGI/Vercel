
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When set to `PAUSED`, the rollout is frozen at the current percentage until continued.
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aSubstate
    {
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfabd867705b7541aSubstateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aSubstate value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aSubstate.Paused => "PAUSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aSubstate? ToEnum(string value)
        {
            return value switch
            {
                "PAUSED" => AutoSDKSharedfabd867705b7541aSubstate.Paused,
                _ => null,
            };
        }
    }
}