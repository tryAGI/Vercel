
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin
    {
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
    public static class UserEventPayloadVariant116NewOwnerTeamJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Bitbucket => "bitbucket",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Dsync => "dsync",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Feedback => "feedback",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Github => "github",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Gitlab => "gitlab",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Import => "import",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Link => "link",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Mail => "mail",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Saml => "saml",
                UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Bitbucket,
                "dsync" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Dsync,
                "feedback" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Feedback,
                "github" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Github,
                "gitlab" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Gitlab,
                "import" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Import,
                "link" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Link,
                "mail" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.OrganizationTeams,
                "saml" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Saml,
                "teams" => UserEventPayloadVariant116NewOwnerTeamJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}