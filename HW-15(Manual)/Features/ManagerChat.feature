Feature: Manager chat
In order to contact with client
As a manager 
I want to had chat with client

@p1
Scenario: Is is possible open chat with client for manager
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Manager open page with clients for communication
	And Manager click on client line
Than Chat is opened

@p1
Scenario:  Display pop-up notification about sms
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Client open chat with manager
	And Client send unique sms for manager
	Then Displayed pop-up notification about sms
	And Pop-up notification contains client number

@p1
Scenario: Redirect on page with client chat if click on number which contains in pop-up notification
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Client open chat with manager
	And Client send unique sms for manager
	And Manager click on number which contains in pop-up notification
	Then Menager is redirected on page with client chat

@p1
Scenario: Chat history is save
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Client open chat with manager
	And Client send unique sms for manager
	And Manager click on number which contains in pop-up notification
	And Manager close chat
	And Mahager open page chat with clients
	And Manager click on client line
	Then Chat is opened
	And Chat history is saved

@p1
Scenario: Is is possible to send sms for client if client offline
	Given Client is created
	And Manager is created
	And Manager is logged
	When Manager open page with clients for communication
	And Manager click on client line
	And Manager send unique sms for clients
	Then Sms is sended

@p1
Scenario: Page with clients for communication is disabled if chat functional turn off
	Given Client is created
	And Manager is created
	And Manager is logged
	And Chat functional turn off
	When Manager open page with clients for communication
	Then Page with clients for communication does not available

@p1
Scenario: Manager have status online if he logged
	Given Manager is created
	And Manager is logged
	Then  Manager has status online

@smoke
Scenario: Smoke
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Manager open page with clients for communication
	And Manager click on client line
	And Manager send sms for client
	And Manager close chat
	And Client send unique sms for manager
	And Manager click on number which contains in pop-up notification
	Then Chat with client is opened
	And Sms for client is sended
	And Displayed pop-up notification about sms
	And Menager is redirected on page with client chat
	And Chat history is saved