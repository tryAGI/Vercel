
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5dd9960a4fc82febJoinedFromOrigin
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
    public static class AutoSDKShared5dd9960a4fc82febJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5dd9960a4fc82febJoinedFromOrigin value)
        {
            return value switch
            {
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.AccountUpdate => "account-update",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Bitbucket => "bitbucket",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Dsync => "dsync",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Feedback => "feedback",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Github => "github",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Gitlab => "gitlab",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Import => "import",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Link => "link",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Mail => "mail",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.OrgAdminSync => "org-admin-sync",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.OrganizationTeams => "organization-teams",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Saml => "saml",
                AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5dd9960a4fc82febJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "account-update" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.AccountUpdate,
                "bitbucket" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Bitbucket,
                "dsync" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Dsync,
                "feedback" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Feedback,
                "github" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Github,
                "gitlab" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Gitlab,
                "import" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Import,
                "link" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Link,
                "mail" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.NsnbViewerUpgrade,
                "org-admin-sync" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.OrgAdminSync,
                "organization-teams" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.OrganizationTeams,
                "saml" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Saml,
                "teams" => AutoSDKShared5dd9960a4fc82febJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}