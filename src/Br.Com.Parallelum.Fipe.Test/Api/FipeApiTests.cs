/*
 * Fipe API
 *
 * API de Consulta Tabela FIPE fornece preços médios de veículos no mercado nacional. Atualizada mensalmente com dados extraidos da tabela FIPE
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: deividfortuna@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Xunit;

using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Api;
using Br.Com.Parallelum.Fipe.Model;

// uncomment below to import models
//using Br.Com.Parallelum.Fipe.Model;

namespace Br.Com.Parallelum.Fipe.Test.Api
{
    /// <summary>
    ///  Class for testing FipeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FipeApiTests : IDisposable
    {
        private FipeApi instance;

        public FipeApiTests()
        {
            instance = new FipeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FipeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<FipeApi>(instance);
        }

        /// <summary>
        /// Test GetBrandsByType
        /// </summary>
        [Fact]
        public void GetBrandsByTypeTest()
        {
            var response = instance.GetBrandsByType(VehiclesType.Cars);
            Assert.IsType<List<NamedCode>>(response);
        }

        /// <summary>
        /// Test GetFipeInfo
        /// </summary>
        [Fact]
        public void GetFipeInfoTest()
        {
            var response = instance.GetFipeInfo(VehiclesType.Cars, 23, 1051, "1999-1");
            Assert.IsType<FipeResult>(response);
        }

        /// <summary>
        /// Test GetModelsByBrand
        /// </summary>
        [Fact]
        public void GetModelsByBrandTest()
        {
            int brandId = 23;
            var response = instance.GetModelsByBrand(VehiclesType.Cars, brandId);
            Assert.IsType<List<NamedCode>>(response);
        }

        /// <summary>
        /// Test GetReferences
        /// </summary>
        [Fact]
        public void GetReferencesTest()
        {
            var response = instance.GetReferences();
            Assert.IsType<List<Reference>>(response);
        }

        /// <summary>
        /// Test GetYearByModel
        /// </summary>
        [Fact]
        public void GetYearByModelTest()
        {
            int brandId = 23;
            int modelId = 1051;
            var response = instance.GetYearByModel(VehiclesType.Cars, brandId, modelId);
            Assert.IsType<List<NamedCode>>(response);
        }
    }
}
