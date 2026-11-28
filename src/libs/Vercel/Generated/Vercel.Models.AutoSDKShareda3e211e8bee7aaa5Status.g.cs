
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda3e211e8bee7aaa5Status
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
    public static class AutoSDKShareda3e211e8bee7aaa5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda3e211e8bee7aaa5Status value)
        {
            return value switch
            {
                AutoSDKShareda3e211e8bee7aaa5Status.Disabled => "disabled",
                AutoSDKShareda3e211e8bee7aaa5Status.Enabled => "enabled",
                AutoSDKShareda3e211e8bee7aaa5Status.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda3e211e8bee7aaa5Status? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => AutoSDKShareda3e211e8bee7aaa5Status.Disabled,
                "enabled" => AutoSDKShareda3e211e8bee7aaa5Status.Enabled,
                "errored" => AutoSDKShareda3e211e8bee7aaa5Status.Errored,
                _ => null,
            };
        }
    }
}