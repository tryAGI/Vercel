
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0001bb8e789a120eStatus
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
    public static class AutoSDKShared0001bb8e789a120eStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0001bb8e789a120eStatus value)
        {
            return value switch
            {
                AutoSDKShared0001bb8e789a120eStatus.Disabled => "disabled",
                AutoSDKShared0001bb8e789a120eStatus.Enabled => "enabled",
                AutoSDKShared0001bb8e789a120eStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0001bb8e789a120eStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared0001bb8e789a120eStatus.Disabled,
                "enabled" => AutoSDKShared0001bb8e789a120eStatus.Enabled,
                "errored" => AutoSDKShared0001bb8e789a120eStatus.Errored,
                _ => null,
            };
        }
    }
}