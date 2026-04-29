
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Cards,
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference.Cards => "cards",
                UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "cards" => UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference.Cards,
                "list" => UserEventPayloadVariant122NewOwnerActiveDashboardViewViewPreference.List,
                _ => null,
            };
        }
    }
}