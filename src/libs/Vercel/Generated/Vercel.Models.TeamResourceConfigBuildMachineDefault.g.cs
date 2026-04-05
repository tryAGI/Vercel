
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Default build machine type for new builds
    /// </summary>
    public enum TeamResourceConfigBuildMachineDefault
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                TeamResourceConfigBuildMachineDefault.Elastic => "elastic",
                TeamResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                TeamResourceConfigBuildMachineDefault.Standard => "standard",
                TeamResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => TeamResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => TeamResourceConfigBuildMachineDefault.Enhanced,
                "standard" => TeamResourceConfigBuildMachineDefault.Standard,
                "turbo" => TeamResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}