
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
    /// </summary>
    public enum CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType
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
    public static class CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => CreateDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}