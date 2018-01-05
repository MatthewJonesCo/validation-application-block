// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Integration.AspNet.Tests
{
    [TestClass]
    public class WebIntegrationFixture : WebIntegrationFixtureBase
    {
        [TestInitialize]
        public new void Setup()
        {
            base.Setup();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationWithLocalType.aspx")]
        [TestCategory("Integration")]
        public new void CanUseValidatorWithAttributesWithTypeLocalToWebApp()
        {
            base.CanUseValidatorWithAttributesWithTypeLocalToWebApp();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationUsingAttributesWithNonLocalType.aspx")]
        [TestCategory("Integration")]
        public new void CanUseValidatorWithAttributesWithTypeFromReferencedAssemblyToWebApp()
        {
            base.CanUseValidatorWithAttributesWithTypeFromReferencedAssemblyToWebApp();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationUsingConfigurationWithNonLocalType.aspx")]
        [TestCategory("Integration")]
        public new void CanUseValidatorFromConfigurationWithTypeFromReferencedAssemblyToWebApp()
        {
            base.CanUseValidatorFromConfigurationWithTypeFromReferencedAssemblyToWebApp();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationWithDefaultTypeConversion.aspx")]
        [TestCategory("Integration")]
        public new void UsingValidatorWithDefaultTypeConversionWillValidateTheConvertedTargetControlValue()
        {
            base.UsingValidatorWithDefaultTypeConversionWillValidateTheConvertedTargetControlValue();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationWithDefaultTypeConversionForEnum.aspx")]
        [TestCategory("Integration")]
        public new void UsingValidatorWithDefaultTypeConversionForEnumWillValidateTheConvertedTargetControlValue()
        {
            base.UsingValidatorWithDefaultTypeConversionForEnumWillValidateTheConvertedTargetControlValue();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationWithCustomTypeConversion.aspx")]
        [TestCategory("Integration")]
        public new void UsingValidatorWithCustomTypeConversionWillValidateTheCustomConvertedTargetControlValue()
        {
            base.UsingValidatorWithCustomTypeConversionWillValidateTheCustomConvertedTargetControlValue();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValidationWithFailingCustomTypeConversion.aspx")]
        [TestCategory("Integration")]
        public new void UsingValidatorWithFailingCustomTypeConversionWillLogValidationErrorWithSuppliedConversionErrorMessage()
        {
            base.UsingValidatorWithFailingCustomTypeConversionWillLogValidationErrorWithSuppliedConversionErrorMessage();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValueAccess.aspx")]
        [TestCategory("Integration")]
        public new void CanGetValueForPropertyMappedToProvidedValidator()
        {
            base.CanGetValueForPropertyMappedToProvidedValidator();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValueAccess.aspx")]
        [TestCategory("Integration")]
        public new void CanGetValueForPropertyMappedToOtherValidator()
        {
            base.CanGetValueForPropertyMappedToOtherValidator();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValueAccess.aspx")]
        [TestCategory("Integration")]
        public new void CanGetValueForPropertyMappedToValidatorInSameNamingContainerAsProvidedValidator()
        {
            base.CanGetValueForPropertyMappedToValidatorInSameNamingContainerAsProvidedValidator();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValueAccess.aspx")]
        [TestCategory("Integration")]
        public new void ValueRequestForNonMappedPropertyReturnsFailure()
        {
            base.ValueRequestForNonMappedPropertyReturnsFailure();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/ValueAccessValueConvert.aspx")]
        [TestCategory("Integration")]
        public new void CanGetConvertedValueForPropertyMappedToProvidedValidator()
        {
            base.CanGetConvertedValueForPropertyMappedToProvidedValidator();
        }

        [TestMethod]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost(@"..\..\..\Integration.AspNet.Tests.Web\Web", "/Web")]
        [UrlToTest("http://localhost/CrossFieldValidationWithLocalType.aspx")]
        [TestCategory("Integration")]
        public new void CanPerformCrossFieldValidation()
        {
            base.CanPerformCrossFieldValidation();
        }
    }
}
