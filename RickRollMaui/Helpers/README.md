# Twilio Helper

## Availing A Twilio Account And Phone Number

Sign up for a [Twilio account](https://www.twilio.com/referral/zigWwk) if you don't have one already.

The Twilio Account SID and Auth Token can be obtained from your Twilio console. You can purchase a Twilio phone number using [this guide](https://support.twilio.com/hc/en-us/articles/223135247-How-to-Search-for-and-Buy-a-Twilio-Phone-Number-from-Console).

## Create the Twilio Helper

Create a `TwilioHelper.cs` class as follows:

```csharp
namespace RickRollMaui.Helpers;

public class TwilioHelper
{
    public static string TwilioAccountSID { get; set; } = "<Twilio Account SID>";

    public static string TwilioAuthToken { get; set; } = "<Twilio Auth Token>";

    public static string TwilioPhoneNumber { get; set; } = "<Twilio Phone Number>";
}
```