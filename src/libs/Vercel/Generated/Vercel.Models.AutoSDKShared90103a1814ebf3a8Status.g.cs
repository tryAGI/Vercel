
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared90103a1814ebf3a8Status
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
    public static class AutoSDKShared90103a1814ebf3a8StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared90103a1814ebf3a8Status value)
        {
            return value switch
            {
                AutoSDKShared90103a1814ebf3a8Status.Disabled => "disabled",
                AutoSDKShared90103a1814ebf3a8Status.Enabled => "enabled",
                AutoSDKShared90103a1814ebf3a8Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared90103a1814ebf3a8Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared90103a1814ebf3a8Status.Disabled,
                "enabled" => AutoSDKShared90103a1814ebf3a8Status.Enabled,
                "errored" => AutoSDKShared90103a1814ebf3a8Status.Errored,
                _ => null,
            };
        }
    }
}