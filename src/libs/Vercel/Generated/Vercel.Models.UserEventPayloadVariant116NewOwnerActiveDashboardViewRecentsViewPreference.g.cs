
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference.Closed => "closed",
                UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference.Closed,
                "open" => UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference.Open,
                _ => null,
            };
        }
    }
}