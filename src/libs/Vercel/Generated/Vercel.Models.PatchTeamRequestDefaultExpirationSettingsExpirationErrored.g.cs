
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The time period to keep errored deployments for<br/>
    /// Example: 1y
    /// </summary>
    public enum PatchTeamRequestDefaultExpirationSettingsExpirationErrored
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
        x3m,
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
    public static class PatchTeamRequestDefaultExpirationSettingsExpirationErroredExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultExpirationSettingsExpirationErrored value)
        {
            return value switch
            {
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1d => "1d",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1m => "1m",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1w => "1w",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1y => "1y",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x2m => "2m",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x2w => "2w",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x3m => "3m",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x6m => "6m",
                PatchTeamRequestDefaultExpirationSettingsExpirationErrored.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultExpirationSettingsExpirationErrored? ToEnum(string value)
        {
            return value switch
            {
                "1d" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1d,
                "1m" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1m,
                "1w" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1w,
                "1y" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x1y,
                "2m" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x2m,
                "2w" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x2w,
                "3m" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x3m,
                "6m" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.x6m,
                "unlimited" => PatchTeamRequestDefaultExpirationSettingsExpirationErrored.Unlimited,
                _ => null,
            };
        }
    }
}