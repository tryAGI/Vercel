
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dStatus
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
    public static class AutoSDKShared9c06dfe8dd59ad6dStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dStatus value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dStatus.Disabled => "disabled",
                AutoSDKShared9c06dfe8dd59ad6dStatus.Enabled => "enabled",
                AutoSDKShared9c06dfe8dd59ad6dStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared9c06dfe8dd59ad6dStatus.Disabled,
                "enabled" => AutoSDKShared9c06dfe8dd59ad6dStatus.Enabled,
                "errored" => AutoSDKShared9c06dfe8dd59ad6dStatus.Errored,
                _ => null,
            };
        }
    }
}