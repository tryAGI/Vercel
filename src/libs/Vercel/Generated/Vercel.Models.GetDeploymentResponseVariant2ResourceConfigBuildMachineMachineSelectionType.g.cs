
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Whether the build ran on a fixed or elastic machine. Used to drive billing for the build.
    /// </summary>
    public enum GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType
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
    public static class GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => GetDeploymentResponseVariant2ResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}