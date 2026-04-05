
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose
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
    public static class HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose value)
        {
            return value switch
            {
                HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation => "experimentation",
                HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags => "flags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose? ToEnum(string value)
        {
            return value switch
            {
                "experimentation" => HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Experimentation,
                "flags" => HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationEdgeConfigResponsePurpose.Flags,
                _ => null,
            };
        }
    }
}