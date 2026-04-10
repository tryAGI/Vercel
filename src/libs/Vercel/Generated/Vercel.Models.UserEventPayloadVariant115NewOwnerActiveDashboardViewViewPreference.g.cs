
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference
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
    public static class UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference.Cards => "cards",
                UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "cards" => UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference.Cards,
                "list" => UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference.List,
                _ => null,
            };
        }
    }
}