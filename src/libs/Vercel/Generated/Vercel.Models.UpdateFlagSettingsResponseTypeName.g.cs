
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSettingsResponseTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSettingsResponseTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSettingsResponseTypeName value)
        {
            return value switch
            {
                UpdateFlagSettingsResponseTypeName.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSettingsResponseTypeName? ToEnum(string value)
        {
            return value switch
            {
                "settings" => UpdateFlagSettingsResponseTypeName.Settings,
                _ => null,
            };
        }
    }
}