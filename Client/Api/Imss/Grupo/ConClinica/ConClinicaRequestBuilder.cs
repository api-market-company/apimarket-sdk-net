// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Imss.Grupo.ConClinica
{
    /// <summary>
    /// Builds and executes requests for operations under \api\imss\grupo\con-clinica
    /// </summary>
    public class ConClinicaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConClinicaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss/grupo/con-clinica?curp={curp}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConClinicaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss/grupo/con-clinica?curp={curp}", rawUrl)
        {
        }
        /// <summary>
        /// Valida si el numero de seguro social asociado a la CURP esta dado de alta y asignado en una clinica
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaPostResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaPostResponse?> PostAsConClinicaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaPostResponse> PostAsConClinicaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaPostResponse>(requestInfo, KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Valida si el numero de seguro social asociado a la CURP esta dado de alta y asignado en una clinica
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica5XXError">When receiving a 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsConClinicaPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaResponse?> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaResponse> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinica5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaResponse>(requestInfo, KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Valida si el numero de seguro social asociado a la CURP esta dado de alta y asignado en una clinica
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Valida si el numero de seguro social asociado a la CURP esta dado de alta y asignado en una clinica
        /// </summary>
        public class ConClinicaRequestBuilderPostQueryParameters 
        {
            /// <summary>Clave Unica de Registro de poblacion</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("curp")]
            public string? Curp { get; set; }
#nullable restore
#else
            [QueryParameter("curp")]
            public string Curp { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ConClinicaRequestBuilderPostRequestConfiguration : RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.ConClinica.ConClinicaRequestBuilder.ConClinicaRequestBuilderPostQueryParameters>
        {
        }
    }
}
