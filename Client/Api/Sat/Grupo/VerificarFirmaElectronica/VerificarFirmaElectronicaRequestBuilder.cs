// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica
{
    /// <summary>
    /// Builds and executes requests for operations under \api\sat\grupo\verificar-firma-electronica
    /// </summary>
    public class VerificarFirmaElectronicaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerificarFirmaElectronicaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sat/grupo/verificar-firma-electronica", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VerificarFirmaElectronicaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/sat/grupo/verificar-firma-electronica", rawUrl)
        {
        }
        /// <summary>
        /// Verifica la firma electrónica de una persona física o moral; de manera criptográfica,realiza la validación de las credenciales y verifica con la Autoridad de Certificación (CA), en este caso, con el SAT,si ha expirado o ha dejado de representar al usuario.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostResponse?> PostAsVerificarFirmaElectronicaPostResponseAsync(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostResponse> PostAsVerificarFirmaElectronicaPostResponseAsync(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostResponse>(requestInfo, KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Verifica la firma electrónica de una persona física o moral; de manera criptográfica,realiza la validación de las credenciales y verifica con la Autoridad de Certificación (CA), en este caso, con el SAT,si ha expirado o ha dejado de representar al usuario.
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica400Error">When receiving a 400 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica401Error">When receiving a 401 status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica5XXError">When receiving a 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsVerificarFirmaElectronicaPostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaResponse?> PostAsync(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaResponse> PostAsync(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica400Error.CreateFromDiscriminatorValue },
                { "401", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica401Error.CreateFromDiscriminatorValue },
                { "4XX", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica4XXError.CreateFromDiscriminatorValue },
                { "5XX", KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronica5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaResponse>(requestInfo, KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Verifica la firma electrónica de una persona física o moral; de manera criptográfica,realiza la validación de las credenciales y verifica con la Autoridad de Certificación (CA), en este caso, con el SAT,si ha expirado o ha dejado de representar al usuario.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaRequestBuilder WithUrl(string rawUrl)
        {
            return new KiotaPosts.Client.Api.Sat.Grupo.VerificarFirmaElectronica.VerificarFirmaElectronicaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class VerificarFirmaElectronicaRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
