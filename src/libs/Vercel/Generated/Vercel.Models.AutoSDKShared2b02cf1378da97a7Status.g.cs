
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared2b02cf1378da97a7Status
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
    public static class AutoSDKShared2b02cf1378da97a7StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2b02cf1378da97a7Status value)
        {
            return value switch
            {
                AutoSDKShared2b02cf1378da97a7Status.Disabled => "disabled",
                AutoSDKShared2b02cf1378da97a7Status.Enabled => "enabled",
                AutoSDKShared2b02cf1378da97a7Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2b02cf1378da97a7Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared2b02cf1378da97a7Status.Disabled,
                "enabled" => AutoSDKShared2b02cf1378da97a7Status.Enabled,
                "errored" => AutoSDKShared2b02cf1378da97a7Status.Errored,
                _ => null,
            };
        }
    }
}