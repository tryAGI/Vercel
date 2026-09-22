
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The advancement type of the rolling release<br/>
    /// Example: manual-approval
    /// </summary>
    public enum AutoSDKSharedfabd867705b7541aAdvancementType
    {
        /// <summary>
        ///
        /// </summary>
        Automatic,
        /// <summary>
        ///
        /// </summary>
        ManualApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedfabd867705b7541aAdvancementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedfabd867705b7541aAdvancementType value)
        {
            return value switch
            {
                AutoSDKSharedfabd867705b7541aAdvancementType.Automatic => "automatic",
                AutoSDKSharedfabd867705b7541aAdvancementType.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedfabd867705b7541aAdvancementType? ToEnum(string value)
        {
            return value switch
            {
                "automatic" => AutoSDKSharedfabd867705b7541aAdvancementType.Automatic,
                "manual-approval" => AutoSDKSharedfabd867705b7541aAdvancementType.ManualApproval,
                _ => null,
            };
        }
    }
}