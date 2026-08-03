
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
    /// </summary>
    public enum CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType
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
    public static class CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => CancelDeploymentResponseResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}