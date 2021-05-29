@Client
Feature: Client chat
In order to contact with manager
As a client
I want to have chat with manager

@p1
Scenario Is is possible open chat with manager for client
	Given Manager is created
	And Client is created
	And Client is logged
	When Client open chat with manager
	Then Chat is opened

@p1
Scenario:  Display notification about sms
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When Manager open chat with сlient
	And Manager send unique sms for сlient
Than Displayed notification about sms for client

@p1
Scenario: Chat history is save
	Given Client is created
	And Client is logged
	And Manager is created
	And Manager is logged
	When  Manager open chat with сlient
	And Manager send unique sms for сlient
	And Client open chat with manager
	And Client is log out
	And Client sign in
	And Client open chat with manager
	Then Chat is opened
	And Chat history is saved

@p1
Scenario: Is is possible to send sms for manager if manager offline
	Given Manager is created
	And Client is created
	And Client is logged
	When Client open chat with manager
	And Client send unique sms for clients
	Then Sms is sended

@p1
Scenario: Icon for communication with manager is disabled if chat functional turn off
	Given Manager is created
	And Manager is logged
	And Client is created
	And Chat functional turn off
	Then Icon for communication with manager is disabled

@p1
Scenario: Client have status online if he logged
	Given Client is created
	And Client is logged
	Then  Client has status online

Scenario: Client have status offline if he log out
	Given Client is created
	And Client is logged
	When Client log out
	Then  Client has status offline

@smoke
Scenario: Smoke
	Given Manager is created
	And Manager is logged
	And Client is created
	And Client is logged
	When Client open chat with manager
	And Client unique send sms for manager
	And Manager click on number which contains in pop-up notification
	And Manager send unique sms for manager
	And Client is log out
	And Client is sign in
	Then Chat with manager is opened
	And Sms for manager is sended
	And Menager is redirected on page with client chat
	And Displayed notification about sms for client
	And Chat history is saved