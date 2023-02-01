﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Regular_Task_Creator.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EditTemplateFeature : object, Xunit.IClassFixture<EditTemplateFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "EditTemplate.feature"
#line hidden
        
        public EditTemplateFeature(EditTemplateFeature.FixtureData fixtureData, Regular_Task_Creator_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Edit Template", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Родитель может изменить шаблон")]
        [Xunit.TraitAttribute("FeatureTitle", "Edit Template")]
        [Xunit.TraitAttribute("Description", "Родитель может изменить шаблон")]
        public virtual void РодительМожетИзменитьШаблон()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Родитель может изменить шаблон", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Phone",
                            "Email",
                            "Adult"});
                table15.AddRow(new string[] {
                            "Папа",
                            "+79180000001",
                            "father@family.com",
                            "true"});
                table15.AddRow(new string[] {
                            "Сын",
                            "+79180000002",
                            "son@family.com",
                            "false"});
#line 6
 testRunner.Given("семья из", ((string)(null)), table15, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Name",
                            "Recreate Days",
                            "Description"});
                table16.AddRow(new string[] {
                            "1",
                            "Помыть посуду",
                            "M,T,Th",
                            "Используй моющее средство"});
#line 10
 testRunner.And("список шаблонов из", ((string)(null)), table16, "And ");
#line hidden
#line 13
 testRunner.And("в систему вошел Папа", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When("пользователь изменяет шаблон с Id 1 на шаблон (Помыть посуду, (M,Th), )", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("в списке есть шаблон (Помыть посуду, (M,Th), )", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Ребенок не может изменить шаблон")]
        [Xunit.TraitAttribute("FeatureTitle", "Edit Template")]
        [Xunit.TraitAttribute("Description", "Ребенок не может изменить шаблон")]
        public virtual void РебенокНеМожетИзменитьШаблон()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ребенок не может изменить шаблон", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Phone",
                            "Email",
                            "Adult"});
                table17.AddRow(new string[] {
                            "Папа",
                            "+79180000001",
                            "father@family.com",
                            "true"});
                table17.AddRow(new string[] {
                            "Сын",
                            "+79180000002",
                            "son@family.com",
                            "false"});
#line 18
 testRunner.Given("семья из", ((string)(null)), table17, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Name",
                            "Recreate Days",
                            "Description"});
                table18.AddRow(new string[] {
                            "1",
                            "Помыть посуду",
                            "M,T,Th",
                            "Используй моющее средство"});
#line 22
 testRunner.And("список шаблонов из", ((string)(null)), table18, "And ");
#line hidden
#line 25
 testRunner.And("в систему вошел Сын", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("пользователь изменяет шаблон с Id 1 на шаблон (Помыть посуду, (M,Th), )", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("в списке есть шаблон (Помыть посуду, (M,T,Th), Используй моющее средство)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Родитель не может изменить несуществующий шаблон")]
        [Xunit.TraitAttribute("FeatureTitle", "Edit Template")]
        [Xunit.TraitAttribute("Description", "Родитель не может изменить несуществующий шаблон")]
        public virtual void РодительНеМожетИзменитьНесуществующийШаблон()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Родитель не может изменить несуществующий шаблон", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Phone",
                            "Email",
                            "Adult"});
                table19.AddRow(new string[] {
                            "Папа",
                            "+79180000001",
                            "father@family.com",
                            "true"});
                table19.AddRow(new string[] {
                            "Сын",
                            "+79180000002",
                            "son@family.com",
                            "false"});
#line 30
 testRunner.Given("семья из", ((string)(null)), table19, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Name",
                            "Recreate Days",
                            "Description"});
                table20.AddRow(new string[] {
                            "1",
                            "Помыть посуду",
                            "M,T,Th",
                            "Используй моющее средство"});
#line 34
 testRunner.And("список шаблонов из", ((string)(null)), table20, "And ");
#line hidden
#line 37
 testRunner.And("в систему вошел Папа", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When("пользователь изменяет шаблон с Id 1 на шаблон (Помыть посуду, (M,T,Th,F), )", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("в списке есть шаблон (Помыть посуду, (M,T), Используй моющее средство)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EditTemplateFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EditTemplateFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
