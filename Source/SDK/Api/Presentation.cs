//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class Presentation : PayPalSerializableObject
    {
        /// <summary>
        /// A label that overrides the business name in the PayPal account on the PayPal pages. Character length and limitations: 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "brand_name")]
        public string brand_name { get; set; }

        /// <summary>
        /// A URL to logo image. Allowed vaues: `.gif`, `.jpg`, or `.png`. Limit the image to 190 pixels wide by 60 pixels high. PayPal crops images that are larger. PayPal places your logo image at the top of the cart review area. PayPal recommends that you store the image on a secure (https) server. Otherwise, web browsers display a message that checkout pages contain non-secure items. Character length and limit: 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "logo_image")]
        public string logo_image { get; set; }

        /// <summary>
        /// Locale of pages displayed by PayPal payment experience. Allowed values: `AU`, `AT`, `BE`, `BR`, `CA`, `CH`, `CN`, `DE`, `ES`, `GB`, `FR`, `IT`, `NL`, `PL`, `PT`, `RU`, `US`. The following 5-character codes are also allowed for languages in specific countries: `da_DK`, `he_IL`, `id_ID`, `ja_JP`, `no_NO`, `pt_BR`, `ru_RU`, `sv_SE`, `th_TH`, `tr_TR`, `zh_CN`, `zh_HK`, `zh_TW`.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locale_code")]
        public string locale_code { get; set; }
    }
}
