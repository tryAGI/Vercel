
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Order of the returned events based on the timestamp.<br/>
    /// Default Value: forward<br/>
    /// Example: backward
    /// </summary>
    public enum GetDeploymentEventsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Backward,
        /// <summary>
        /// 
        /// </summary>
        Forward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentEventsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentEventsDirection value)
        {
            return value switch
            {
                GetDeploymentEventsDirection.Backward => "backward",
                GetDeploymentEventsDirection.Forward => "forward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentEventsDirection? ToEnum(string value)
        {
            return value switch
            {
                "backward" => GetDeploymentEventsDirection.Backward,
                "forward" => GetDeploymentEventsDirection.Forward,
                _ => null,
            };
        }
    }
}