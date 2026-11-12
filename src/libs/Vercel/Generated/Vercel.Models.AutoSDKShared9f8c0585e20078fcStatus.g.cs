
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcStatus
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
    public static class AutoSDKShared9f8c0585e20078fcStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcStatus value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcStatus.Disabled => "disabled",
                AutoSDKShared9f8c0585e20078fcStatus.Enabled => "enabled",
                AutoSDKShared9f8c0585e20078fcStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared9f8c0585e20078fcStatus.Disabled,
                "enabled" => AutoSDKShared9f8c0585e20078fcStatus.Enabled,
                "errored" => AutoSDKShared9f8c0585e20078fcStatus.Errored,
                _ => null,
            };
        }
    }
}