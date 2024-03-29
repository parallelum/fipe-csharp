/*
 * Fipe API
 *
 * API de Consulta Tabela FIPE fornece preços médios de veículos no mercado nacional. Atualizada mensalmente com dados extraidos da tabela FIPE.    Essa API Fipe utiliza banco de dados próprio, onde todas as requisições acontecem internamente, sem sobrecarregar o Web Service da Fipe, evitando assim bloqueios por múltiplos acessos.    A API está online desde 2015 e totalmente gratuíta. Gostaria que ele continuasse gratuíta? O que acha de me pagar uma cerveja? 🍺    [![Make a donation](https://www.paypalobjects.com/pt_BR/BR/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=QUPMYWH6XAC5G)   ### Fipe API SDKs  - [Fipe Go SDK](https://pkg.go.dev/github.com/parallelum/fipe-go)  - [Fipe .NetCore Nuget SDK](https://www.nuget.org/packages/Br.Com.Parallelum.Fipe/)  - [Fipe Javascript SDK](https://github.com/deividfortuna/fipe-promise)  
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: deividfortuna@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace Br.Com.Parallelum.Fipe.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
