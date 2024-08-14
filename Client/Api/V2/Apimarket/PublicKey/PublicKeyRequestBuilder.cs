// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.V2.Apimarket.PublicKey
{
    /// <summary>
    /// Builds and executes requests for operations under \api\v2\apimarket\public-key
    /// </summary>
    public class PublicKeyRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PublicKeyRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/apimarket/public-key", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKeyRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PublicKeyRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/v2/apimarket/public-key", rawUrl)
        {
        }
        /// <summary>
        /// GET Public Key
        /// </summary>
        /// <returns>A <see cref="Stream"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKey5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// GET Public Key
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKeyRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKeyRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.V2.Apimarket.PublicKey.PublicKeyRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class PublicKeyRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
