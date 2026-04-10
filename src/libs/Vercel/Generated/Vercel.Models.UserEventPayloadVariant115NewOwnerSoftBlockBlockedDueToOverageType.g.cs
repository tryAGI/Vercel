
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        /// 
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        DataCacheRead,
        /// <summary>
        /// 
        /// </summary>
        DataCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequest,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        /// 
        /// </summary>
        FastDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        /// 
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        FluidDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionInvocation,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        /// 
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        /// 
        /// </summary>
        MonitoringMetric,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        /// 
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        /// 
        /// </summary>
        SourceImages,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        /// 
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.Artifacts => "artifacts",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth => "bandwidth",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration => "fluidDuration",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration => "functionDuration",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.SourceImages => "sourceImages",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.Artifacts,
                "bandwidth" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration,
                "functionDuration" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant115NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}