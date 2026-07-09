
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateProjectRequestPassportPublicPathRuleType
    {
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectRequestPassportPublicPathRuleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectRequestPassportPublicPathRuleType value)
        {
            return value switch
            {
                UpdateProjectRequestPassportPublicPathRuleType.Equals => "equals",
                UpdateProjectRequestPassportPublicPathRuleType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectRequestPassportPublicPathRuleType? ToEnum(string value)
        {
            return value switch
            {
                "equals" => UpdateProjectRequestPassportPublicPathRuleType.Equals,
                "startsWith" => UpdateProjectRequestPassportPublicPathRuleType.StartsWith,
                _ => null,
            };
        }
    }
}