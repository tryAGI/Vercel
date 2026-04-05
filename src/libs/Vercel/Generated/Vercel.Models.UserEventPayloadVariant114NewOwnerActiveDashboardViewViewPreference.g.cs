
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference
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
    public static class UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference.Cards => "cards",
                UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "cards" => UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference.Cards,
                "list" => UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference.List,
                _ => null,
            };
        }
    }
}