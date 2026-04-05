
#nullable enable

namespace Vercel
{
    /// <summary>
    /// High-level category of the service
    /// </summary>
    public enum ListBillingChargesResponseServiceCategory
    {
        /// <summary>
        /// 
        /// </summary>
        AiAndMachineLearning,
        /// <summary>
        /// 
        /// </summary>
        Analytics,
        /// <summary>
        /// 
        /// </summary>
        BusinessApplications,
        /// <summary>
        /// 
        /// </summary>
        Compute,
        /// <summary>
        /// 
        /// </summary>
        Databases,
        /// <summary>
        /// 
        /// </summary>
        DeveloperTools,
        /// <summary>
        /// 
        /// </summary>
        Identity,
        /// <summary>
        /// 
        /// </summary>
        Integration,
        /// <summary>
        /// 
        /// </summary>
        InternetOfThings,
        /// <summary>
        /// 
        /// </summary>
        ManagementAndGovernance,
        /// <summary>
        /// 
        /// </summary>
        Media,
        /// <summary>
        /// 
        /// </summary>
        Migration,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Multicloud,
        /// <summary>
        /// 
        /// </summary>
        Networking,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Security,
        /// <summary>
        /// 
        /// </summary>
        Storage,
        /// <summary>
        /// 
        /// </summary>
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBillingChargesResponseServiceCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBillingChargesResponseServiceCategory value)
        {
            return value switch
            {
                ListBillingChargesResponseServiceCategory.AiAndMachineLearning => "AI and Machine Learning",
                ListBillingChargesResponseServiceCategory.Analytics => "Analytics",
                ListBillingChargesResponseServiceCategory.BusinessApplications => "Business Applications",
                ListBillingChargesResponseServiceCategory.Compute => "Compute",
                ListBillingChargesResponseServiceCategory.Databases => "Databases",
                ListBillingChargesResponseServiceCategory.DeveloperTools => "Developer Tools",
                ListBillingChargesResponseServiceCategory.Identity => "Identity",
                ListBillingChargesResponseServiceCategory.Integration => "Integration",
                ListBillingChargesResponseServiceCategory.InternetOfThings => "Internet of Things",
                ListBillingChargesResponseServiceCategory.ManagementAndGovernance => "Management and Governance",
                ListBillingChargesResponseServiceCategory.Media => "Media",
                ListBillingChargesResponseServiceCategory.Migration => "Migration",
                ListBillingChargesResponseServiceCategory.Mobile => "Mobile",
                ListBillingChargesResponseServiceCategory.Multicloud => "Multicloud",
                ListBillingChargesResponseServiceCategory.Networking => "Networking",
                ListBillingChargesResponseServiceCategory.Other => "Other",
                ListBillingChargesResponseServiceCategory.Security => "Security",
                ListBillingChargesResponseServiceCategory.Storage => "Storage",
                ListBillingChargesResponseServiceCategory.Web => "Web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBillingChargesResponseServiceCategory? ToEnum(string value)
        {
            return value switch
            {
                "AI and Machine Learning" => ListBillingChargesResponseServiceCategory.AiAndMachineLearning,
                "Analytics" => ListBillingChargesResponseServiceCategory.Analytics,
                "Business Applications" => ListBillingChargesResponseServiceCategory.BusinessApplications,
                "Compute" => ListBillingChargesResponseServiceCategory.Compute,
                "Databases" => ListBillingChargesResponseServiceCategory.Databases,
                "Developer Tools" => ListBillingChargesResponseServiceCategory.DeveloperTools,
                "Identity" => ListBillingChargesResponseServiceCategory.Identity,
                "Integration" => ListBillingChargesResponseServiceCategory.Integration,
                "Internet of Things" => ListBillingChargesResponseServiceCategory.InternetOfThings,
                "Management and Governance" => ListBillingChargesResponseServiceCategory.ManagementAndGovernance,
                "Media" => ListBillingChargesResponseServiceCategory.Media,
                "Migration" => ListBillingChargesResponseServiceCategory.Migration,
                "Mobile" => ListBillingChargesResponseServiceCategory.Mobile,
                "Multicloud" => ListBillingChargesResponseServiceCategory.Multicloud,
                "Networking" => ListBillingChargesResponseServiceCategory.Networking,
                "Other" => ListBillingChargesResponseServiceCategory.Other,
                "Security" => ListBillingChargesResponseServiceCategory.Security,
                "Storage" => ListBillingChargesResponseServiceCategory.Storage,
                "Web" => ListBillingChargesResponseServiceCategory.Web,
                _ => null,
            };
        }
    }
}