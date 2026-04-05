
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The time period to keep production deployments for<br/>
    /// Example: 1y
    /// </summary>
    public enum PatchTeamRequestDefaultExpirationSettingsExpirationProduction
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
    public static class PatchTeamRequestDefaultExpirationSettingsExpirationProductionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultExpirationSettingsExpirationProduction value)
        {
            return value switch
            {
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1d => "1d",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1m => "1m",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1w => "1w",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1y => "1y",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2m => "2m",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2w => "2w",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2y => "2y",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x3m => "3m",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x3y => "3y",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x6m => "6m",
                PatchTeamRequestDefaultExpirationSettingsExpirationProduction.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultExpirationSettingsExpirationProduction? ToEnum(string value)
        {
            return value switch
            {
                "1d" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1d,
                "1m" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1m,
                "1w" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1w,
                "1y" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x1y,
                "2m" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2m,
                "2w" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2w,
                "2y" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x2y,
                "3m" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x3m,
                "3y" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x3y,
                "6m" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.x6m,
                "unlimited" => PatchTeamRequestDefaultExpirationSettingsExpirationProduction.Unlimited,
                _ => null,
            };
        }
    }
}