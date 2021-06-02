using System;
using System.Net.Http;
using Android.App;
using Android.Content.Res;
using Android.Graphics.Pdf;
using Android.OS;
using Android.Provider;
using Android.Support.V7.App;
using Xamarin.Forms;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Newtonsoft.Json;
using Org.Apache.Http.Client.Params;
using Button = Xamarin.Forms.Button;

namespace AndroidBlankApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var btn = FindViewById(Resource.Id.button);
            btn.Click += async delegate(object sender, EventArgs args)
            {
                using var httpConnection = new HttpClient();
                var result = await httpConnection.GetAsync("https://localhost:5001/drink/get");
                var beer = JsonConvert.DeserializeObject<Drink>(result.Content.ReadAsStringAsync().ToString());
                var elem = FindViewById<TextView>(Resource.Id.textView);
                elem.Text = beer.Name;
            };
        }
    }
}