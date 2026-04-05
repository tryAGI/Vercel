
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDeploymentCheckRunResponseSourceVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        GitProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentCheckRunResponseSourceVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentCheckRunResponseSourceVariant3Kind value)
        {
            return value switch
            {
                UpdateDeploymentCheckRunResponseSourceVariant3Kind.GitProvider => "git-provider",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentCheckRunResponseSourceVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "git-provider" => UpdateDeploymentCheckRunResponseSourceVariant3Kind.GitProvider,
                _ => null,
            };
        }
    }
}