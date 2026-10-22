
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217Status
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
    public static class AutoSDKShared0695a89a4e02b217StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217Status value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217Status.Disabled => "disabled",
                AutoSDKShared0695a89a4e02b217Status.Enabled => "enabled",
                AutoSDKShared0695a89a4e02b217Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShared0695a89a4e02b217Status.Disabled,
                "enabled" => AutoSDKShared0695a89a4e02b217Status.Enabled,
                "errored" => AutoSDKShared0695a89a4e02b217Status.Errored,
                _ => null,
            };
        }
    }
}