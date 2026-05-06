
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant280Source
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
    public static class UserEventPayloadVariant280SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant280Source value)
        {
            return value switch
            {
                UserEventPayloadVariant280Source.Bitbucket => "bitbucket",
                UserEventPayloadVariant280Source.Dsync => "dsync",
                UserEventPayloadVariant280Source.Feedback => "feedback",
                UserEventPayloadVariant280Source.Github => "github",
                UserEventPayloadVariant280Source.Gitlab => "gitlab",
                UserEventPayloadVariant280Source.Import => "import",
                UserEventPayloadVariant280Source.Link => "link",
                UserEventPayloadVariant280Source.Mail => "mail",
                UserEventPayloadVariant280Source.NsnbAutoApprove => "nsnb-auto-approve",
                UserEventPayloadVariant280Source.NsnbHobbyUpgrade => "nsnb-hobby-upgrade",
                UserEventPayloadVariant280Source.NsnbInvite => "nsnb-invite",
                UserEventPayloadVariant280Source.NsnbRedeploy => "nsnb-redeploy",
                UserEventPayloadVariant280Source.NsnbRedeployAttributionCard => "nsnb-redeploy-attribution-card",
                UserEventPayloadVariant280Source.NsnbRequestAccess => "nsnb-request-access",
                UserEventPayloadVariant280Source.NsnbViewerUpgrade => "nsnb-viewer-upgrade",
                UserEventPayloadVariant280Source.OrganizationTeams => "organization-teams",
                UserEventPayloadVariant280Source.Saml => "saml",
                UserEventPayloadVariant280Source.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant280Source? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => UserEventPayloadVariant280Source.Bitbucket,
                "dsync" => UserEventPayloadVariant280Source.Dsync,
                "feedback" => UserEventPayloadVariant280Source.Feedback,
                "github" => UserEventPayloadVariant280Source.Github,
                "gitlab" => UserEventPayloadVariant280Source.Gitlab,
                "import" => UserEventPayloadVariant280Source.Import,
                "link" => UserEventPayloadVariant280Source.Link,
                "mail" => UserEventPayloadVariant280Source.Mail,
                "nsnb-auto-approve" => UserEventPayloadVariant280Source.NsnbAutoApprove,
                "nsnb-hobby-upgrade" => UserEventPayloadVariant280Source.NsnbHobbyUpgrade,
                "nsnb-invite" => UserEventPayloadVariant280Source.NsnbInvite,
                "nsnb-redeploy" => UserEventPayloadVariant280Source.NsnbRedeploy,
                "nsnb-redeploy-attribution-card" => UserEventPayloadVariant280Source.NsnbRedeployAttributionCard,
                "nsnb-request-access" => UserEventPayloadVariant280Source.NsnbRequestAccess,
                "nsnb-viewer-upgrade" => UserEventPayloadVariant280Source.NsnbViewerUpgrade,
                "organization-teams" => UserEventPayloadVariant280Source.OrganizationTeams,
                "saml" => UserEventPayloadVariant280Source.Saml,
                "teams" => UserEventPayloadVariant280Source.Teams,
                _ => null,
            };
        }
    }
}