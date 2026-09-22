
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
    /// </summary>
    public enum CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => CreateDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}