
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateRouteResponseRouteActionHeaderOp
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateRouteResponseRouteActionHeaderOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateRouteResponseRouteActionHeaderOp value)
        {
            return value switch
            {
                GenerateRouteResponseRouteActionHeaderOp.Append => "append",
                GenerateRouteResponseRouteActionHeaderOp.Delete => "delete",
                GenerateRouteResponseRouteActionHeaderOp.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateRouteResponseRouteActionHeaderOp? ToEnum(string value)
        {
            return value switch
            {
                "append" => GenerateRouteResponseRouteActionHeaderOp.Append,
                "delete" => GenerateRouteResponseRouteActionHeaderOp.Delete,
                "set" => GenerateRouteResponseRouteActionHeaderOp.Set,
                _ => null,
            };
        }
    }
}