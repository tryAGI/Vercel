
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetFlagSettingsResponseTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFlagSettingsResponseTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFlagSettingsResponseTypeName value)
        {
            return value switch
            {
                GetFlagSettingsResponseTypeName.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFlagSettingsResponseTypeName? ToEnum(string value)
        {
            return value switch
            {
                "settings" => GetFlagSettingsResponseTypeName.Settings,
                _ => null,
            };
        }
    }
}