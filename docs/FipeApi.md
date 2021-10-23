# Br.Com.Parallelum.Fipe.Api.FipeApi

All URIs are relative to *https://parallelum.com.br/fipe/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBrandsByType**](FipeApi.md#getbrandsbytype) | **GET** /{vehicleType}/brands | Brands by type
[**GetFipeInfo**](FipeApi.md#getfipeinfo) | **GET** /{vehicleType}/brands/{brandId}/models/{modelId}/years/{yearId} | Fipe info
[**GetModelsByBrand**](FipeApi.md#getmodelsbybrand) | **GET** /{vehicleType}/brands/{brandId}/models | Models by brand
[**GetReferences**](FipeApi.md#getreferences) | **GET** /references | Fipe month references
[**GetYearByModel**](FipeApi.md#getyearbymodel) | **GET** /{vehicleType}/brands/{brandId}/models/{modelId}/years | Years for model


<a name="getbrandsbytype"></a>
# **GetBrandsByType**
> List&lt;NamedCode&gt; GetBrandsByType (VehiclesType vehicleType)

Brands by type

Returns brands for the type of vehicle

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            var apiInstance = new FipeApi(config);
            var vehicleType = ;  // VehiclesType | Type of vehicle

            try
            {
                // Brands by type
                List<NamedCode> result = apiInstance.GetBrandsByType(vehicleType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetBrandsByType: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleType** | **VehiclesType**| Type of vehicle | 

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

<a name="getfipeinfo"></a>
# **GetFipeInfo**
> FipeResult GetFipeInfo (VehiclesType vehicleType, int brandId, int modelId, string yearId, int? reference = null)

Fipe info

Returns the Fipe information for the vehicle (price estimation)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            var apiInstance = new FipeApi(config);
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
                Debug.Print("Exception when calling FipeApi.GetFipeInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleType** | **VehiclesType**| Type of vehicle | 
 **brandId** | **int**| Brand of the vehicle | 
 **modelId** | **int**| Model of the vehicle | 
 **yearId** | **string**| Year for the vehicle | 
 **reference** | **int?**| Month reference code | [optional] 

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

<a name="getmodelsbybrand"></a>
# **GetModelsByBrand**
> List&lt;NamedCode&gt; GetModelsByBrand (VehiclesType vehicleType, int brandId)

Models by brand

Returns models for the brand

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            var apiInstance = new FipeApi(config);
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
                Debug.Print("Exception when calling FipeApi.GetModelsByBrand: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleType** | **VehiclesType**| Type of vehicle | 
 **brandId** | **int**| Brand of the vehicle | 

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

<a name="getreferences"></a>
# **GetReferences**
> List&lt;Reference&gt; GetReferences ()

Fipe month references

Returns months and codes reference from Fipe

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            var apiInstance = new FipeApi(config);

            try
            {
                // Fipe month references
                List<Reference> result = apiInstance.GetReferences();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetReferences: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
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

<a name="getyearbymodel"></a>
# **GetYearByModel**
> List&lt;NamedCode&gt; GetYearByModel (VehiclesType vehicleType, int brandId, int modelId)

Years for model

Returns years for the specific model

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
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
            var apiInstance = new FipeApi(config);
            var vehicleType = cars;  // VehiclesType | Type of vehicle
            var brandId = 59;  // int | Brand of the vehicle
            var modelId = 5940;  // int | Model of the vehicle

            try
            {
                // Years for model
                List<NamedCode> result = apiInstance.GetYearByModel(vehicleType, brandId, modelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FipeApi.GetYearByModel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleType** | **VehiclesType**| Type of vehicle | 
 **brandId** | **int**| Brand of the vehicle | 
 **modelId** | **int**| Model of the vehicle | 

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

