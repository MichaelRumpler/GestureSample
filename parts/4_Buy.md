## Buy
{: #Buy }

MR.Gestures is licensed per app name.

If your app has the same name on all platforms, you only need one license key.
If you have hundreds of developers working on the same app, you only need one license key.
If you have different versions of your app with different names (e.g. different languages, customized for different clients or free and pro), then you need a separate key for each version.

The license will be valid forever. You don't need to refresh it every year.

The price for one license is EUR 40,00 (+VAT).

The payment process will be handled by MyCommerce. You will be forwarded to their site when you click the Buy button.

**Please enter the EXACT name of your app.<br />
This is NOT the bundle name. If you write it in lower case or append any whitespaces, it won't work either.
See the [FAQs](#HowToConfigureAppName) on how to configure it.**

<form>
<div class="form-group">
<div class="row">
<div class="input-group col-sm-8 col-lg-6">
<input type="text" class="form-control" id="appName" placeholder="App Name">
<span class="input-group-btn"><button class="btn btn-default" type="button" id="buyBtn">Buy</button></span>
</div>
</div>
</div>
</form>

Once you purchased a license, instructions how to configure it will be displayed on the MyCommerce page. These instructions can also be found in the email they will send you and in the [FAQs](#HowToConfigureTheLicenseKey).

If you forget to configure the license key properly, then all the events will still be raised, but the properties of the `EventArgs` will be empty. That may be enough for the tap and long press events, but not for the more complicated ones.
