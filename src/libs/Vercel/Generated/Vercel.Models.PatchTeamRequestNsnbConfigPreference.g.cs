
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The NSNB preference for the team.
    /// </summary>
    public enum PatchTeamRequestNsnbConfigPreference
    {
        /// <summary>
        /// 
        /// </summary>
        AutoApproval,
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        ManualApproval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestNsnbConfigPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestNsnbConfigPreference value)
        {
            return value switch
            {
                PatchTeamRequestNsnbConfigPreference.AutoApproval => "auto-approval",
                PatchTeamRequestNsnbConfigPreference.Block => "block",
                PatchTeamRequestNsnbConfigPreference.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestNsnbConfigPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto-approval" => PatchTeamRequestNsnbConfigPreference.AutoApproval,
                "block" => PatchTeamRequestNsnbConfigPreference.Block,
                "manual-approval" => PatchTeamRequestNsnbConfigPreference.ManualApproval,
                _ => null,
            };
        }
    }
}