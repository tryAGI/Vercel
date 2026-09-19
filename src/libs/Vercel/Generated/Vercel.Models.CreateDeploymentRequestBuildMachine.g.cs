
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Selects a custom build machine for this deployment without changing project settings.
    /// </summary>
    public enum CreateDeploymentRequestBuildMachine
    {
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentRequestBuildMachineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentRequestBuildMachine value)
        {
            return value switch
            {
                CreateDeploymentRequestBuildMachine.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentRequestBuildMachine? ToEnum(string value)
        {
            return value switch
            {
                "turbo" => CreateDeploymentRequestBuildMachine.Turbo,
                _ => null,
            };
        }
    }
}