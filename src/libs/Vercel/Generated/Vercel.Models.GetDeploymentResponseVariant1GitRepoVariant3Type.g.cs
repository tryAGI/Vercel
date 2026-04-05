
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDeploymentResponseVariant1GitRepoVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bitbucket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1GitRepoVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1GitRepoVariant3Type value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1GitRepoVariant3Type.Bitbucket => "bitbucket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1GitRepoVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "bitbucket" => GetDeploymentResponseVariant1GitRepoVariant3Type.Bitbucket,
                _ => null,
            };
        }
    }
}