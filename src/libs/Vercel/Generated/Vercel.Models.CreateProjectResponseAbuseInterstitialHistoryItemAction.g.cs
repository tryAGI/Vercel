
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateProjectResponseAbuseInterstitialHistoryItemAction
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
    public static class CreateProjectResponseAbuseInterstitialHistoryItemActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectResponseAbuseInterstitialHistoryItemAction value)
        {
            return value switch
            {
                CreateProjectResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial => "add-deployment-interstitial",
                CreateProjectResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial => "add-project-interstitial",
                CreateProjectResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial => "remove-deployment-interstitial",
                CreateProjectResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial => "remove-project-interstitial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectResponseAbuseInterstitialHistoryItemAction? ToEnum(string value)
        {
            return value switch
            {
                "add-deployment-interstitial" => CreateProjectResponseAbuseInterstitialHistoryItemAction.AddDeploymentInterstitial,
                "add-project-interstitial" => CreateProjectResponseAbuseInterstitialHistoryItemAction.AddProjectInterstitial,
                "remove-deployment-interstitial" => CreateProjectResponseAbuseInterstitialHistoryItemAction.RemoveDeploymentInterstitial,
                "remove-project-interstitial" => CreateProjectResponseAbuseInterstitialHistoryItemAction.RemoveProjectInterstitial,
                _ => null,
            };
        }
    }
}