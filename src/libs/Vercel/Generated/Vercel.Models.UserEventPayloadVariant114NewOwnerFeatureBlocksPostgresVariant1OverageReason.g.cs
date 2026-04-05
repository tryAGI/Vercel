
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason
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
    public static class UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant114NewOwnerFeatureBlocksPostgresVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}