
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared362c8e760cc311d9JoinedFromOrigin
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
    public static class AutoSDKShared362c8e760cc311d9JoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared362c8e760cc311d9JoinedFromOrigin value)
        {
            return value switch
            {
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.AccountUpdate => "account-update",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Bitbucket => "bitbucket",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Dsync => "dsync",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Feedback => "feedback",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Github => "github",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Gitlab => "gitlab",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Import => "import",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Link => "link",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Mail => "mail",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbInvite => "nsnb-invite",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.OrganizationTeams => "organization-teams",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Saml => "saml",
                AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared362c8e760cc311d9JoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "account-update" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.AccountUpdate,
                "bitbucket" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Bitbucket,
                "dsync" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Dsync,
                "feedback" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Feedback,
                "github" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Github,
                "gitlab" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Gitlab,
                "import" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Import,
                "link" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Link,
                "mail" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Mail,
                "nsnb-auto-approve" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.OrganizationTeams,
                "saml" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Saml,
                "teams" => AutoSDKShared362c8e760cc311d9JoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}