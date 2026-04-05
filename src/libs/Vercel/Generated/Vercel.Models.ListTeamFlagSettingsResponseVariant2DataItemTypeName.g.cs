
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTeamFlagSettingsResponseVariant2DataItemTypeName
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTeamFlagSettingsResponseVariant2DataItemTypeNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamFlagSettingsResponseVariant2DataItemTypeName value)
        {
            return value switch
            {
                ListTeamFlagSettingsResponseVariant2DataItemTypeName.Settings => "settings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamFlagSettingsResponseVariant2DataItemTypeName? ToEnum(string value)
        {
            return value switch
            {
                "settings" => ListTeamFlagSettingsResponseVariant2DataItemTypeName.Settings,
                _ => null,
            };
        }
    }
}