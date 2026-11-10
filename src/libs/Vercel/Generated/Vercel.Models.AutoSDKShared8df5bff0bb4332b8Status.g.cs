
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared8df5bff0bb4332b8Status
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
    public static class AutoSDKShared8df5bff0bb4332b8StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared8df5bff0bb4332b8Status value)
        {
            return value switch
            {
                AutoSDKShared8df5bff0bb4332b8Status.Disabled => "disabled",
                AutoSDKShared8df5bff0bb4332b8Status.Enabled => "enabled",
                AutoSDKShared8df5bff0bb4332b8Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared8df5bff0bb4332b8Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared8df5bff0bb4332b8Status.Disabled,
                "enabled" => AutoSDKShared8df5bff0bb4332b8Status.Enabled,
                "errored" => AutoSDKShared8df5bff0bb4332b8Status.Errored,
                _ => null,
            };
        }
    }
}