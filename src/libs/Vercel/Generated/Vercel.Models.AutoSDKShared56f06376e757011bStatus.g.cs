
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared56f06376e757011bStatus
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
    public static class AutoSDKShared56f06376e757011bStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared56f06376e757011bStatus value)
        {
            return value switch
            {
                AutoSDKShared56f06376e757011bStatus.Disabled => "disabled",
                AutoSDKShared56f06376e757011bStatus.Enabled => "enabled",
                AutoSDKShared56f06376e757011bStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared56f06376e757011bStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared56f06376e757011bStatus.Disabled,
                "enabled" => AutoSDKShared56f06376e757011bStatus.Enabled,
                "errored" => AutoSDKShared56f06376e757011bStatus.Errored,
                _ => null,
            };
        }
    }
}