
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default build machine type for new builds: standard, enhanced, turbo, or elastic.<br/>
    /// Example: standard
    /// </summary>
    public enum PatchTeamRequestResourceConfigBuildMachineDefault
    {
        /// <summary>
        /// standard, enhanced, turbo, or elastic.
        /// </summary>
        Elastic,
        /// <summary>
        /// standard, enhanced, turbo, or elastic.
        /// </summary>
        Enhanced,
        /// <summary>
        /// standard, enhanced, turbo, or elastic.
        /// </summary>
        Standard,
        /// <summary>
        /// standard, enhanced, turbo, or elastic.
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchTeamRequestResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchTeamRequestResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                PatchTeamRequestResourceConfigBuildMachineDefault.Elastic => "elastic",
                PatchTeamRequestResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                PatchTeamRequestResourceConfigBuildMachineDefault.Standard => "standard",
                PatchTeamRequestResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchTeamRequestResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => PatchTeamRequestResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => PatchTeamRequestResourceConfigBuildMachineDefault.Enhanced,
                "standard" => PatchTeamRequestResourceConfigBuildMachineDefault.Standard,
                "turbo" => PatchTeamRequestResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}