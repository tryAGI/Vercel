
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeploymentCheckRunResponseSourceVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeploymentCheckRunResponseSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeploymentCheckRunResponseSourceVariant3Kind value)
        {
            return value switch
            {
                CreateDeploymentCheckRunResponseSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeploymentCheckRunResponseSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => CreateDeploymentCheckRunResponseSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}