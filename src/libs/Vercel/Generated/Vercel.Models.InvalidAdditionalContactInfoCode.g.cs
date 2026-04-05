
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvalidAdditionalContactInfoCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidAdditionalContactInfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvalidAdditionalContactInfoCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvalidAdditionalContactInfoCode value)
        {
            return value switch
            {
                InvalidAdditionalContactInfoCode.InvalidAdditionalContactInfo => "invalid_additional_contact_info",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvalidAdditionalContactInfoCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_additional_contact_info" => InvalidAdditionalContactInfoCode.InvalidAdditionalContactInfo,
                _ => null,
            };
        }
    }
}