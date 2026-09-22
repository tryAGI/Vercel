
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The current state of the rolling release<br/>
    /// Example: ACTIVE
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aState
    {
        /// <summary>
        ///
        /// </summary>
        Aborted,
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Complete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfabd867705b7541aStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aState value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aState.Aborted => "ABORTED",
                AutoSDKSharedfabd867705b7541aState.Active => "ACTIVE",
                AutoSDKSharedfabd867705b7541aState.Complete => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aState? ToEnum(string value)
        {
            return value switch
            {
                "ABORTED" => AutoSDKSharedfabd867705b7541aState.Aborted,
                "ACTIVE" => AutoSDKSharedfabd867705b7541aState.Active,
                "COMPLETE" => AutoSDKSharedfabd867705b7541aState.Complete,
                _ => null,
            };
        }
    }
}