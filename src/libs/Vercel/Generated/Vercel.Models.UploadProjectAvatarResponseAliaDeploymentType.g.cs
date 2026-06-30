
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UploadProjectAvatarResponseAliaDeploymentType
    {
        /// <summary>
        /// 
        /// </summary>
        Lambdas,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UploadProjectAvatarResponseAliaDeploymentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadProjectAvatarResponseAliaDeploymentType value)
        {
            return value switch
            {
                UploadProjectAvatarResponseAliaDeploymentType.Lambdas => "LAMBDAS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadProjectAvatarResponseAliaDeploymentType? ToEnum(string value)
        {
            return value switch
            {
                "LAMBDAS" => UploadProjectAvatarResponseAliaDeploymentType.Lambdas,
                _ => null,
            };
        }
    }
}