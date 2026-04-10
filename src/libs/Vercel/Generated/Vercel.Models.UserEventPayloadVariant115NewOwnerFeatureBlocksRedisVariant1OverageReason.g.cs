
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason
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
    public static class UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant115NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}