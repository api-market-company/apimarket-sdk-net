// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta
{
    /// <summary>
    /// Builds and executes requests for operations under \api\infonavit\grupo\obtener-cuenta
    /// </summary>
    public class ObtenerCuentaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObtenerCuentaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/infonavit/grupo/obtener-cuenta{?nss*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObtenerCuentaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/infonavit/grupo/obtener-cuenta{?nss*}", rawUrl)
        {
        }
        /// <summary>
        /// Endpoint para realizar la consulta de creditos en el infonavit, obtenida mediante el Numero de seguro social de la persona.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaPostResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaPostResponse?> PostAsObtenerCuentaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaPostResponse> PostAsObtenerCuentaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaPostResponse>(requestInfo, KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Endpoint para realizar la consulta de creditos en el infonavit, obtenida mediante el Numero de seguro social de la persona.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta5XXError">When receiving a 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsObtenerCuentaPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaResponse?> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaResponse> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuenta5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaResponse>(requestInfo, KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Endpoint para realizar la consulta de creditos en el infonavit, obtenida mediante el Numero de seguro social de la persona.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Endpoint para realizar la consulta de creditos en el infonavit, obtenida mediante el Numero de seguro social de la persona.
        /// </summary>
        public class ObtenerCuentaRequestBuilderPostQueryParameters 
        {
            [QueryParameter("nss")]
            public int? Nss { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ObtenerCuentaRequestBuilderPostRequestConfiguration : RequestConfiguration<KiotaPosts.Client.Api.Infonavit.Grupo.ObtenerCuenta.ObtenerCuentaRequestBuilder.ObtenerCuentaRequestBuilderPostQueryParameters>
        {
        }
    }
}
