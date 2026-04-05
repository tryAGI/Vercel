
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageCodeRequiredCode
    {
        /// <summary>
        /// 
        /// </summary>
        LanguageCodeRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageCodeRequiredCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageCodeRequiredCode value)
        {
            return value switch
            {
                LanguageCodeRequiredCode.LanguageCodeRequired => "language_code_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageCodeRequiredCode? ToEnum(string value)
        {
            return value switch
            {
                "language_code_required" => LanguageCodeRequiredCode.LanguageCodeRequired,
                _ => null,
            };
        }
    }
}