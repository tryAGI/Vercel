
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The time period to keep canceled deployments for<br/>
    /// Example: 1y
    /// </summary>
    public enum PatchTeamRequestDefaultExpirationSettingsExpirationCanceled
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
    public static class PatchTeamRequestDefaultExpirationSettingsExpirationCanceledExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestDefaultExpirationSettingsExpirationCanceled value)
        {
            return value switch
            {
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1d => "1d",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1m => "1m",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1w => "1w",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1y => "1y",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x2m => "2m",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x2w => "2w",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x3m => "3m",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x6m => "6m",
                PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestDefaultExpirationSettingsExpirationCanceled? ToEnum(string value)
        {
            return value switch
            {
                "1d" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1d,
                "1m" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1m,
                "1w" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1w,
                "1y" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x1y,
                "2m" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x2m,
                "2w" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x2w,
                "3m" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x3m,
                "6m" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.x6m,
                "unlimited" => PatchTeamRequestDefaultExpirationSettingsExpirationCanceled.Unlimited,
                _ => null,
            };
        }
    }
}