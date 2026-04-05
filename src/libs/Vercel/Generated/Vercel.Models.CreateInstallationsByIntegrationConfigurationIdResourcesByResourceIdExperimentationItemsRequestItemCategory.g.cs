
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Flag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory value)
        {
            return value switch
            {
                CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory.Experiment => "experiment",
                CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory.Flag => "flag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory.Experiment,
                "flag" => CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory.Flag,
                _ => null,
            };
        }
    }
}