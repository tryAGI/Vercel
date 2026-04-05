
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentCheckRunResponseSourceVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentCheckRunResponseSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentCheckRunResponseSourceVariant3Kind value)
        {
            return value switch
            {
                GetDeploymentCheckRunResponseSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentCheckRunResponseSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => GetDeploymentCheckRunResponseSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}