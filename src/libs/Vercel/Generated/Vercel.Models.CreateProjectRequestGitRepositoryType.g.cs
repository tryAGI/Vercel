
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The Git Provider of the repository
    /// </summary>
    public enum CreateProjectRequestGitRepositoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        GithubLimited,
        /// <summary>
        /// 
        /// </summary>
        Gitlab,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestGitRepositoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestGitRepositoryType value)
        {
            return value switch
            {
                CreateProjectRequestGitRepositoryType.Bitbucket => "bitbucket",
                CreateProjectRequestGitRepositoryType.Github => "github",
                CreateProjectRequestGitRepositoryType.GithubLimited => "github-limited",
                CreateProjectRequestGitRepositoryType.Gitlab => "gitlab",
                CreateProjectRequestGitRepositoryType.Vercel => "vercel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestGitRepositoryType? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => CreateProjectRequestGitRepositoryType.Bitbucket,
                "github" => CreateProjectRequestGitRepositoryType.Github,
                "github-limited" => CreateProjectRequestGitRepositoryType.GithubLimited,
                "gitlab" => CreateProjectRequestGitRepositoryType.Gitlab,
                "vercel" => CreateProjectRequestGitRepositoryType.Vercel,
                _ => null,
            };
        }
    }
}