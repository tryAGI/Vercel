
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2bfc0b0e9e85f636Status
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
    public static class AutoSDKShared2bfc0b0e9e85f636StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2bfc0b0e9e85f636Status value)
        {
            return value switch
            {
                AutoSDKShared2bfc0b0e9e85f636Status.Disabled => "disabled",
                AutoSDKShared2bfc0b0e9e85f636Status.Enabled => "enabled",
                AutoSDKShared2bfc0b0e9e85f636Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2bfc0b0e9e85f636Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared2bfc0b0e9e85f636Status.Disabled,
                "enabled" => AutoSDKShared2bfc0b0e9e85f636Status.Enabled,
                "errored" => AutoSDKShared2bfc0b0e9e85f636Status.Errored,
                _ => null,
            };
        }
    }
}