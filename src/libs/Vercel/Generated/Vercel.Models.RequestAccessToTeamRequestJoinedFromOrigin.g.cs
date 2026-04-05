
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The origin of the request.<br/>
    /// Example: github
    /// </summary>
    public enum RequestAccessToTeamRequestJoinedFromOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
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
        OrganizationTeams,
        /// <summary>
        /// 
        /// </summary>
        Teams,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestAccessToTeamRequestJoinedFromOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAccessToTeamRequestJoinedFromOrigin value)
        {
            return value switch
            {
                RequestAccessToTeamRequestJoinedFromOrigin.Bitbucket => "bitbucket",
                RequestAccessToTeamRequestJoinedFromOrigin.Feedback => "feedback",
                RequestAccessToTeamRequestJoinedFromOrigin.Github => "github",
                RequestAccessToTeamRequestJoinedFromOrigin.Gitlab => "gitlab",
                RequestAccessToTeamRequestJoinedFromOrigin.Import => "import",
                RequestAccessToTeamRequestJoinedFromOrigin.OrganizationTeams => "organization-teams",
                RequestAccessToTeamRequestJoinedFromOrigin.Teams => "teams",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAccessToTeamRequestJoinedFromOrigin? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => RequestAccessToTeamRequestJoinedFromOrigin.Bitbucket,
                "feedback" => RequestAccessToTeamRequestJoinedFromOrigin.Feedback,
                "github" => RequestAccessToTeamRequestJoinedFromOrigin.Github,
                "gitlab" => RequestAccessToTeamRequestJoinedFromOrigin.Gitlab,
                "import" => RequestAccessToTeamRequestJoinedFromOrigin.Import,
                "organization-teams" => RequestAccessToTeamRequestJoinedFromOrigin.OrganizationTeams,
                "teams" => RequestAccessToTeamRequestJoinedFromOrigin.Teams,
                _ => null,
            };
        }
    }
}