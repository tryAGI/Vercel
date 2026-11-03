
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd5d6c9ab94c25f66Status
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
        /// <summary>
        ///
        /// </summary>
        Errored,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedd5d6c9ab94c25f66StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd5d6c9ab94c25f66Status value)
        {
            return value switch
            {
                AutoSDKSharedd5d6c9ab94c25f66Status.Disabled => "disabled",
                AutoSDKSharedd5d6c9ab94c25f66Status.Enabled => "enabled",
                AutoSDKSharedd5d6c9ab94c25f66Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd5d6c9ab94c25f66Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKSharedd5d6c9ab94c25f66Status.Disabled,
                "enabled" => AutoSDKSharedd5d6c9ab94c25f66Status.Enabled,
                "errored" => AutoSDKSharedd5d6c9ab94c25f66Status.Errored,
                _ => null,
            };
        }
    }
}