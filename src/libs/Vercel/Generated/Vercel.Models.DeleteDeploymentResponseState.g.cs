
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A constant with the final state of the deployment.
    /// </summary>
    public enum DeleteDeploymentResponseState
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteDeploymentResponseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteDeploymentResponseState value)
        {
            return value switch
            {
                DeleteDeploymentResponseState.Deleted => "DELETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteDeploymentResponseState? ToEnum(string value)
        {
            return value switch
            {
                "DELETED" => DeleteDeploymentResponseState.Deleted,
                _ => null,
            };
        }
    }
}