
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction
    {
        /// <summary>
        /// 
        /// </summary>
        AddDeploymentInterstitial,
        /// <summary>
        /// 
        /// </summary>
        AddProjectInterstitial,
        /// <summary>
        /// 
        /// </summary>
        RemoveDeploymentInterstitial,
        /// <summary>
        /// 
        /// </summary>
        RemoveProjectInterstitial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => GetProjectsResponseVariant1ItemAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}