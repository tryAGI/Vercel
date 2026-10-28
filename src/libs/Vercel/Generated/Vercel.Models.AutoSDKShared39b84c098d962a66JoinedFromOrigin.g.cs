
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared39b84c098d962a66JoinedFromOrigin
    {
        /// <summary>
        ///
        /// </summary>
        AccountUpdate,
        /// <summary>
        ///
        /// </summary>
        Bitbucket,
        /// <summary>
        ///
        /// </summary>
        Dsync,
        /// <summary>
        ///
        /// </summary>
        Feedback,
        /// <summary>
        ///
        /// </summary>
        Github,
        /// <summary>
        ///
        /// </summary>
        Gitlab,
        /// <summary>
        ///
        /// </summary>
        Import,
        /// <summary>
        ///
        /// </summary>
        Link,
        /// <summary>
        ///
        /// </summary>
        Mail,
        /// <summary>
        ///
        /// </summary>
        NsnbAutoApprove,
        /// <summary>
        ///
        /// </summary>
        NsnbHobbyUpgrade,
        /// <summary>
        ///
        /// </summary>
        NsnbInvite,
        /// <summary>
        ///
        /// </summary>
        NsnbRedeploy,
        /// <summary>
        ///
        /// </summary>
        NsnbRedeployAttributionCard,
        /// <summary>
        ///
        /// </summary>
        NsnbRequestAccess,
        /// <summary>
        ///
        /// </summary>
        NsnbViewerUpgrade,
        /// <summary>
        ///
        /// </summary>
        OrgAdminSync,
        /// <summary>
        ///
        /// </summary>
        OrganizationTeams,
        /// <summary>
        ///
        /// </summary>
        Saml,
        /// <summary>
        ///
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared39b84c098d962a66JoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared39b84c098d962a66JoinedFromOrigin value)
        {
            return value switch
            {
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.AccountUpdate => "account-update",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Bitbucket => "bitbucket",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Dsync => "dsync",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Feedback => "feedback",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Github => "github",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Gitlab => "gitlab",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Import => "import",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Link => "link",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Mail => "mail",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbInvite => "nsnb-invite",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.OrgAdminSync => "org-admin-sync",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.OrganizationTeams => "organization-teams",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Saml => "saml",
                AutoSDKShared39b84c098d962a66JoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared39b84c098d962a66JoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "account-update" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.AccountUpdate,
                "bitbucket" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Bitbucket,
                "dsync" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Dsync,
                "feedback" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Feedback,
                "github" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Github,
                "gitlab" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Gitlab,
                "import" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Import,
                "link" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Link,
                "mail" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Mail,
                "nsnb-auto-approve" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.NsnbViewerUpgrade,
                "org-admin-sync" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.OrgAdminSync,
                "organization-teams" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.OrganizationTeams,
                "saml" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Saml,
                "teams" => AutoSDKShared39b84c098d962a66JoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}