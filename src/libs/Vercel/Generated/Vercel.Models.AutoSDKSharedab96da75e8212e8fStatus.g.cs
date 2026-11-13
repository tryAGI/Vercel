
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedab96da75e8212e8fStatus
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
    public static class AutoSDKSharedab96da75e8212e8fStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedab96da75e8212e8fStatus value)
        {
            return value switch
            {
                AutoSDKSharedab96da75e8212e8fStatus.Disabled => "disabled",
                AutoSDKSharedab96da75e8212e8fStatus.Enabled => "enabled",
                AutoSDKSharedab96da75e8212e8fStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedab96da75e8212e8fStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKSharedab96da75e8212e8fStatus.Disabled,
                "enabled" => AutoSDKSharedab96da75e8212e8fStatus.Enabled,
                "errored" => AutoSDKSharedab96da75e8212e8fStatus.Errored,
                _ => null,
            };
        }
    }
}