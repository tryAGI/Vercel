
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateFlagSettingsResponseTypeName2
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateFlagSettingsResponseTypeName2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateFlagSettingsResponseTypeName2 value)
        {
            return value switch
            {
                UpdateFlagSettingsResponseTypeName2.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateFlagSettingsResponseTypeName2? ToEnum(string value)
        {
            return value switch
            {
                "settings" => UpdateFlagSettingsResponseTypeName2.Settings,
                _ => null,
            };
        }
    }
}