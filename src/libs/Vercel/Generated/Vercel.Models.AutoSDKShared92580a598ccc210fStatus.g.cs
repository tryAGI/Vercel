
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared92580a598ccc210fStatus
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
    public static class AutoSDKShared92580a598ccc210fStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared92580a598ccc210fStatus value)
        {
            return value switch
            {
                AutoSDKShared92580a598ccc210fStatus.Disabled => "disabled",
                AutoSDKShared92580a598ccc210fStatus.Enabled => "enabled",
                AutoSDKShared92580a598ccc210fStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared92580a598ccc210fStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared92580a598ccc210fStatus.Disabled,
                "enabled" => AutoSDKShared92580a598ccc210fStatus.Enabled,
                "errored" => AutoSDKShared92580a598ccc210fStatus.Errored,
                _ => null,
            };
        }
    }
}