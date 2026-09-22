
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the domain is enrolled in Encrypted Client Hello. `auto` leaves the decision to Vercel, `enabled` always enrolls, and `disabled` never enrolls and opts out of automatic enrollment.<br/>
    /// Example: auto
    /// </summary>
    public enum AutoSDKShared3ee0b14b2005812dEchMode
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared3ee0b14b2005812dEchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3ee0b14b2005812dEchMode value)
        {
            return value switch
            {
                AutoSDKShared3ee0b14b2005812dEchMode.Auto => "auto",
                AutoSDKShared3ee0b14b2005812dEchMode.Disabled => "disabled",
                AutoSDKShared3ee0b14b2005812dEchMode.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3ee0b14b2005812dEchMode? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AutoSDKShared3ee0b14b2005812dEchMode.Auto,
                "disabled" => AutoSDKShared3ee0b14b2005812dEchMode.Disabled,
                "enabled" => AutoSDKShared3ee0b14b2005812dEchMode.Enabled,
                _ => null,
            };
        }
    }
}