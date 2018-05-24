﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Endjin.Editor.Specs.Scripts.Features.Model.Models
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Models will only accept valid children")]
    public partial class ModelsWillOnlyAcceptValidChildrenFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AcceptChild.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Models will only accept valid children", "In order to generate valid HTML\r\nAs a developer\r\nI want models to accept only val" +
                    "id children", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding valid children to a model")]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "Abbreviation", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "Anchor", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "Area", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "BidirectionalIsolation", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "BidirectionalTextOverride", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "Break", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "BringToAttention", null)]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "Button", null)]
        [NUnit.Framework.TestCaseAttribute("Anchor", "Address", null)]
        [NUnit.Framework.TestCaseAttribute("Anchor", "BlockQuote", null)]
        public virtual void AddingValidChildrenToAModel(string parent, string child, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding valid children to a model", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have a model of type \"{0}\" called \"first\"", parent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have a model of type \"{0}\" called \"second\"", child), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I add \"second\" to \"first\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the result should be a Selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("\"first\" should contain \"second\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding invalid children to a model")]
        [NUnit.Framework.TestCaseAttribute("HeadingLevel1", "HeadingLevel1", null)]
        [NUnit.Framework.TestCaseAttribute("Anchor", "Anchor", null)]
        public virtual void AddingInvalidChildrenToAModel(string parent, string child, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding invalid children to a model", exampleTags);
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given(string.Format("I have a model of type \"{0}\" called \"first\"", parent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.And(string.Format("I have a model of type \"{0}\" called \"second\"", child), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I add \"second\" to \"first\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then("the result should be null", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 31
 testRunner.And("\"first\" should not contain \"second\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
