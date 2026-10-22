
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared6df91f8a45eab833Status
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
    public static class AutoSDKShared6df91f8a45eab833StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6df91f8a45eab833Status value)
        {
            return value switch
            {
                AutoSDKShared6df91f8a45eab833Status.Disabled => "disabled",
                AutoSDKShared6df91f8a45eab833Status.Enabled => "enabled",
                AutoSDKShared6df91f8a45eab833Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6df91f8a45eab833Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared6df91f8a45eab833Status.Disabled,
                "enabled" => AutoSDKShared6df91f8a45eab833Status.Enabled,
                "errored" => AutoSDKShared6df91f8a45eab833Status.Errored,
                _ => null,
            };
        }
    }
}