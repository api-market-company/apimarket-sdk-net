// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula
{
    /// <summary>
    /// Builds and executes requests for operations under \api\sep\grupo\obtener-cedula
    /// </summary>
    public class ObtenerCedulaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObtenerCedulaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sep/grupo/obtener-cedula?nombres={nombres}&paterno={paterno}{&materno*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ObtenerCedulaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sep/grupo/obtener-cedula?nombres={nombres}&paterno={paterno}{&materno*}", rawUrl)
        {
        }
        /// <summary>
        /// Busca Cedulas relacionadas a los datos enviadas en la base de datos del **Registro Nacional de Profesionistas.**_Nota: esta busqueda no es con coincidencia exacta, mostrara todos los registros que contengan los datos enviados._
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaPostResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula404Error">When receiving a 404 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaPostResponse?> PostAsObtenerCedulaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaPostResponse> PostAsObtenerCedulaPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula401Error.CreateFromDiscriminatorValue },
                { "404", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula404Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaPostResponse>(requestInfo, KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Busca Cedulas relacionadas a los datos enviadas en la base de datos del **Registro Nacional de Profesionistas.**_Nota: esta busqueda no es con coincidencia exacta, mostrara todos los registros que contengan los datos enviados._
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula404Error">When receiving a 404 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula5XXError">When receiving a 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsObtenerCedulaPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaResponse?> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaResponse> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula401Error.CreateFromDiscriminatorValue },
                { "404", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula404Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedula5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaResponse>(requestInfo, KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Busca Cedulas relacionadas a los datos enviadas en la base de datos del **Registro Nacional de Profesionistas.**_Nota: esta busqueda no es con coincidencia exacta, mostrara todos los registros que contengan los datos enviados._
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Busca Cedulas relacionadas a los datos enviadas en la base de datos del **Registro Nacional de Profesionistas.**_Nota: esta busqueda no es con coincidencia exacta, mostrara todos los registros que contengan los datos enviados._
        /// </summary>
        public class ObtenerCedulaRequestBuilderPostQueryParameters 
        {
            /// <summary>[OPCIONAL]</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("materno")]
            public string? Materno { get; set; }
#nullable restore
#else
            [QueryParameter("materno")]
            public string Materno { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("nombres")]
            public string? Nombres { get; set; }
#nullable restore
#else
            [QueryParameter("nombres")]
            public string Nombres { get; set; }
#endif
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("paterno")]
            public string? Paterno { get; set; }
#nullable restore
#else
            [QueryParameter("paterno")]
            public string Paterno { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ObtenerCedulaRequestBuilderPostRequestConfiguration : RequestConfiguration<KiotaPosts.Client.Api.Sep.Grupo.ObtenerCedula.ObtenerCedulaRequestBuilder.ObtenerCedulaRequestBuilderPostQueryParameters>
        {
        }
    }
}