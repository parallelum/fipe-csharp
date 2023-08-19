/*
 * Fipe API
 *
 * API de Consulta Tabela FIPE fornece preços médios de veículos no mercado nacional. Atualizada mensalmente com dados extraidos da tabela FIPE.    Essa API Fipe utiliza banco de dados próprio, onde todas as requisições acontecem internamente, sem sobrecarregar o Web Service da Fipe, evitando assim bloqueios por múltiplos acessos.    A API está online desde 2015 e totalmente gratuíta. Gostaria que ele continuasse gratuíta? O que acha de me pagar uma cerveja? 🍺    [![Make a donation](https://www.paypalobjects.com/pt_BR/BR/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=QUPMYWH6XAC5G)   ### Fipe API SDKs  - [Fipe Go SDK](https://pkg.go.dev/github.com/parallelum/fipe-go)  - [Fipe .NetCore Nuget SDK](https://www.nuget.org/packages/Br.Com.Parallelum.Fipe/)  - [Fipe Javascript SDK](https://github.com/deividfortuna/fipe-promise)  
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: deividfortuna@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Model;
using Br.Com.Parallelum.Fipe.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Br.Com.Parallelum.Fipe.Test.Model
{
    /// <summary>
    ///  Class for testing FipeHistoryResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FipeHistoryResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FipeHistoryResult
        //private FipeHistoryResult instance;

        public FipeHistoryResultTests()
        {
            // TODO uncomment below to create an instance of FipeHistoryResult
            //instance = new FipeHistoryResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FipeHistoryResult
        /// </summary>
        [Fact]
        public void FipeHistoryResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" FipeHistoryResult
            //Assert.IsType<FipeHistoryResult>(instance);
        }


        /// <summary>
        /// Test the property 'Brand'
        /// </summary>
        [Fact]
        public void BrandTest()
        {
            // TODO unit test for the property 'Brand'
        }
        /// <summary>
        /// Test the property 'Model'
        /// </summary>
        [Fact]
        public void ModelTest()
        {
            // TODO unit test for the property 'Model'
        }
        /// <summary>
        /// Test the property 'ModelYear'
        /// </summary>
        [Fact]
        public void ModelYearTest()
        {
            // TODO unit test for the property 'ModelYear'
        }
        /// <summary>
        /// Test the property 'Fuel'
        /// </summary>
        [Fact]
        public void FuelTest()
        {
            // TODO unit test for the property 'Fuel'
        }
        /// <summary>
        /// Test the property 'CodeFipe'
        /// </summary>
        [Fact]
        public void CodeFipeTest()
        {
            // TODO unit test for the property 'CodeFipe'
        }
        /// <summary>
        /// Test the property 'VehicleType'
        /// </summary>
        [Fact]
        public void VehicleTypeTest()
        {
            // TODO unit test for the property 'VehicleType'
        }
        /// <summary>
        /// Test the property 'FuelAcronym'
        /// </summary>
        [Fact]
        public void FuelAcronymTest()
        {
            // TODO unit test for the property 'FuelAcronym'
        }
        /// <summary>
        /// Test the property 'PriceHistory'
        /// </summary>
        [Fact]
        public void PriceHistoryTest()
        {
            // TODO unit test for the property 'PriceHistory'
        }

    }

}