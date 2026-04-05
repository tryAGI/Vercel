
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Experimentation,
        /// <summary>
        /// 
        /// </summary>
        Flags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose value)
        {
            return value switch
            {
                ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation => "experimentation",
                ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation,
                "flags" => ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags,
                _ => null,
            };
        }
    }
}