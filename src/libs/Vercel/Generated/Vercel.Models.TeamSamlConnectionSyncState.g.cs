
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Controls whether directory sync events are processed. - 'SETUP': Directory connected but role mappings not yet configured. Events are acknowledged but not processed. - 'ACTIVE': Fully configured. Events are processed normally. - undefined: Legacy directory (pre-feature), treat as 'ACTIVE' for backwards compatibility.
    /// </summary>
    public enum TeamSamlConnectionSyncState
    {
        /// <summary>
        /// Directory connected but role mappings not yet configured. Events are acknowledged but not processed. - 'ACTIVE': Fully configured. Events are processed normally. - undefined: Legacy directory (pre-feature), treat as 'ACTIVE' for backwards compatibility.
        /// </summary>
        Active,
        /// <summary>
        /// Directory connected but role mappings not yet configured. Events are acknowledged but not processed. - 'ACTIVE': Fully configured. Events are processed normally. - undefined: Legacy directory (pre-feature), treat as 'ACTIVE' for backwards compatibility.
        /// </summary>
        Setup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamSamlConnectionSyncStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSamlConnectionSyncState value)
        {
            return value switch
            {
                TeamSamlConnectionSyncState.Active => "ACTIVE",
                TeamSamlConnectionSyncState.Setup => "SETUP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSamlConnectionSyncState? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => TeamSamlConnectionSyncState.Active,
                "SETUP" => TeamSamlConnectionSyncState.Setup,
                _ => null,
            };
        }
    }
}