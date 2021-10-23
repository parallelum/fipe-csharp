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
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Br.Com.Parallelum.Fipe.Client;
using Br.Com.Parallelum.Fipe.Api;
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
            // TODO uncomment below to test 'IsType' FipeApi
            //Assert.IsType<FipeApi>(instance);
        }

        /// <summary>
        /// Test GetBrandsByType
        /// </summary>
        [Fact]
        public void GetBrandsByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VehiclesType vehicleType = null;
            //var response = instance.GetBrandsByType(vehicleType);
            //Assert.IsType<List<NamedCode>>(response);
        }

        /// <summary>
        /// Test GetFipeInfo
        /// </summary>
        [Fact]
        public void GetFipeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VehiclesType vehicleType = null;
            //int brandId = null;
            //int modelId = null;
            //string yearId = null;
            //int? reference = null;
            //var response = instance.GetFipeInfo(vehicleType, brandId, modelId, yearId, reference);
            //Assert.IsType<FipeResult>(response);
        }

        /// <summary>
        /// Test GetModelsByBrand
        /// </summary>
        [Fact]
        public void GetModelsByBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VehiclesType vehicleType = null;
            //int brandId = null;
            //var response = instance.GetModelsByBrand(vehicleType, brandId);
            //Assert.IsType<List<NamedCode>>(response);
        }

        /// <summary>
        /// Test GetReferences
        /// </summary>
        [Fact]
        public void GetReferencesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetReferences();
            //Assert.IsType<List<Reference>>(response);
        }

        /// <summary>
        /// Test GetYearByModel
        /// </summary>
        [Fact]
        public void GetYearByModelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VehiclesType vehicleType = null;
            //int brandId = null;
            //int modelId = null;
            //var response = instance.GetYearByModel(vehicleType, brandId, modelId);
            //Assert.IsType<List<NamedCode>>(response);
        }
    }
}