// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral
{
    /// <summary>
    /// Builds and executes requests for operations under \api\imss\grupo\historial-laboral
    /// </summary>
    public class HistorialLaboralRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistorialLaboralRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss/grupo/historial-laboral?curp={curp}&nss={nss}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistorialLaboralRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/imss/grupo/historial-laboral?curp={curp}&nss={nss}", rawUrl)
        {
        }
        /// <summary>
        /// Obtiene el historial Laboral registrado en el IMSS con sus semanas cotizadas, fechas de alta y baja, asi como el salario, razon social y registro patronal del empleador._Nota: Cada seguro social solo puede ser consultado 3 veces por dia, al exceder ese limite el sistema del seguro social bloquea las peticiones hasta pasar 24hrs._
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse?> PostAsHistorialLaboralPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse> PostAsHistorialLaboralPostResponseAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse>(requestInfo, KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Obtiene el historial Laboral registrado en el IMSS con sus semanas cotizadas, fechas de alta y baja, asi como el salario, razon social y registro patronal del empleador._Nota: Cada seguro social solo puede ser consultado 3 veces por dia, al exceder ese limite el sistema del seguro social bloquea las peticiones hasta pasar 24hrs._
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral5XXError">When receiving a 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsHistorialLaboralPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralResponse?> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralResponse> PostAsync(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboral5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralResponse>(requestInfo, KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Obtiene el historial Laboral registrado en el IMSS con sus semanas cotizadas, fechas de alta y baja, asi como el salario, razon social y registro patronal del empleador._Nota: Cada seguro social solo puede ser consultado 3 veces por dia, al exceder ese limite el sistema del seguro social bloquea las peticiones hasta pasar 24hrs._
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Obtiene el historial Laboral registrado en el IMSS con sus semanas cotizadas, fechas de alta y baja, asi como el salario, razon social y registro patronal del empleador._Nota: Cada seguro social solo puede ser consultado 3 veces por dia, al exceder ese limite el sistema del seguro social bloquea las peticiones hasta pasar 24hrs._
        /// </summary>
        public class HistorialLaboralRequestBuilderPostQueryParameters 
        {
            /// <summary>Clave Unica de Registro de Poblacion</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("curp")]
            public string? Curp { get; set; }
#nullable restore
#else
            [QueryParameter("curp")]
            public string Curp { get; set; }
#endif
            /// <summary>Numero de Seguro Social</summary>
            [QueryParameter("nss")]
            public int? Nss { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class HistorialLaboralRequestBuilderPostRequestConfiguration : RequestConfiguration<KiotaPosts.Client.Api.Imss.Grupo.HistorialLaboral.HistorialLaboralRequestBuilder.HistorialLaboralRequestBuilderPostQueryParameters>
        {
        }
    }
}