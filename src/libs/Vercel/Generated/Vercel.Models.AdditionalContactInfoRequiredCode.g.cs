
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdditionalContactInfoRequiredCode
    {
        /// <summary>
        /// 
        /// </summary>
        AdditionalContactInfoRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdditionalContactInfoRequiredCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdditionalContactInfoRequiredCode value)
        {
            return value switch
            {
                AdditionalContactInfoRequiredCode.AdditionalContactInfoRequired => "additional_contact_info_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdditionalContactInfoRequiredCode? ToEnum(string value)
        {
            return value switch
            {
                "additional_contact_info_required" => AdditionalContactInfoRequiredCode.AdditionalContactInfoRequired,
                _ => null,
            };
        }
    }
}