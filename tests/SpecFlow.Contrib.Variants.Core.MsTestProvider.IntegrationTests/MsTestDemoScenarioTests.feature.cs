// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Contrib.Variants.Core.MsTestProvider.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MsTestDemoScenarioTestsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "MsTestDemoScenarioTests.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "MsTestDemoScenarioTests", "\tIn order to verify the SpecFlow variants plugin for scenarios\r\n\tAs a developer\r\n" +
                    "\tI want to be able to run integration tests to validate the plugin", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MsTestDemoScenarioTests")))
            {
                global::SpecFlow.Contrib.Variants.Core.MsTestProvider.IntegrationTests.MsTestDemoScenarioTestsFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
            testRunner.Given("I am on the input forms page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A single test without examples or tags")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        public virtual void ASingleTestWithoutExamplesOrTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A single test without examples or tags", null, ((string[])(null)));
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with non-variant tags")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Option_1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Option_2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Option_3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Option_4")]
        public virtual void ATestWithNon_VariantTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with non-variant tags", null, new string[] {
                        "Option_1",
                        "Option_2",
                        "Option_3",
                        "Option_4"});
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("I check all the option check boxes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the tags check boxes should be checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags: Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Chrome")]
        public virtual void ATestWithVariantTags_Chrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Chrome");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags: Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Firefox")]
        public virtual void ATestWithVariantTags_Firefox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags", null, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", "Firefox");
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.When("check the checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the checkbox text is \'Success - Check box is checked\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        public virtual void ATestWithVariantTagsAndExamples(string link, string sublink, string site, string[] exampleTags, string browser)
        {
            string[] @__tags = new string[] {
                    "Browser:Chrome",
                    "Browser:Firefox"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags and examples", null, @__tags);
            this.ScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.Add("Browser", browser);
            this.ScenarioStart();
            this.FeatureBackground();
            testRunner.And(string.Format("I drill into the \'{0}\' link", link), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When(string.Format("I drill into the \'{0}\' link", sublink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("the page should be \'{0}\'", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags and examples: Input Forms_Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Input Forms_Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Link", "Input Forms")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Sublink", "Simple Form Demo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Site", "https://www.seleniumeasy.com/test/basic-first-form-demo.html")]
        public virtual void ATestWithVariantTagsAndExamples_InputForms_Chrome()
        {
            this.ATestWithVariantTagsAndExamples("Input Forms", "Simple Form Demo", "https://www.seleniumeasy.com/test/basic-first-form-demo.html", ((string[])(null)), "Chrome");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags and examples: Date pickers_Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Date pickers_Chrome")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Link", "Date pickers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Sublink", "Bootstrap Date Picker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Site", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html")]
        public virtual void ATestWithVariantTagsAndExamples_DatePickers_Chrome()
        {
            this.ATestWithVariantTagsAndExamples("Date pickers", "Bootstrap Date Picker", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html", ((string[])(null)), "Chrome");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags and examples: Input Forms_Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Input Forms_Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Link", "Input Forms")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Sublink", "Simple Form Demo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Site", "https://www.seleniumeasy.com/test/basic-first-form-demo.html")]
        public virtual void ATestWithVariantTagsAndExamples_InputForms_Firefox()
        {
            this.ATestWithVariantTagsAndExamples("Input Forms", "Simple Form Demo", "https://www.seleniumeasy.com/test/basic-first-form-demo.html", ((string[])(null)), "Firefox");
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A test with variant tags and examples: Date pickers_Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MsTestDemoScenarioTests")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Browser:Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Browser", "Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Date pickers_Firefox")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Link", "Date pickers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Sublink", "Bootstrap Date Picker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Site", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html")]
        public virtual void ATestWithVariantTagsAndExamples_DatePickers_Firefox()
        {
            this.ATestWithVariantTagsAndExamples("Date pickers", "Bootstrap Date Picker", "https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html", ((string[])(null)), "Firefox");
        }
    }
}
#pragma warning restore
#endregion
