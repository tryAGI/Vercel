
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The time period to keep non-production deployments for<br/>
    /// Example: 1y
    /// </summary>
    public enum PatchTeamRequestDefaultExpirationSettingsExpiration
    {
        /// <summary>
        /// 
        /// </summary>
        x1d,
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x1w,
        /// <summary>
        /// 
        /// </summary>
        x1y,
        /// <summary>
        /// 
        /// </summary>
        x2m,
        /// <summary>
        /// 
        /// </summary>
        x2w,
        /// <summary>
        /// 
        /// </summary>
        x2y,
        /// <summary>
        /// 
        /// </summary>
        x3m,
        /// <summary>
        /// 
        /// </summary>
        x3y,
        /// <summary>
        /// 
        /// </summary>
        x6m,
        /// <summary>
        /// 
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestDefaultExpirationSettingsExpirationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultExpirationSettingsExpiration value)
        {
            return value switch
            {
                PatchTeamRequestDefaultExpirationSettingsExpiration.x1d => "1d",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x1m => "1m",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x1w => "1w",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x1y => "1y",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x2m => "2m",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x2w => "2w",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x2y => "2y",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x3m => "3m",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x3y => "3y",
                PatchTeamRequestDefaultExpirationSettingsExpiration.x6m => "6m",
                PatchTeamRequestDefaultExpirationSettingsExpiration.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultExpirationSettingsExpiration? ToEnum(string value)
        {
            return value switch
            {
                "1d" => PatchTeamRequestDefaultExpirationSettingsExpiration.x1d,
                "1m" => PatchTeamRequestDefaultExpirationSettingsExpiration.x1m,
                "1w" => PatchTeamRequestDefaultExpirationSettingsExpiration.x1w,
                "1y" => PatchTeamRequestDefaultExpirationSettingsExpiration.x1y,
                "2m" => PatchTeamRequestDefaultExpirationSettingsExpiration.x2m,
                "2w" => PatchTeamRequestDefaultExpirationSettingsExpiration.x2w,
                "2y" => PatchTeamRequestDefaultExpirationSettingsExpiration.x2y,
                "3m" => PatchTeamRequestDefaultExpirationSettingsExpiration.x3m,
                "3y" => PatchTeamRequestDefaultExpirationSettingsExpiration.x3y,
                "6m" => PatchTeamRequestDefaultExpirationSettingsExpiration.x6m,
                "unlimited" => PatchTeamRequestDefaultExpirationSettingsExpiration.Unlimited,
                _ => null,
            };
        }
    }
}