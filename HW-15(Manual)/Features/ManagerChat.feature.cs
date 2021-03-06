// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HW-15(Manual).Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Manager chat", Description="In order to contact with client\r\nAs a manager \r\nI want to had chat with client", SourceFile="Features\\ManagerChat.feature", SourceLine=0)]
    public partial class ManagerChatFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ManagerChat.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Manager chat", "In order to contact with client\r\nAs a manager \r\nI want to had chat with client", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Is is possible open chat with client for manager", new string[] {
                "p1"}, Description="Given: Client is created\r\nAnd: Client is logged\r\nAnd: Manager is created\r\nAnd: Ma" +
            "nager is logged\r\nWhen: Manager open page with clients for communication\r\nAnd: Ma" +
            "nager click on client line\r\nThan: Chat is opened", SourceLine=6)]
        public virtual void IsIsPossibleOpenChatWithClientForManager()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Is is possible open chat with client for manager", "Given: Client is created\r\nAnd: Client is logged\r\nAnd: Manager is created\r\nAnd: Ma" +
                    "nager is logged\r\nWhen: Manager open page with clients for communication\r\nAnd: Ma" +
                    "nager click on client line\r\nThan: Chat is opened", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Display pop-up notification about sms", new string[] {
                "p1"}, Description=@"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
Than: Displayed pop-up notification about sms
And: Pop-up notification contains client number", SourceLine=16)]
        public virtual void DisplayPop_UpNotificationAboutSms()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display pop-up notification about sms", @"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
Than: Displayed pop-up notification about sms
And: Pop-up notification contains client number", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Redirect on page with client chat if click on number which contains in pop-up not" +
            "ification", new string[] {
                "p1"}, Description=@"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
Then: Menager is redirected on page with client chat", SourceLine=27)]
        public virtual void RedirectOnPageWithClientChatIfClickOnNumberWhichContainsInPop_UpNotification()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Redirect on page with client chat if click on number which contains in pop-up not" +
                    "ification", @"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
Then: Menager is redirected on page with client chat", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 28
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Chat history is save", new string[] {
                "p1"}, Description=@"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
And: Manager close chat
And: Mahager open page chat with clients
And: Manager click on client line
Then: Chat is opened
And: Chat history is saved", SourceLine=38)]
        public virtual void ChatHistoryIsSave()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Chat history is save", @"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Client open chat with manager
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
And: Manager close chat
And: Mahager open page chat with clients
And: Manager click on client line
Then: Chat is opened
And: Chat history is saved", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Is is possible to send sms for client if client offline", new string[] {
                "p1"}, Description="Given: Client is created\r\nAnd: Manager is created\r\nAnd: Manager is logged\r\nWhen: " +
            "Manager open page with clients for communication\r\nAnd: Manager click on client l" +
            "ine\r\nAnd: Manager send unique sms for clients\r\nThen: Sms is sended", SourceLine=53)]
        public virtual void IsIsPossibleToSendSmsForClientIfClientOffline()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Is is possible to send sms for client if client offline", "Given: Client is created\r\nAnd: Manager is created\r\nAnd: Manager is logged\r\nWhen: " +
                    "Manager open page with clients for communication\r\nAnd: Manager click on client l" +
                    "ine\r\nAnd: Manager send unique sms for clients\r\nThen: Sms is sended", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Page with clients for communication is disabled if chat functional turn off", new string[] {
                "p1"}, Description="Given: Client is created\r\nAnd: Manager is created\r\nAnd: Manager is logged\r\nAnd: C" +
            "hat functional turn off\r\nWhen: Manager open page with clients for communication " +
            "\r\nThen: Page with clients for communication does not available", SourceLine=63)]
        public virtual void PageWithClientsForCommunicationIsDisabledIfChatFunctionalTurnOff()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Page with clients for communication is disabled if chat functional turn off", "Given: Client is created\r\nAnd: Manager is created\r\nAnd: Manager is logged\r\nAnd: C" +
                    "hat functional turn off\r\nWhen: Manager open page with clients for communication " +
                    "\r\nThen: Page with clients for communication does not available", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 64
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Manager have status online if he logged", new string[] {
                "p1"}, Description="Given: Manager is created\r\nAnd: Manager is logged\r\nThen:  Manager has status onli" +
            "ne ", SourceLine=72)]
        public virtual void ManagerHaveStatusOnlineIfHeLogged()
        {
            string[] tagsOfScenario = new string[] {
                    "p1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manager have status online if he logged", "Given: Manager is created\r\nAnd: Manager is logged\r\nThen:  Manager has status onli" +
                    "ne ", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 73
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("smoke", new string[] {
                "smoke"}, Description=@"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Manager open page with clients for communication
And: Manager click on client line
And: Manager send sms for client
And: Manager close chat
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
Then: Chat with client is opened
And: Sms for client is sended
And: Displayed pop-up notification about sms
And: Menager is redirected on page with client chat
And: Chat history is saved", SourceLine=78)]
        public virtual void Smoke()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("smoke", @"Given: Client is created
And: Client is logged
And: Manager is created
And: Manager is logged
When: Manager open page with clients for communication
And: Manager click on client line
And: Manager send sms for client
And: Manager close chat
And: Client send unique sms for manager
And: Manager click on number which contains in pop-up notification
Then: Chat with client is opened
And: Sms for client is sended
And: Displayed pop-up notification about sms
And: Menager is redirected on page with client chat
And: Chat history is saved", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 79
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
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
