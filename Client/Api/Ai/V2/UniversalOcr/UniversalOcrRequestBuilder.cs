// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Ai.V2.UniversalOcr
{
    /// <summary>
    /// Builds and executes requests for operations under \api\ai\v2\universal-ocr
    /// </summary>
    public class UniversalOcrRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UniversalOcrRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/ai/v2/universal-ocr", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UniversalOcrRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/ai/v2/universal-ocr", rawUrl)
        {
        }
        /// <summary>
        /// Transforma tus imágenes y documentos escaneados en texto editable y dejar de perder tiempo hoy mismo. Este es un modelo de IA propio, no usamos servicios de terceros.
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PostAsync(KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> PostAsync(KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcr5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Transforma tus imágenes y documentos escaneados en texto editable y dejar de perder tiempo hoy mismo. Este es un modelo de IA propio, no usamos servicios de terceros.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "multipart/form-data", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Ai.V2.UniversalOcr.UniversalOcrRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class UniversalOcrRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}