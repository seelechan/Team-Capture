using NUnit.Framework;
using Team_Capture.Core.UserAccount;
using Team_Capture.Logging;

namespace Team_Capture.Editor.Tests
{
    public class UserTests
    {
	    private const string DiscordAccountName = "Discord";
	    private const string SteamAccountName = "Steam";
	    private const string OfflineAccountName = "Offline";

		[OneTimeSetUp]
		public void Setup()
		{
			Logger.Init();
		}

		[OneTimeTearDown]
		public void Shutdown()
		{
			Logger.Shutdown();
		}

	    [Test]
	    public void GetDefaultAccountSteamOrDiscordTest()
	    {
			User.Init();
			User.AddAccount(new Account
		    {
			    AccountName = DiscordAccountName,
			    AccountProvider = AccountProvider.Discord
		    });

			User.AddAccount(new Account
			{
				AccountName = SteamAccountName,
				AccountProvider = AccountProvider.Steam
			});

			Account account = User.DefaultAccount;
			Assert.AreEqual(AccountProvider.Steam, account.AccountProvider);
			Assert.AreEqual(SteamAccountName, account.AccountName);
	    }

	    [Test]
	    public void GetDefaultAccountDiscordOrOfflineTest()
	    {
		    User.Init();

		    User.AddAccount(new Account
		    {
			    AccountName = DiscordAccountName,
			    AccountProvider = AccountProvider.Discord
		    });

		    Account account = User.DefaultAccount;
		    Assert.AreEqual(AccountProvider.Discord, account.AccountProvider);
		    Assert.AreEqual(DiscordAccountName, account.AccountName);
	    }

	    [Test]
	    public void GetDefaultAccountSteamOrOfflineTest()
	    {
		    User.Init();

		    User.AddAccount(new Account
		    {
			    AccountName = SteamAccountName,
			    AccountProvider = AccountProvider.Steam
		    });

		    Account account = User.DefaultAccount;
		    Assert.AreEqual(AccountProvider.Steam, account.AccountProvider);
		    Assert.AreEqual(SteamAccountName, account.AccountName);
	    }

	    [Test]
	    public void GetDefaultAccountOfflineTest()
	    {
		    User.Init();

		    Account account = User.DefaultAccount;
		    Assert.AreEqual(AccountProvider.Offline, account.AccountProvider);
			Assert.AreEqual(OfflineAccountName, account.AccountName);
	    }
    }
}
