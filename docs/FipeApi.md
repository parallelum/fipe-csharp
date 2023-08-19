# Br.Com.Parallelum.Fipe.Api.FipeApi

All URIs are relative to *https://parallelum.com.br/fipe/api/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBrandsByType**](FipeApi.md#getbrandsbytype) | **GET** /{vehicleType}/brands | Brands by type |
| [**GetFipeInfo**](FipeApi.md#getfipeinfo) | **GET** /{vehicleType}/brands/{brandId}/models/{modelId}/years/{yearId} | Fipe info |
| [**GetHistoryByFipeCode**](FipeApi.md#gethistorybyfipecode) | **GET** /{vehicleType}/{fipeCode}/years/{yearId}/history | Fipe price history by Fipe code |
| [**GetInfoByFipeCode**](FipeApi.md#getinfobyfipecode) | **GET** /{vehicleType}/{fipeCode}/years/{yearId} | Fipe info by Fipe code |
| [**GetModelsByBrand**](FipeApi.md#getmodelsbybrand) | **GET** /{vehicleType}/brands/{brandId}/models | Models by brand |
| [**GetReferences**](FipeApi.md#getreferences) | **GET** /references | Fipe month references |
| [**GetYearByModel**](FipeApi.md#getyearbymodel) | **GET** /{vehicleType}/brands/{brandId}/models/{modelId}/years | Years by model |
| [**GetYearsByFipeCode**](FipeApi.md#getyearsbyfipecode) | **GET** /{vehicleType}/{fipeCode}/years | Years by Fipe code |

<a id="getbrandsbytype"></a>
# **GetBrandsByType**
> List&lt;NamedCode&gt; GetBrandsByType (VehiclesType vehicleType)

Brands by type

Returns brands for the type of vehicle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetBrandsByTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = (VehiclesType) "cars";  // VehiclesType | Type of vehicle

            try
            {
                // Brands by type
                List<NamedCode> result = apiInstance.GetBrandsByType(vehicleType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetBrandsByType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBrandsByTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Brands by type
    ApiResponse<List<NamedCode>> response = apiInstance.GetBrandsByTypeWithHttpInfo(vehicleType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetBrandsByTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |

### Return type

[**List&lt;NamedCode&gt;**](NamedCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfipeinfo"></a>
# **GetFipeInfo**
> FipeResult GetFipeInfo (VehiclesType vehicleType, int brandId, int modelId, string yearId, int? reference = null)

Fipe info

Returns the Fipe information for the vehicle (price estimation)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetFipeInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var brandId = 59;  // int | Brand of the vehicle
            var modelId = 5940;  // int | Model of the vehicle
            var yearId = 2014-3;  // string | Year for the vehicle
            var reference = 278;  // int? | Month reference code (optional) 

            try
            {
                // Fipe info
                FipeResult result = apiInstance.GetFipeInfo(vehicleType, brandId, modelId, yearId, reference);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetFipeInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFipeInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fipe info
    ApiResponse<FipeResult> response = apiInstance.GetFipeInfoWithHttpInfo(vehicleType, brandId, modelId, yearId, reference);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetFipeInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **brandId** | **int** | Brand of the vehicle |  |
| **modelId** | **int** | Model of the vehicle |  |
| **yearId** | **string** | Year for the vehicle |  |
| **reference** | **int?** | Month reference code | [optional]  |

### Return type

[**FipeResult**](FipeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethistorybyfipecode"></a>
# **GetHistoryByFipeCode**
> List&lt;FipeHistoryResult&gt; GetHistoryByFipeCode (VehiclesType vehicleType, string fipeCode, string yearId)

Fipe price history by Fipe code

Returns the price history for the vehicle (price estimation)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetHistoryByFipeCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var fipeCode = 004278-1;  // string | Fipe internal reference code
            var yearId = 2005-1;  // string | Year for the vehicle

            try
            {
                // Fipe price history by Fipe code
                List<FipeHistoryResult> result = apiInstance.GetHistoryByFipeCode(vehicleType, fipeCode, yearId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetHistoryByFipeCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHistoryByFipeCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fipe price history by Fipe code
    ApiResponse<List<FipeHistoryResult>> response = apiInstance.GetHistoryByFipeCodeWithHttpInfo(vehicleType, fipeCode, yearId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetHistoryByFipeCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **fipeCode** | **string** | Fipe internal reference code |  |
| **yearId** | **string** | Year for the vehicle |  |

### Return type

[**List&lt;FipeHistoryResult&gt;**](FipeHistoryResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinfobyfipecode"></a>
# **GetInfoByFipeCode**
> FipeResult GetInfoByFipeCode (VehiclesType vehicleType, string fipeCode, string yearId)

Fipe info by Fipe code

Returns the Fipe information for the vehicle (price estimation)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetInfoByFipeCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var fipeCode = 004278-1;  // string | Fipe internal reference code
            var yearId = 2005-1;  // string | Year for the vehicle

            try
            {
                // Fipe info by Fipe code
                FipeResult result = apiInstance.GetInfoByFipeCode(vehicleType, fipeCode, yearId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetInfoByFipeCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInfoByFipeCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fipe info by Fipe code
    ApiResponse<FipeResult> response = apiInstance.GetInfoByFipeCodeWithHttpInfo(vehicleType, fipeCode, yearId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetInfoByFipeCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **fipeCode** | **string** | Fipe internal reference code |  |
| **yearId** | **string** | Year for the vehicle |  |

### Return type

[**FipeResult**](FipeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmodelsbybrand"></a>
# **GetModelsByBrand**
> List&lt;NamedCode&gt; GetModelsByBrand (VehiclesType vehicleType, int brandId)

Models by brand

Returns models for the brand

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetModelsByBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var brandId = 59;  // int | Brand of the vehicle

            try
            {
                // Models by brand
                List<NamedCode> result = apiInstance.GetModelsByBrand(vehicleType, brandId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetModelsByBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetModelsByBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Models by brand
    ApiResponse<List<NamedCode>> response = apiInstance.GetModelsByBrandWithHttpInfo(vehicleType, brandId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetModelsByBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **brandId** | **int** | Brand of the vehicle |  |

### Return type

[**List&lt;NamedCode&gt;**](NamedCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getreferences"></a>
# **GetReferences**
> List&lt;Reference&gt; GetReferences ()

Fipe month references

Returns months and codes reference from Fipe

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetReferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);

            try
            {
                // Fipe month references
                List<Reference> result = apiInstance.GetReferences();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetReferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fipe month references
    ApiResponse<List<Reference>> response = apiInstance.GetReferencesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetReferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Reference&gt;**](Reference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getyearbymodel"></a>
# **GetYearByModel**
> List&lt;NamedCode&gt; GetYearByModel (VehiclesType vehicleType, int brandId, int modelId)

Years by model

Returns years for the specific model

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetYearByModelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var brandId = 59;  // int | Brand of the vehicle
            var modelId = 5940;  // int | Model of the vehicle

            try
            {
                // Years by model
                List<NamedCode> result = apiInstance.GetYearByModel(vehicleType, brandId, modelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetYearByModel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetYearByModelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Years by model
    ApiResponse<List<NamedCode>> response = apiInstance.GetYearByModelWithHttpInfo(vehicleType, brandId, modelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetYearByModelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **brandId** | **int** | Brand of the vehicle |  |
| **modelId** | **int** | Model of the vehicle |  |

### Return type

[**List&lt;NamedCode&gt;**](NamedCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getyearsbyfipecode"></a>
# **GetYearsByFipeCode**
> List&lt;NamedCode&gt; GetYearsByFipeCode (VehiclesType vehicleType, string fipeCode)

Years by Fipe code

Returns years available for vehicle by fipe code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Model;

namespace Example
{
    public class GetYearsByFipeCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://parallelum.com.br/fipe/api/v2";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FipeApi(httpClient, config, httpClientHandler);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var fipeCode = 004278-1;  // string | Fipe internal reference code

            try
            {
                // Years by Fipe code
                List<NamedCode> result = apiInstance.GetYearsByFipeCode(vehicleType, fipeCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetYearsByFipeCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetYearsByFipeCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Years by Fipe code
    ApiResponse<List<NamedCode>> response = apiInstance.GetYearsByFipeCodeWithHttpInfo(vehicleType, fipeCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FipeApi.GetYearsByFipeCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **vehicleType** | **VehiclesType** | Type of vehicle |  |
| **fipeCode** | **string** | Fipe internal reference code |  |

### Return type

[**List&lt;NamedCode&gt;**](NamedCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

