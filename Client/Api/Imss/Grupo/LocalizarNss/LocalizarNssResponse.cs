// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Api.Imss.Grupo.LocalizarNss
{
    [Obsolete("This class is obsolete. Use LocalizarNssPostResponse instead.")]
    #pragma warning disable CS1591
    public class LocalizarNssResponse : KiotaPosts.Client.Api.Imss.Grupo.LocalizarNss.LocalizarNssPostResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Api.Imss.Grupo.LocalizarNss.LocalizarNssResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KiotaPosts.Client.Api.Imss.Grupo.LocalizarNss.LocalizarNssResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Api.Imss.Grupo.LocalizarNss.LocalizarNssResponse();
        }
    }
}
