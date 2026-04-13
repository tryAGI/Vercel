
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference
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
    public static class UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference.Cards => "cards",
                UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "cards" => UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference.Cards,
                "list" => UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference.List,
                _ => null,
            };
        }
    }
}