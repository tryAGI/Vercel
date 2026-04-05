
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamNsnbConfigPreference
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
    public static class TeamNsnbConfigPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamNsnbConfigPreference value)
        {
            return value switch
            {
                TeamNsnbConfigPreference.AutoApproval => "auto-approval",
                TeamNsnbConfigPreference.Block => "block",
                TeamNsnbConfigPreference.ManualApproval => "manual-approval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamNsnbConfigPreference? ToEnum(string value)
        {
            return value switch
            {
                "auto-approval" => TeamNsnbConfigPreference.AutoApproval,
                "block" => TeamNsnbConfigPreference.Block,
                "manual-approval" => TeamNsnbConfigPreference.ManualApproval,
                _ => null,
            };
        }
    }
}