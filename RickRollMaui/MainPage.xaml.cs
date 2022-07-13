using RickRollMaui.Helpers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace RickRollMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void RickRollButtonClicked(object sender, EventArgs e)
	{
		TwilioClient.Init(TwilioHelper.TwilioAccountSID, TwilioHelper.TwilioAuthToken);

		var call = CallResource.Create(
			to: new PhoneNumber(PhoneNumber.Text),
			from: new PhoneNumber(TwilioHelper.TwilioPhoneNumber),
			twiml: new Twiml("<Response><Play>https://demo.twilio.com/docs/classic.mp3</Play></Response>")
		);

		await DisplayAlert("Call Sid", call.Sid.ToString(), "Ok");
	}
}

